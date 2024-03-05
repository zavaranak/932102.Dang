using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ElementaryCellularAutomaton
{
    public partial class Form1 : Form
    {
        private const int gridSize = 23; // Adjust the size as needed

        public Form1()
        {
            InitializeComponent();

            // Set up DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;

            // Customize cell appearance
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnCount = gridSize;
            dataGridView1.RowCount = gridSize;
            int cellSize = Math.Min(dataGridView1.Width / gridSize, dataGridView1.Height / gridSize);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            // Set column and row headers width/height to 0 to hide potential borders
            dataGridView1.RowHeadersWidth = 4;
            dataGridView1.ColumnHeadersHeight = 4;

            // Adjust cell size based on available space
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 22;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 22;
            }

            // Programmatically populate with empty values (optional)
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    dataGridView1[j, i].Value = "";
                }
            }

        }

        bool stop = false;

        int currentIndexRow = 0;
        const int rowLength = 22;
        int[] zeroRow = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0 };
        int[] startRow = { 0, 0, 1, 1, 0, 0, 0, 0, 1,1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0,1 };
        int[] currentValueRow = new int[rowLength];
        int[] binaryRule = new int[8];


        private void buttonLaunch_Click(object sender, EventArgs e)
        {

            int rule = (int)edRule.Value;
            for (int i = 0; i < 8; i++)
            {
                bool isBitSet = (rule & (1 << i)) != 0;
                binaryRule[7 - i] = isBitSet ? 1 : 0;
            }
            if (currentIndexRow == 23)
            {
                Clear();
            }
            if (stop) {timer1.Stop(); stop = false; }
            else {timer1.Start(); stop = true;}
        }
        
        private void GenerateNextRow(int[] row)
        {
            //Show Current Row
            textBox1.Text = row[0].ToString();
            for (int i = 1; i < 22; i++) textBox1.Text += row[i].ToString();
            //Gen New Row
            int[] newRow = zeroRow;
            newRow[0] = ApplyRule(row[rowLength-1], row[0], row[1]);
            newRow[rowLength-1] = ApplyRule(row[rowLength-2], row[rowLength-1], row[0]);
            for (int i =1; i < rowLength-1; i++)
            {
                newRow[i] = ApplyRule(row[i], row[i], row[i+1]);
            }
            //Mark first grid as Index
            dataGridView1[0, currentIndexRow].Value = (currentIndexRow + 1).ToString();
            //Paint color for grids with value 1
            for (int i = 1; i < gridSize; i++) { 

                if (newRow[i-1] == 1) { dataGridView1.Rows[currentIndexRow].Cells[i].Style.BackColor = Color.Green; } 
            }
            currentValueRow = newRow;
            currentIndexRow++;
        }
        private  int ApplyRule(int left,int mid,int right)
        {   
            //Check Binary Rule
            textTest.Text = binaryRule[0].ToString();
            for (int i = 1; i < 8; i++) textTest.Text += binaryRule[i].ToString();
            //Algorithm
            if (left == 1 && mid ==1 && right == 1)
            {
                return  binaryRule[0];
            }
            else if (left == 1 && mid == 1 && right == 0)
            {
                return  binaryRule[1];
            }
            else if (left == 1 && mid == 0 && right == 1)
            {
                return binaryRule[2];
            }
            else if (left == 1 &&  mid ==0  && right == 0)
            {
                return binaryRule[3];         
            }                       
            else if (left == 0  &&  mid == 1 && right == 1)
            {
                return binaryRule[4];         
            }                       
            else if (left == 0 &&  mid == 1 && right == 0)
            {
                return binaryRule[5];         
            }                       
            else if (left == 0 &&  mid == 0 && right == 1)
            {
                return binaryRule[6];
            }
            else if (left == 0 && mid == 0 && right == 0)
            {
                return binaryRule[7];
            }
            else
            {
                throw new Exception("Invalid cell state encountered.");
            }
        }

        private void buttontest_Click(object sender, EventArgs e)
        {
            currentValueRow = zeroRow;
            Clear();
            timer1.Stop();
            stop = false;
        }

        private void Clear()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dataGridView1[0, i].Value = "";
                }
            }
            currentIndexRow = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIndexRow == 23)
            {
                Clear();
            }
            if (currentIndexRow == 0)
            {
                currentValueRow = startRow;
                textBox2.Text = "gen first row";
            }
            else
            {
                textBox2.Text = "gen next row";
            }

            //Get Current Row          
            GenerateNextRow(currentValueRow);
                
        }
    }
}
   
        
