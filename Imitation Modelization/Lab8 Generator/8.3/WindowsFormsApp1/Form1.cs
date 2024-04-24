using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> state = new List<int> { 1, 2, 3, 4 };
        List<int> statistics;
        List<double> p;
        List<double> prob;
        List<double> trialResult;
        Random datrich = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public void HandleTrial() {

            prob.Add((double)prob1.Value);
            prob.Add((double)prob2.Value);
            prob.Add((double)prob3.Value);
            prob.Add((double)prob4.Value);
            prob.Add(1.0);
            int N = (int)trialNum.Value;
            Console.WriteLine("First Loop");
            for (int i = 0; i<N;i++)
            {
                double pTemp = datrich.NextDouble();
                for (int j = 0; j < 5; j++) {
                    if (pTemp < prob[j])
                    {
                        statistics[j]++;
                        break;
                    }
                }
                
            }
            for(int i = 0; i < 5; i++)
            {
                p.Add((double)statistics[i] / N);
                chart1.Series[0].Points.AddXY(i + 1, p[i]);
            }

        }
        public void RecordState() { }
        public void Analysis()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            statistics = new List<int> { 0, 0, 0, 0, 0 };
            p = new List<double>();
            prob = new List<double>();
            chart1.Series[0].Points.Clear();
            HandleTrial();
        }
    }
}
