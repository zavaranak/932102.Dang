using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
        double[] price = { 0,0,0,0 };
        BrownianMotionCurrency[] currencies; 

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                currencies = new BrownianMotionCurrency[4];
                price[0] = (double)edUSD.Value;
                price[1] = (double)edEuro.Value;
                price[2] = (double)edFranc.Value;
                price[3] = (double)edPound.Value;
                for (int i = 0; i < 4; i++) currencies[i] = new BrownianMotionCurrency(price[i],0,rnd.NextDouble());
                start = true;
                timer1.Start();
            }
            else { start = false; timer1.Stop(); }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                price[i] = currencies[i].SimulateValue();
                chart1.Series[i].Points.AddXY(day, price[i]);
            }
            day++;
        }


        public class BrownianMotionCurrency
        {
            private readonly double initialValue;
            //Мат ожидание
            private readonly double drift;
            //Дисперсия
            private readonly double volatility;
            private readonly Random random;

            public BrownianMotionCurrency(double initialValue, double drift, double volatility)
            {
                this.initialValue = initialValue;
                this.drift = drift;       
                this.volatility = volatility;
                this.random = new Random();
            }

            public double SimulateValue()
            {
                int timeStep = 1;
                double randomNumber = random.NextDouble();
                double standardNormalVariate = Math.Sqrt(-2.0 * Math.Log(randomNumber)) * Math.Cos(2.0 * Math.PI * random.NextDouble());
                double increment = drift * timeStep + volatility * standardNormalVariate * Math.Sqrt(timeStep);
                return initialValue + increment;
            }
        }
    }
}
