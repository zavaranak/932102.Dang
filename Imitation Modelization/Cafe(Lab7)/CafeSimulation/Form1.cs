using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //константы
        double marketingeffort = 0;
        double inventorylevel = 0;
        double marketcompetition = 0;
        double pricing = 0;
        double employeeSkill = 0;
        int day = 0;
        bool start = false;
        //переменные
        double reputation = 0;
        double customerSatisfaction = 0;
        double customerArrival = 0;
        double preparationEffort = 0;
        double menuvarity = 0;
        public void evaluatereputation() { reputation = marketingeffort + pricing - marketcompetition;}
        public void  evaluatecustomerSatisfaction() {customerSatisfaction = taskDoneRate() +menuvarity; }
        public void  evaluatecustomerArrival() { customerArrival = reputation + customerSatisfaction; }
        public void evaluatepreprationEffort() { preparationEffort = employee * 0.05; }
        public void evaluatemenuvarity() { menuvarity = inventorylevel; }
        //stock
        double capital = 10;
        double profit= 0;
        double employee = 10;
        double task = 0;
        double order = 0;
        //vavle
        double hiringRate() { return 2.5 - employeeSkill; }
        double quitRate() { return 2; }
        double newTaskRate() { return orderInProcessRate()*1.3; }
        double taskDoneRate() { return preparationEffort + employeeSkill; }
        double orderInProcessRate() { return newOrderRate() *0.9 - 0.1*customerSatisfaction; }
        double newOrderRate() { return customerArrival - pricing; }
        double revenueRate() { return orderInProcessRate() + 0.3*pricing; }
        double costRate() { return marketingeffort+inventorylevel+hiringRate(); }
        double profitRate() { return revenueRate(); }
        //evaluate stock after 1 day
        public void evaluateTask() {
            task = task + newTaskRate() - taskDoneRate();
        }
 
        public void evaluateEmployee() {
            employee = employee + hiringRate()-quitRate();
        }
        public void evaluateOrder() {
            order = order + newOrderRate() - orderInProcessRate();
        }
        public void evaluateCapital() {
            capital = capital +  revenueRate() - costRate();
        }
        //evaluate variables
  
        private void button1_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                marketingeffort = (double)marketing.Value;
                inventorylevel = (double)inventory.Value;
                marketcompetition = (double)competition.Value;
                pricing = (double)pricinginput.Value;
                employeeSkill = (double)skill.Value;
                start = true;
                timer1.Start();
            }
            else { start = false; timer1.Stop(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            calculateStep();
            chart1.Series[0].Points.AddXY(day, employee);
            chart1.Series[1].Points.AddXY(day, capital);
            chart1.Series[2].Points.AddXY(day,  order);
            chart1.Series[3].Points.AddXY(day, task);
            day++;
        }
        public void calculateStep()
        {   //evaluate param
            evaluatereputation();
            evaluatepreprationEffort();
            evaluatemenuvarity();
            evaluatecustomerSatisfaction();
            evaluatecustomerArrival();
            //evaluate stock
            evaluateEmployee();
            evaluateOrder();
            evaluateTask();
            evaluateCapital();
        }
    }
}
