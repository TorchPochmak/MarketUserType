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

        private BackgroundWorker worker;

        List<int>? Answers = null;
        public Form2(List<int>? answers = null)
        {
            InitializeComponent();
            if (answers != null)
            {
                Answers = answers;
                worker = new BackgroundWorker();
                worker.DoWork += DoNetworkAsync;
                worker.RunWorkerCompleted += NetworkCompleted;
                worker.RunWorkerAsync();
            }
        }
        public void SendText(string text)
        {
            label1.Text = text;
        }
        private void DoNetworkAsync(object? sender, DoWorkEventArgs e)
        {
            string s = RunNetwork(Answers);
            e.Result = s == null ? "" : s;
        }
        private void NetworkCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = e.Result as string;
        }

        public string RunNetwork(List<int> Answers)
        {
            try
            {
                using (StreamWriter fr = new StreamWriter(PATH_OUPTUT, false))
                {
                    for (int i = 0; i < Answers.Count; i++)
                    {
                        fr.Write(Answers[i]);
                        if(i != Answers.Count - 1) fr.Write(",");
                    }
                }
            }
            catch
            {
                 return "Не найден путь к файлу вывода ответов";
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
                    return "Нейронная сеть не работает. Проверьте путь к файлу";
                }
                process.WaitForExit();
            }

            try
            {
                string s = File.ReadAllText(NEURON_OUTPUT_PATH);
                return s;
            }
            catch (Exception ex)
            {
                return "Нейронная сеть отработала неправильно";
            }
        }
    }
}
