using System.CodeDom.Compiler;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace YourBartender
{
    public partial class Form1 : Form
    {
        ComboBox myChoice = new ComboBox();

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        List<List<string>> data = new List<List<string>>();
        List<string> extra = new List<string>();
        List<string> fruits = new List<string>();
        List<string> syrups = new List<string>();
        List<string> liqueurs = new List<string>();
        List<string> saveCanMake = new List<string>();

        private void BuildDrinkWithBaseSpirit(object baseSpirit)
        {
            string tempIMG = @"cocktailIMG/inProcessIMG.jpg";

            if (baseSpirit == null)
                return;
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label3.Visible = true;
                pictureBox2.Image = Image.FromFile(tempIMG);
                
                labelInfoBox.Location = new Point(36, 167);
                labelInfoBox.BackColor = SystemColors.Window;
                labelInfoBox.Text = "Base spirit: " + baseSpirit;
                labelInfoBox.Text += "\r\nExtra: ";
                foreach (string item in extra)
                    labelInfoBox.Text += item + ' ';
                labelInfoBox.Text += "\r\nFruits: ";
                foreach (string item in fruits)
                    labelInfoBox.Text += item + ' ';
                labelInfoBox.Text += "\r\nSyrups: ";
                foreach (string item in syrups)
                    labelInfoBox.Text += item + ' ';
                labelInfoBox.Text += "\r\nLiqueurs: ";
                foreach (string item in liqueurs)
                    labelInfoBox.Text += item + ' ';
                labelInfoBox.AutoSize = false;
                labelInfoBox.Width = 300;
                labelInfoBox.Height = 150;
            }

            int canMake = 0;
            List<String> canMakeList = new List<String>();
            foreach (var row in data)
            {
                if (row.Contains(baseSpirit))
                {
                    bool checkextra = false;
                    bool checksyrups = false;
                    bool checkfruits = false;
                    bool checkliqueurs = false;
                    if (row[4] == "")
                        checkextra = true;
                    else
                        foreach (string item in extra)
                            if (row[4].Contains(item))
                                checkextra = true;
                    if (row[2] == "")
                        checkfruits = true;
                    else
                        foreach (string item in fruits)
                            if (row[2].Contains(item))
                                checkfruits = true;
                    if (row[3] == "")
                        checksyrups = true;
                    else
                        foreach (string item in syrups)
                            if (row[3].Contains(item))
                                checksyrups = true;
                    if (row[5] == "")
                        checkliqueurs = true;
                    else
                        foreach (string item in liqueurs)
                            if (row[5].Contains(item))
                                checkliqueurs = true;
                    if (checkextra && checkfruits && checksyrups && checkliqueurs)
                    {
                        label1.ForeColor = SystemColors.HotTrack;
                        label1.Text = "Making now";
                        labelInfo2.Text += row[0] + "\r\t";
                        tempIMG = @"cocktailIMG/" + row[6];
                        canMake++;
                        canMakeList.Add(row[0]);
                    }
                }
            }
            myChoice.Items.Clear();
            this.Controls.Remove(myChoice);
            if (canMake == 1 )
            {
                label3.Text = "Your drink is ready!";
                pictureBox2.Image = Image.FromFile(tempIMG);
            }
            if (canMake > 1)
            {
                label1.ForeColor = Color.Red;   
                label1.Text = "Please choose one\r\nfrom these options";
                myChoice = new ComboBox();
                foreach (string item in canMakeList)
                    myChoice.Items.Add(item);
                myChoice.FormattingEnabled = true;
                myChoice.Location = new Point(36, 550);
                myChoice.Size = new Size(121, 23);
                myChoice.SelectionChangeCommitted += MyChoice_SelectionChangeCommitted;
                this.Controls.Add(myChoice);
            }
        }

        private void StartMakingCocktail(string cocktail) { }

        public void ReadData() //from csv file
        {
            string filePath = "Cocktail.csv"; // Replace with your file path
            using (var reader = new StreamReader(filePath))
            {
                // Skip the header row
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split each line into a list of strings (cells)
                    List<string> rowData = line.Split(',').ToList();
                    data.Add(rowData);
                }
            }

            // Access data after reading
            foreach (var row in data)
            {
                Console.WriteLine(string.Join(',', row)); // Print each row
            }
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            extra.Clear();
            fruits.Clear();
            syrups.Clear();
            liqueurs.Clear();
            labelInfo2.Text = "";
            foreach (object item in checkedListExtra.CheckedItems)
            {
                extra.Add((string)item);
            }
            foreach (object item in checkedListFruits.CheckedItems)
            {
                fruits.Add((string)item);
            }
            foreach (object item in checkedListSyrup.CheckedItems)
            {
                syrups.Add((string)item);
            }
            foreach (object item in checkedListLiqueur.CheckedItems)
            {
                liqueurs.Add((string)item);
            }
    
            BuildDrinkWithBaseSpirit((string)comboBoxAlcohol.SelectedItem);
        }

        private void MyChoice_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            myChoice = (ComboBox)sender; // Cast sender to ComboBox
            int selectedIndex = myChoice.SelectedIndex; // Get the selected index
            string selectedItem = (string)myChoice.SelectedItem; // Get the selected item

            // Perform actions based on the selected index or item here
            label1.ForeColor = SystemColors.HotTrack;
            label1.Text = "Making now";
            labelInfo2.Text = selectedItem;
            var tempIMG = data.Find(x => x[0] ==  selectedItem);
            label3.Text = "Your drink is ready!";
            pictureBox2.Image = Image.FromFile(@"cocktailIMG/"+ tempIMG[6]);
            this.Controls.Remove(myChoice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListExtra.Items.Count; i++)
            {
                checkedListExtra.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedListFruits.Items.Count; i++)
            {
                checkedListFruits.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedListLiqueur.Items.Count; i++)
            {
                checkedListLiqueur.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedListSyrup.Items.Count; i++)
            {
                checkedListSyrup.SetItemChecked(i, false);
            }
            labelInfo2.Text = "";
            labelInfoBox.AutoSize = true;
            labelInfoBox.Text = "Ready";
            labelInfoBox.BackColor = SystemColors.ButtonHighlight;
            labelInfoBox.Location = new Point(369, 167);
            label1.Text = "";
            myChoice.Items.Clear();
            this.Controls.Remove(myChoice);
            pictureBox1.Visible = true;
            label3.Visible = false;
            pictureBox2.Visible = false;
        }
    }
}
