using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            questionBox.Text = "На пару сегодня?";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            double p = 0.5;
            double ans = rdn.NextDouble() - p;
            if (ans >= 0)
            {
                answerLabel.Text = "ДА!";
                answerLabel.BackColor = Color.LimeGreen;
                answerLabel.ForeColor = Color.White;
            }
            else
            {
                answerLabel.Text = "НЕТ!";
                answerLabel.BackColor = Color.Red;
                answerLabel.ForeColor = Color.White;
            }
        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
