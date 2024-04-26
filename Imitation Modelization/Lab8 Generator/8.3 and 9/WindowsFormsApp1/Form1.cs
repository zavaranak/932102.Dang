using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<double> dataset;
        List<int> statistics;
        List<double> p;
        List<double> prob;
        double sum;
        int N;
        double avarage, variance, avarage2, variance2, chi1;
        class chi
        {
            public double value;
            public double error;
            public chi(double value, double error)
            {
                this.value = value;
                this.error = error;
            }
        }
        Random datrich = new Random();
        List<chi> chiCriteria = new List<chi> { new chi(9.488, 0.05), new chi(13.277, 0.01), new chi(18.467, 0.001) };
        public Form1()
        {
            InitializeComponent();
        }
        public void HandleTrial()
        {
            prob.Add((double)prob1.Value);
            prob.Add((double)prob2.Value);
            prob.Add((double)prob3.Value);
            prob.Add((double)prob4.Value);
            prob.Add(1);
            N = (int)trialNum.Value;
            sum = 0;
            for (int i = 0; i < N; i++)
            {
                double pTemp = datrich.NextDouble();
                dataset.Add(pTemp);
                sum += pTemp;
                for (int j = 0; j < 5; j++)
                {
                    double gap = 0;
                    if (j > 0) gap = (prob[j] - prob[j - 1]) / 2;
                    if (pTemp < prob[j])
                    {
                        if ((pTemp < prob[j] - gap) && (j > 0))
                        {
                            statistics[j - 1]++;
                            break;
                        }
                        else { statistics[j]++; break; }
                    }
                }

            }
            for (int i = 0; i < 5; i++)
            {
                p.Add((double)statistics[i] / N);
                chart1.Series[0].Points.AddXY(i + 1, p[i]);
            }
        }
        public void StatisticProperties()
        {
            avarage = sum / N;
            avarageBox.Text = avarage.ToString();
            avarage2 = 0;
            variance2 = 0;
            double tempSum = 0.0;
            for (int i = 0; i < p.Count; i++)
            {
                avarage2 += p[i] * prob[i];
            }
            avarage2Box.Text = avarage2.ToString();
            for (int i = 0; i < p.Count; i++)
            {
                double temp = prob[i] - avarage2;
                variance2 += p[i] * (temp * temp);
            }
            variance2Box.Text = variance2.ToString();
            for (int i = 0; i < dataset.Count; i++)
            {
                double temp = (dataset[i] - avarage2);
                tempSum += temp * temp;
            }
            variance = tempSum / N;
            varianceBox.Text = variance.ToString();
            errorABox.Text = Math.Abs(avarage2 - avarage).ToString();
            errorVBox.Text = Math.Abs(variance2 - variance).ToString();
        }
        public void CriteriaChi()
        {
            bool done = false;
            chi1 = 0;
            for (int i = 0; i < dataset.Count; i++)
            {
                chi1 += Math.Pow(dataset[i] - avarage, 2) / avarage;
            }
            chiBox.Text = chi1.ToString("F2");
            for (int i = chiCriteria.Count - 1; i >= 0; i--)
            {
                if (chi1 > chiCriteria[i].value)
                {
                    chiBox.Text += ">" + chiCriteria[i].value.ToString("F2") + " is True with a= " + chiCriteria[i].error.ToString();
                    done = true;
                    break;
                }
            }
            if (!done)
            {
                chiBox.Text += " is False";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            statistics = new List<int> { 0, 0, 0, 0, 0 };
            p = new List<double>();
            prob = new List<double>();
            dataset = new List<double>();
            chart1.Series[0].Points.Clear();
            HandleTrial();
            StatisticProperties();
            CriteriaChi();
        }
    }
}
