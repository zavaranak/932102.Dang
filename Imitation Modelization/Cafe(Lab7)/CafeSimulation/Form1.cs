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
        double reputation() { return marketingeffort + pricing - marketcompetition;}
        double customerSatisfaction() {return taskDoneRate() +menuvarity(); }
        double customerArrival() { return reputation()+customerSatisfaction(); }
        double preprationEffort() { return employee * 0.1; }
        double menuvarity() { return inventorylevel; }
        //stock
        double revenue = 1;
        double cost = 1;
        double profit= 1;
        double employee = 10;
        double task = 1;
        double order = 1;
        //vavle
        double hiringRate() { return quitRate(); }
        double quitRate() { return newTaskRate(); }
        double newTaskRate() { return newOrderRate()-cancelOrderRate(); }
        double taskDoneRate() { return preprationEffort() + employeeSkill; }
        double cancelOrderRate() { if (customerSatisfaction() < 0) return -0.1 * customerSatisfaction();
            else return 0; }
        double newOrderRate() { return customerArrival() - pricing; }
        double incomeRate() { return newOrderRate() + pricing; }
        double costRate() { return marketingeffort+inventorylevel+hiringRate(); }
        double profitRate() { return -0.0000001*incomeRate(); }
        //evaluate stock after 1 day
        public void evaluateTask() {
            task = task + newTaskRate() - taskDoneRate();
        }
        public void evaluateCost() {
            //cost = cost + costRate() - profitRate();
            cost = revenue*costRate();
        }
        public void evaluateEmployee() {
            employee = employee + hiringRate()-quitRate();
        }
        public void evaluateOrder() {
            order = order + newOrderRate() - cancelOrderRate();
        }
        public void evaluateRevenue() {
            revenue = revenue + incomeRate() - costRate();
        }
        public void evaluateProfit() {
            profit = cost *(1-profitRate());
        }
        //evaluate variables
  
        private void button1_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                marketingeffort = (double)marketing.Value;
                inventorylevel = (double)inventory.Value;
                marketcompetition = (double)competition.Value*10;
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
            chart1.Series[0].Points.AddXY(day, cost);
            chart1.Series[1].Points.AddXY(day, revenue);
            day++;
        }
        public void calculateStep()
        {
            evaluateRevenue();
            evaluateEmployee();
            evaluateOrder();
            evaluateTask();
            evaluateCost();
            //evaluateProfit();
        }
    }
}
