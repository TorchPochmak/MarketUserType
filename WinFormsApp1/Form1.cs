using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using MarketUserType.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public const string QUESTIONS = "./questions.txt";

        private List<int> answers = new List<int>();
                      //когда срал?    { вчера, сегодня, позавчера }
        private List<(string, List<string>)> questionsChoose = new List<(string, List<string>)>();//Loaded from files

        private int questionNumber = 0;

        public List<RJButton> Buttons = new List<RJButton>();// список кнопок

        public Form1()
        {
            InitializeComponent();
            Buttons.Add(Ans1);
            Buttons.Add(Ans2);
            Buttons.Add(Ans3);
            Buttons.Add(Ans4);
            Buttons.Add(Ans5);
            Buttons.Add(Ans6);
            Buttons.Add(Ans7);
            Buttons.Add(Ans8);
        }
        private void DisableClicksExcept(int exception)
        {
            for (int i = 0; i < Buttons.Count; ++i)
            {
                if (i != exception) Buttons[i].DisableClick();
            }
        }
        private void LoadFromFile(string path)
        {
            try
            {
                using (StreamReader fr = new StreamReader(path))
                {
                    while (true)
                    {
                        string s = fr.ReadLine();
                        if (s == null)
                        {
                            fr.Close();
                            return;
                        }
                        string[] qa = s.Split(':');
                        (string, List<string>) tuple = (qa[0], qa[1].Split('#').ToList());
                        questionsChoose.Add(tuple);
                        answers.Add(-1);
                    }
                }
            }
            catch(Exception ex) 
            {
                
                throw ex;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //after init
            try
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                LoadFromFile(QUESTIONS);
                Show();
            }
            catch (Exception ex)
            {
                ShowCustomMessageBox($"Файл с вопросами не найден", "Error",false);
            }
            
        }

        private void Show()
        {

            (string q, List<string> lst) = questionsChoose[questionNumber];
            for (int i = lst.Count; i < Buttons.Count; i++)
            {
                Buttons[i].Visible = false;
            }
            MainQ.Text = q;
            for (int i = 0; i < Buttons.Count; i++)
            {
                Buttons[i].DisableClick();
            }
            for (int i = 0; i < lst.Count; i++)
            {
                Buttons[i].Text = lst[i];
                Buttons[i].Visible = true;
                if (questionNumber == questionsChoose.Count - 1)
                {
                    Buttons[i].Font = new Font(Buttons[i].Font.Name, 10, FontStyle.Regular);
                }
            }
            if (answers[questionNumber] != -1)
            {
                Buttons[answers[questionNumber]].EnableClick();
            }

        }

        private void Answer_Click(object sender, EventArgs e)
        {
            int i = ((RJButton)sender).AnswerNumber;
            DisableClicksExcept(i);
            answers[questionNumber] = i;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (questionNumber != 0)
            {
                questionNumber--;
                Show();
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (questionNumber != questionsChoose.Count - 1)
            {
                questionNumber++;
                Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < answers.Count; ++i)
            {
                if (answers[i] == -1)
                {
                   ShowCustomMessageBox($"Вы не ответили на все вопросы ({i + 1})", "Error", false);
                   return;
                }
            }
            //SEND TO SREVER ANSWERS
            ShowCustomMessageBox($"Обработка ответов...", "Success", true);

        }
        private void ShowCustomMessageBox(string message, string title, bool start_neuron)
        {
            Form2 messageBox;
            if (start_neuron)
                messageBox = new Form2(answers);
            else
                messageBox = new Form2();
            messageBox.Text = title;
            messageBox.SendText(message);
            messageBox.ShowDialog();
        }

        private void ExitProcess(object? sender, EventArgs e)
        {
            var process = (Process)sender;
            process.Close();
        }
    }
}