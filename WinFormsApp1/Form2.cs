using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public const string PATH_OUPTUT = "./client_out.csv";//0,2,3,0,3,0,0

        public const string NEURON_PATH = "./network.exe";//starting..

        public const string NEURON_OUTPUT_PATH = "./network_out.txt";//SHOW IT
        public Form2()
        {
            InitializeComponent();
        }
        public void SendText(string text)
        {
            label1.Text = text;
        }

        public void RunNetwork(List<int> Answers)
        {
            try
            {
                using (StreamWriter fr = new StreamWriter(PATH_OUPTUT, false))
                {
                    for (int i = 0; i < Answers.Count; i++)
                    {
                        fr.Write(Answers[i]);
                        fr.Write(" ");
                    }
                }
            }
            catch 
            {
                label1.Text = "Не найден путь к файлу вывода ответов";
            }
            //
            using (var process = new Process())
            {
                try
                {
                    process.StartInfo.FileName = NEURON_PATH;
                    process.StartInfo.CreateNoWindow = true;
                    process.EnableRaisingEvents = true;
                    process.Start();
                }
                catch (Exception ex)
                {
                    process.Dispose();//?..
                    label1.Text = "Нейронная сеть не работает. Проверьте путь к файлу";
                }
                process.WaitForExit();
                try
                {
                    using (StreamReader fr = new StreamReader(NEURON_OUTPUT_PATH))
                    {
                        string s = fr.ReadToEnd();

                        label1.Text = s;
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = "Нейронная сеть отработала неправильно";
                }
            }
        }
    }
}
