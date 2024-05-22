using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscreteMarkovChainWeatherForecast
{
    public partial class Form1 : Form
    {
        WeatherInfo forecaster;
        Label[] labels;
        public Form1()
        {
            InitializeComponent();
            labels = new Label [] { resultClear, resultCloudy, resultOvercast };
        }

        int days, currentDay;
        class WeatherInfo
        {
            public WeatherInfo(int initState) {
                this.initState = initState;
                this.Initate();
            }
            private double[,] stepMatrix = {
                { 0.6, 0.3, 0.1 },    // Clear
                { 0.4, 0.2, 0.4 },    // Cloudy
                { 0.1, 0.4, 0.5 }     // Overcast
            };
            private int initState;
            public double[] currentStates;
            private void Initate() {
                this.currentStates = new double[3];
                this.currentStates[0] = stepMatrix[this.initState, 0];
                this.currentStates[1] = stepMatrix[this.initState, 1];
                this.currentStates[2] = stepMatrix[this.initState, 2];
            }
            public void ForeCast()
            {
                double[] temp = new double[3];
                for (int i = 0;i<3; i++)
                {
                    temp[i] = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        temp[i] += currentStates[j] * stepMatrix[j,i];
                    }
                }
                for (int i = 0; i < 3; i++) currentStates[i] = temp[i];
            }
       


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_Points();
            int selectedIndex = currentStateComboBox.SelectedIndex;
            if (selectedIndex >= 0)
            {
                
                days = (int)daysForwardInput.Value;
                forecaster = new WeatherInfo(selectedIndex);
                currentDay = 1;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Please select a state from the combo box.");
            }
        }
        private void add_Points(double[] data,int day)
        {
            for (int i = 0; i < 3; i++)
            {
                weatherChart.Series[i].Points.AddXY(day, data[i]*100);
                labels[i].Text = (data[i]*100).ToString("0.00")+ "%";
            }
        }
        private void clear_Points()
        {
            
            for (int i = 0; i < 3; i++)
            {
                weatherChart.Series[i].Points.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            currentDay++;
            if (currentDay <= days)
            {
                
                add_Points(forecaster.currentStates, currentDay);
                forecaster.ForeCast();
            }
        }
    }
}
