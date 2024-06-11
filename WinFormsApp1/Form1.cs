using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using MarketUserType.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public const string PATH_OUPTUT = "./client_out.csv";//0,2,3,0,3,0,0

        public const string NEURON_PATH = "./network.exe";//starting..

        public const string NEURON_OUTPUT_PATH = "./network_out.txt";//SHOW IT

        private List<int> Answers = new List<int>();

        private List<(string, List<string>)> QuestionsChoose = new List<(string, List<string>)>();//Loaded from files

        private int question_number = 0;

        public List<RJButton> Buttons = new List<RJButton>();

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
                    QuestionsChoose.Add(tuple);
                    Answers.Add(-1);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            LoadFromFile("./questions.txt");
            Show();
        }

        private void Show()
        {

            (string q, List<string> lst) = QuestionsChoose[question_number];
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
                if (question_number == QuestionsChoose.Count - 1)
                {
                    Buttons[i].Font = new Font(Buttons[i].Font.Name, 10, FontStyle.Regular);
                }
            }
            if (Answers[question_number] != -1)
            {
                Buttons[Answers[question_number]].EnableClick();
            }

        }

        private void Answer_Click(object sender, EventArgs e)
        {
            int i = ((RJButton)sender).AnswerNumber;
            DisableClicksExcept(i);
            Answers[question_number] = i;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (question_number != 0)
            {
                question_number--;
                Show();
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (question_number != QuestionsChoose.Count - 1)
            {
                question_number++;
                Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < Answers.Count; ++i)
            {
                if (Answers[i] == -1)
                {
                    ShowCustomMessageBox($"Вы не ответили на все вопросы ({i + 1})", "Error", true);
                   return;
                }
            }
            //SEND TO SREVER ANSWERS
            Form2 box = ShowCustomMessageBox($"Обработка ответов...", "Success", false);
            box.ShowDialog();

        }
        private Form2 ShowCustomMessageBox(string message, string title, bool start)
        {
            Form2 messageBox;
            if (!start)
                messageBox = new Form2(Answers);
            else
                messageBox = new Form2();
            messageBox.Text = title;
            messageBox.SendText(message);
            if (start) messageBox.ShowDialog();
            return messageBox;
        }

        private void ExitProcess(object? sender, EventArgs e)
        {
            var process = (Process)sender;
            process.Close();
        }
    }
}