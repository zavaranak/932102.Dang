using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //"Вьетнам", "Тайланд", "Камбоджия", "Малайзия", "Индонезия", "Филиппин", "Сингапур", "Лаос"
        //0         1           2           3           4               5           6           7
        public string[] asean = { "Вьетнам", "Тайланд", "Камбоджия", "Малайзия", "Индонезия", "Филиппин", "Сингапур", "Лаос" };
        public double[] avg = { 2.3, 2.8, 1.7, 1.9, 2.5, 2.5, 2, 1.9 };
        public int[][] pair = new int[8][];
        List<int> tempTeam2 = new List<int>();
        int team1 = -1;
        int team2 = -1;
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();

            // Create a DataTable and define its columns
            table.Columns.Add("Страна", typeof(string));
            table.Columns.Add("Игра", typeof(int));
            table.Columns.Add("Выигр", typeof(int));
            table.Columns.Add("Проигр", typeof(int));
            table.Columns.Add("Ничья", typeof(int));
            table.Columns.Add("Гол(В)", typeof(int));
            table.Columns.Add("Гол(П)", typeof(int));
            table.Columns.Add("Балл", typeof(int));
            // Now add rows with the data
            for (int i = 0; i < asean.Length; i++)
            {
                DataRow row = table.NewRow();
                row["Страна"] = asean[i]; // Assuming 'asean' is an array of country names
                for (int j = 1; j < table.Columns.Count; j++)
                {
                    row[j] = 0; // Initialize other cells to 0
                }
                table.Rows.Add(row);
            }

            // Assign the DataTable as the DataSource for the DataGridView
            dataGridView1.DataSource = table;

            // Setup the pair array, not related to DataGridView
            for (int i = 0; i < 8; i++)
            {
                pair[i] = new int[8];
                for (int j = 0; j < 8; j++)
                    pair[i][j] = (j == i) ? 1 : 0;
            }
        }


        static int SimulateGoals(double lambda)
        {
            int goals = 0;
            Random random = new Random();
            goals = GeneratePoisson(random, lambda);

            return goals;
        }

        static int GeneratePoisson(Random random, double lambda)
        {
            double p = 1.0;
            int k = 0;

            while (p > Math.Exp(-lambda))
            {
                p *= random.NextDouble();
                k++;
            }
            return k - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchStart();
        }

        private void MatchStart()
        {
            if ((team1 != -1) && (team2 != -1))
            {
                pair[team1][team2] = 1;
                pair[team2][team1] = 1;
                int goals1, goals2;
                // Simulate the number of goals scored by Team A in 100 matches
                goals1 = SimulateGoals(avg[team1]);
                // Print some statistics about the number of goals scored

                goals2 = SimulateGoals(avg[team2]);
                // Print some statistics about the number of goals scored
                Console.WriteLine(asean[team1] + " " + goals1 + ":" + goals2 + " " + asean[team2]);
                result.Text = asean[team1] + " " + goals1 + ":" + goals2 + " " + asean[team2];
                UpdateResult(goals1, goals2);
                team1 = -1;
                team2 = -1;
                tempTeam2.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox2.Items.Clear();
            }
        }

        private void UpdateResult(int goals1, int goals2)
        {
            table.Rows[team1]["Игра"] = (int)table.Rows[team1]["Игра"] + 1;
            table.Rows[team2]["Игра"] = (int)table.Rows[team2]["Игра"] + 1;
            table.Rows[team1]["Гол(В)"] = (int)table.Rows[team1]["Гол(В)"] + goals1;
            table.Rows[team2]["Гол(В)"] = (int)table.Rows[team2]["Гол(В)"] + goals2;
            table.Rows[team1]["Гол(П)"] = (int)table.Rows[team1]["Гол(П)"] + goals2;
            table.Rows[team2]["Гол(П)"] = (int)table.Rows[team2]["Гол(П)"] + goals1;
            if (goals1 == goals2)
            {
                table.Rows[team1]["Ничья"] = (int)table.Rows[team1]["Ничья"] + 1;
                table.Rows[team2]["Ничья"] = (int)table.Rows[team2]["Ничья"] + 1;
                table.Rows[team1]["Балл"] = (int)table.Rows[team1]["Балл"] + 1;
                table.Rows[team2]["Балл"] = (int)table.Rows[team2]["Балл"] + 1;
            }
            else if (goals1 > goals2)
            {
                table.Rows[team1]["Выигр"] = (int)table.Rows[team1]["Выигр"] + 1;
                table.Rows[team2]["Проигр"] = (int)table.Rows[team2]["Проигр"] + 1;
                table.Rows[team1]["Балл"] = (int)table.Rows[team1]["Балл"] + 3;
            }
            else
            {
                table.Rows[team2]["Выигр"] = (int)table.Rows[team2]["Выигр"] + 1;
                table.Rows[team1]["Проигр"] = (int)table.Rows[team1]["Проигр"] + 1;
                table.Rows[team2]["Балл"] = (int)table.Rows[team2]["Балл"] + 3;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string selectedTeam = comboBox1.SelectedItem.ToString();
            int k = 0;
            while (k < 8)
            {
                if (asean[k] == selectedTeam)
                {
                    team1 = k;
                    for (int i = 0; i < 8; i++)
                    {
                        if (pair[k][i] == 0)
                        {
                            comboBox2.Items.Add(asean[i]);
                            tempTeam2.Add(i);
                        }
                    }
                    break;
                }
                k++;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = comboBox2.SelectedIndex;
            team2 = tempTeam2[k];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
