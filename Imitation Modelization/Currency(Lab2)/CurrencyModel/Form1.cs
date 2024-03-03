using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.02;
        Random rnd = new Random();
        bool start = false;
        int day = 0;
        double[] price = { 90, 100 };

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                price[0] = (double)edUSD.Value;
                price[1] = (double)edEuro.Value;
            start = true;
            timer1.Start();
            }
            else { start = false; timer1.Stop(); }

       /*     while (day < 10)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        price[i] = price[i] * (1 + k * (rnd.NextDouble() - 0.5));
                        chart1.Series[i].Points.AddXY(day, price[i]);
                    }
                    day++;
                }*/
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                price[i] = price[i] * (1 + k * (rnd.NextDouble() - 0.5));
                chart1.Series[i].Points.AddXY(day, price[i]);
            }
            day++;
        }
    }
  }
