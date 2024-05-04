using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int size;
        public double mean = 0;
        public double variance = 1;
        public double[] normalDistributrion;
        public int interval = 7;
        public int[] statistic;
        public double[] edges = new double[8];
        public double[] prob;
        public double step;
        public double mean2, variance2;
        double chiCriteria;
        //m=7-1=6|| Chi: 12.592 | 16.812 | 22.458
        List<chi> ChiValue = new List<chi> { new chi(12.592, 0.05), new chi(16.812, 0.01), new chi(22.458, 0.001) };
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
        public Form1()
        {
            InitializeComponent();
        }


        public void HandleTrial()
        {
            //Initate params
            size = (int)sizeInput.Value;
            mean = (double)meanInput.Value;
            variance = (double)varInput.Value;
            normalDistributrion = new double[size];
            for (int i = 0; i < size; i += 2)
            {
                double[] pair = GenerateNextNormalPair();
                normalDistributrion[i] = pair[0];
                normalDistributrion[i + 1] = pair[1];
            }
            Console.WriteLine("Min:" + normalDistributrion.Min());
            Console.WriteLine("Max:" + normalDistributrion.Max());
            step = (normalDistributrion.Max() - normalDistributrion.Min()) / interval;

            //Set edges;
            edges[0] = normalDistributrion.Min();
            for (int i = 1; i < edges.Length; i++)
            {
                edges[i] = edges[i - 1] + step;
            }
            return;
        }
        public void CriteriaAndCharacteristic()
        {
            //Mean and Variance with Error
            //Chi criteria
            chiCriteria = 0.0;
            mean2 = 0;
            variance2 = 0;
            mean2 = normalDistributrion.Average();
            for (int i = 0; i < size; i++)
            {
                chiCriteria += Math.Pow(normalDistributrion[i] - mean, 2);
                variance2 += Math.Pow(normalDistributrion[i], 2) - Math.Pow(mean2, 2);
            }
            variance2 /= size;
            chiCriteria /= mean;
            Console.WriteLine(chiCriteria);
            avarageBox.Text = mean2.ToString("F3") + " Error:" + ((Math.Abs(mean - mean2)) * 100).ToString("F2") + "%";
            varianceBox.Text = variance2.ToString("F3") + " Error:" + ((Math.Abs(variance - variance2)) * 100).ToString("F2") + "%";
            chiBox.Text = chiCriteria.ToString("F2");

            //Check hypothesis
            bool done = false;
            for (int i = ChiValue.Count - 1; i >= 0; i--)
            {
                if (mean != 0)
                    if (chiCriteria > ChiValue[i].value)
                    {
                        chiBox.Text += ">" + ChiValue[i].value.ToString("F2") + " is True with a= " + ChiValue[i].error.ToString();
                        done = true;
                        break;
                    }
            }
            if (!done)
            {
                chiBox.Text += " is False";
            }
            return;
        }
        public void HandleStatistic()
        {
            statistic = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            prob = new double[] { 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < size; i++)
            {
                int j = 0;
                while (j < statistic.Length)
                {
                    if (normalDistributrion[i] <= edges[j + 1])
                    {
                        statistic[j]++;
                        break;
                    }
                    j++;
                }
            }
            for (int i = 0; i < statistic.Length; i++)
            {
                prob[i] = (double)statistic[i] / (double)size;
                chart1.Series[0].Points.AddXY("(" + edges[i].ToString("F2") + "," + edges[i + 1].ToString("F2") + "]", prob[i]);

            }
            return;
        }

        public double[] GenerateNextNormalPair()
        {
            //N(0,1)
            double u1, u2, z0, z1;
            u1 = datrich.NextDouble();
            u2 = datrich.NextDouble();
            z0 = Math.Sqrt(-2 * Math.Log(u1)) * Math.Cos(2 * Math.PI * u2);
            z1 = Math.Sqrt(-2 * Math.Log(u1)) * Math.Sin(2 * Math.PI * u2);
            //N(mean,variance)
            z0 += mean;
            z1 += mean;
            z0 *= Math.Sqrt(variance);
            z1 *= Math.Sqrt(variance);
            return new double[] { z0, z1 };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            HandleTrial();
            HandleStatistic();
            CriteriaAndCharacteristic();
        }
    }
}

