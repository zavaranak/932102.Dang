using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;

        decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy, dt;
        int counter = 0;
        DateTime start;

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Clear();
            timer1.Stop();
        }

       
        private void timer1_Tick(object sender, EventArgs e)
            {
                TextBox[] timeStepText = {TimeStep1,TimeStep2,TimeStep3,TimeStep4,TimeStep5} ;
                TextBox[] distanceText = { Distance1 , Distance2 , Distance3 , Distance4 , Distance5};
                TextBox[] maxHeightText = { MH1, MH2, MH3, MH4, MH5 };
                TextBox[] endSpeedText = { EndSpeed1, EndSpeed2, EndSpeed3, EndSpeed4, EndSpeed5 };
                decimal maxHeight = y;
                decimal endSpeed;
                t += dt;
                decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
                vx = vx - k * vx * v * dt;
                vy = vy - (g + k * vy * v) * dt;
                x = x + vx * dt;
                y = y + vy * dt;
                if (y >= maxHeight) maxHeight = y;
                chart1.Series[counter].Points.AddXY(x, y);
                if (y <= 0)
                {
                distanceText[counter].Text = x.ToString();
                TimeSpan timeStep = DateTime.Now - start;
                timeStepText[counter].Text = timeStep.TotalSeconds.ToString();
                maxHeightText[counter].Text = maxHeight.ToString();
                endSpeed = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
                endSpeedText[counter].Text= endSpeed.ToString();
                counter++;
                timer1.Stop();
            }
            }

      

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (counter == 5) Clear();
            if (!timer1.Enabled)
            {
                t = 0;
                x = 0;
                dt = edStep.Value;
                y = edHeight.Value;
                v0 = edSpeed.Value;
                double a = (double)edAngle.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = edSize.Value;
                m = edWeight.Value;
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                chart1.Series[counter].Points.AddXY(x, y);
                chart1.Series[counter].Name = "["+(counter+1).ToString()+"] Step:" + edStep.Value.ToString();
                timer1.Start();
                start = DateTime.Now;
            }
        }

        private void Clear()
        {   TextBox[] timeStepText = { TimeStep1, TimeStep2, TimeStep3, TimeStep4, TimeStep5 };
            TextBox[] distanceText = { Distance1, Distance2, Distance3, Distance4, Distance5 };
            TextBox[] maxHeightText = { MH1, MH2, MH3, MH4, MH5 };
            TextBox[] endSpeedText = { EndSpeed1, EndSpeed2, EndSpeed3, EndSpeed4, EndSpeed5 };
            for (int i = 0; i < 5; i++) {
                chart1.Series[i].Points.Clear();
                timeStepText[i].Text = ""; distanceText[i].Text = ""; maxHeightText[i].Text = ""; endSpeedText[i].Text = "";
                chart1.Series[i].Name = (i + 1).ToString();
            }
            counter = 0;
        }
    }
}
