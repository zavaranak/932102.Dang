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
        List<double> p = new List<double> { 0.1, 0.3, 0.5, 0.8, 1 };
        List<string> ans = new List<string>
        {
            "Cтрашная идея, бросай!",
            "Не стоит, ты сильно хочешь риска?",
            "Почему нет?",
            "Вот шанс перед тобой, иначе его жалеешь",
            "Да, 3000 раз ДА",
        };
        public Form1()
        {
            InitializeComponent();
            questionBox.Text = "На пару сегодня?";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            double datrich = rdn.NextDouble();
            int i = 0;
            while (i < 5)
            {
                if (datrich < p[i])
                {
                    answerLabel.Text = ans[i];
                    break;
                }
                i++;
            }
       
        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
