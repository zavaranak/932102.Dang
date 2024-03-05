using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConwayGameOfLife
{

    public partial class Form1 : Form
    {
        private const int columnSize = 34;
        private const int rowSize = 25;
        Color highlightColor = Color.Green;
        int[][] gameBoard = new int[rowSize][];
        int[][] tempBoard = new int[rowSize][];

        bool gameDone = false;
        bool gameStarted = false;
        List<Point> listOfLivingCells = new List<Point>();
        List<Point> tempList = new List<Point>();
        List<Point> potentialPoints = new List<Point>();

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
            dataGridView1.ColumnCount = columnSize;
            dataGridView1.RowCount = rowSize;
            int cellSize = Math.Min(dataGridView1.Width / columnSize, dataGridView1.Height / rowSize);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            // Set column and row headers width/height to 0 to hide potential borders
            dataGridView1.RowHeadersWidth = 4;
            dataGridView1.ColumnHeadersHeight = 4;

            // Adjust cell size based on available space
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 20;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 20;
            }

            // Programmatically populate with empty values (optional)
            for (int i = 0; i < rowSize; i++)
            {
                gameBoard[i] = new int[columnSize];
                tempBoard[i] = new int[columnSize];

            };

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    dataGridView1[j, i].Value = "";
                    gameBoard[i][j] = 0;
                    tempBoard[i][j] = 0;

                }
            }
            dataGridView1.CellClick += dataGridView1_CellClick;


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check for valid cell click
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the clicked cell
                DataGridViewCell clickedCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                clickedCell.Selected = false;
                // Change the background color of the clicked cell
                clickedCell.Style.BackColor = highlightColor; // Change this to your desired 
                gameBoard[e.RowIndex][e.ColumnIndex] = 1;
                Point temp = new Point(e.RowIndex, e.ColumnIndex);
                listOfLivingCells.Add(temp);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            timer1.Stop();
            button2.BackColor = Color.White;
        }
        private void Clear()
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    gameBoard[i][j] = 0;
                    tempBoard[i][j] = 0;

                }
            }
            listOfLivingCells.Clear();
            gameDone = false;
        }

        private void getPotentialPoint(Point cell)
        {
            Point tempNeighbor;
            int cellRow = cell.X;
            int cellCol = cell.Y;
            // Check each neighbor position (including edges)
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    // Skip the cell itself
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }
                    // Calculate neighbor coordinates
                    int neighborRow = cellRow + i;
                    int neighborCol = cellCol + j;

                    // Check for edge cases and adjust if necessary
                    if (neighborRow < 0 || neighborRow >= rowSize || neighborCol < 0 || neighborCol >= columnSize)
                    {
                        continue; // Skip invalid neighbor positions
                    }
                    // Set Valid neighbor, check 
                    tempNeighbor = new Point(neighborRow, neighborCol);
                    ExistsInList(potentialPoints, tempNeighbor);
                }
            }
        }
        private void fillValueBoard(Point cell)
        {
            Point tempPoint;
            int cellRow = cell.X;
            int cellCol = cell.Y;
            int count = 0;
            // Check each neighbor position (including edges)
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    // Skip the cell itself
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }
                    // Calculate neighbor coordinates
                    int neighborRow = cellRow + i;
                    int neighborCol = cellCol + j;

                    // Check for edge cases and adjust if necessary
                    if (neighborRow < 0 || neighborRow >= rowSize || neighborCol < 0 || neighborCol >= columnSize)
                    {
                        continue; // Skip invalid neighbor positions
                    }
                    // Set Valid neighbor
                    // Check State of the Neighbor, if ">0" then increasing living count
                    if (gameBoard[neighborRow][neighborCol] > 0) count++;
                }

            }
            if (count == 3 && gameBoard[cellRow][cellCol] == 0)
            {
                tempBoard[cellRow][cellCol] = 1;
                dataGridView1[cellCol, cellRow].Style.BackColor = highlightColor;
                tempPoint = new Point(cellRow, cellCol);
                ExistsInList(listOfLivingCells, tempPoint);
            }
            else if (count == 2 && gameBoard[cellRow][cellCol] > 0)
            {
                tempBoard[cellRow][cellCol] = 1;
                dataGridView1[cellCol, cellRow].Style.BackColor = highlightColor;
                tempPoint = new Point(cellRow, cellCol);
                ExistsInList(listOfLivingCells, tempPoint);

            }
            else if ((count < 2 || count > 3) && gameBoard[cellRow][cellCol] > 0)
            {
                tempBoard[cellRow][cellCol] = 0;
                dataGridView1[cellCol, cellRow].Style.BackColor = Color.White;
            }

        }
        private void start()
        {
            
            //check neighbor of each living points => update state
            tempList.Clear();
            potentialPoints.Clear();
            //Initiate potential points with living points
            foreach (Point point in listOfLivingCells) potentialPoints.Add(point);
            //Find more potential points
            foreach (Point livingPoint in listOfLivingCells) getPotentialPoint(livingPoint);
            //Initate tempList
            foreach (Point potientialPonit in potentialPoints) tempList.Add(potientialPonit);
            //Start fill board. After this we have new listOfLivingCells
            listOfLivingCells.Clear();
            foreach (Point potientialPoint in tempList) fillValueBoard(potientialPoint);
            //Compare new list with last list
            for (int i = 0; i < rowSize; i++)
                for (int j = 0; j < columnSize; j++)
                    if (tempBoard[i][j] != gameBoard[i][j]) 
                    { gameDone = false;
                      deepCopyArray(gameBoard, tempBoard);
                    }
       

            if (gameDone)
            {
                button2.BackColor = highlightColor;
                timer1.Stop();
                for (int i = 0; i < rowSize; i++)
                {
                    for (int j = 0; j < columnSize; j++)
                    {
                        gameBoard[i][j] = 0;
                        tempBoard[i][j] = 0;

                    }
                }
                listOfLivingCells.Clear();
                gameDone = false;
            }
        }

        //Launch
        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameStarted) {timer1.Start(); gameStarted = true;}
            else
            {
                gameStarted = false;
                timer1.Stop();
            }
        }
        private void deepCopyArray(int[][] array1, int[][] array2)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++) array1[i][j] = array2[i][j];
            }
        }
        public bool ExistsInList(List<Point> list, Point newPoint)
        {
            foreach (Point point in list)
            {
                if (point.X == newPoint.X && point.Y == newPoint.Y)
                {
                    return true; // Point exists, don't add
                }
            }
            list.Add(newPoint); // Point doesn't exist, add it
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start();
        }
    }
}

