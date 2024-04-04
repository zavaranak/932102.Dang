using System.CodeDom.Compiler;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YourBartender
{
    public partial class Form1 : Form
    {
        private DrinkBuilder bartender;
        ComboBox myChoice = new ComboBox();
        private string selectedItem = "";
        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        List<List<string>> dataCocktail = new List<List<string>>();
        List<List<string>> dataShot = new List<List<string>>();
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

                    if (rowData[1] == "Vodka" || rowData[1] == "Gin" || rowData[1] == "Rum")
                        dataCocktail.Add(rowData);
                    if (rowData[1] == "Shot")
                        dataShot.Add(rowData);
                }
            }

            // Access data after reading
            foreach (var row in dataCocktail)
            {
                Console.WriteLine(string.Join(',', row)); // Print each row
            }
            foreach (var row in dataShot)
            {
                Console.WriteLine(string.Join(',', row)); // Print each row
            }
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            Launching();
        }
        public void Launching() ///Director
        {
            List<string> extras = new List<string>();
            List<string> fruits = new List<string>();
            List<string> syrups = new List<string>();
            List<string> liqueurs = new List<string>();
            labelInfo2.Text = "";
            List<List<string>> ingredients = new List<List<string>>();
            foreach (object item in checkedListExtra.CheckedItems)
            {
                extras.Add((string)item);
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

            string tempIMG = @"cocktailIMG/inProcessIMG.jpg";
            label3.Visible = true;
            labelInfoBox.Location = new Point(36, 167);
            labelInfoBox.BackColor = SystemColors.Window;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox2.Image = Image.FromFile(tempIMG);
            labelInfoBox.AutoSize = false;
            labelInfoBox.Width = 300;
            labelInfoBox.Height = 150;
            string baseSpirit = (string)comboBoxAlcohol.SelectedItem;
            if (baseSpirit == "Vodka shot" || baseSpirit == "Tequila shot" || baseSpirit == "Rum shot" || baseSpirit ==  "Whiskey shot" ||baseSpirit == "Gin shot")
            {
                bartender = new ShotBuilder();
                bartender.baseSpirit = baseSpirit;
                bartender.data = dataShot; 
                bartender.BuildDrink(null,null,null,null);
                labelInfoBox.Text = bartender.ShowProcess(null, null, null, null);
                label1.ForeColor = SystemColors.HotTrack;
                label1.Text = "Your order:";
                labelInfo2.Text = bartender.product[0];
                label3.Text = "Your drink is ready!";
                pictureBox2.Image = Image.FromFile(@"cocktailIMG/" + bartender.product[6]);


            }
            if (baseSpirit == "Vodka" || baseSpirit =="Gin" || baseSpirit == "Rum")
            {
                bartender = new CocktailBuilder();
                bartender.baseSpirit = baseSpirit;
                bartender.data = dataCocktail;
                labelInfoBox.Text = bartender.ShowProcess(fruits, extras, syrups, liqueurs);
                bartender.BuildDrink(fruits, extras, syrups, liqueurs);
                Console.WriteLine(baseSpirit);
                if (bartender.product != null) SetInterface(bartender.product[0], bartender.product[6]);           
                else if (bartender.product == null && bartender.tempProducts.Count > 0)
                {
                    KeepProcessOn();
                }
            }


        }
        public void MyChoice_SelectionChangeCommitted(object? sender, EventArgs e) //Select choice and delete comboBox
        {
            myChoice = (ComboBox)sender; // Cast sender to ComboBox
            selectedItem = (string)myChoice.SelectedItem; // Get the selected item
            label1.ForeColor = SystemColors.HotTrack;
            label1.Text = "Your order:";
            labelInfo2.Text = selectedItem;
            label3.Text = "Your drink is ready!";
            bartender.getRightProduct(selectedItem);
            pictureBox2.Image = Image.FromFile(@"cocktailIMG/" + bartender.product[6]);
            this.Controls.Remove(myChoice);
        } 

        public void KeepProcessOn() //AddComboBox
        {
            label1.ForeColor = Color.Red;
            label1.Text = "Please choose one\r\nfrom these options";
            myChoice = new ComboBox();

            if (bartender.tempProducts != null) foreach (var item in bartender.tempProducts)
                {
                    myChoice.Items.Add(item[0]);
                    labelInfo2.Text += item[0] + "\r\n";
                }
            myChoice.FormattingEnabled = true;
            myChoice.Location = new Point(36, 550);
            myChoice.Size = new Size(121, 23);
            myChoice.SelectionChangeCommitted += MyChoice_SelectionChangeCommitted;
            label3.Text = "Now in process...";
            this.Controls.Add(myChoice);
        }
        public void SetInterface(string drinkName, string drinkIMG)
        {
            label3.Text = "Your drink is ready!";
            label1.Text = "Your order:";
            labelInfo2.Text = drinkName;
            pictureBox2.Image = Image.FromFile(@"cocktailIMG/" + drinkIMG);
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
            label3.Text = "Now in process...";
            pictureBox2.Visible = false;
            bartender = null;
        }
    }


    class DrinkBuilder
    {
        public List<List<string>> data;
        public List<string> product { get; set; }
        public List<List<string>> tempProducts { get; set; }
        public string baseSpirit { get; set; }
        public virtual void BuildDrink(List<string> fruits, List<string> extras, List<string> syrups, List<string> liqueurs)
        {

        }
        public virtual void getRightProduct(string productName)
        {
        }
        public virtual string ShowProcess(List<string> fruits, List<string> extras, List<string> syrups, List<string> liqueurs)
        {
            return null;
        }
    }           /// <summary>
    /// Buider
    /// </summary>
    class CocktailBuilder : DrinkBuilder
    {
        public override void BuildDrink(List<string> fruits, List<string> extras, List<string> syrups, List<string> liqueurs)
        {
            int canMake = 0;
            List<string> tempProduct = new List<string>();
            tempProducts = new List<List<string>>();
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
                        foreach (string item in extras)
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
                        tempProduct = row;
                        canMake++;
                        tempProducts.Add(row);
                    }

                }
            }
            if (canMake == 1) this.product = tempProduct;
            else if (canMake > 1)
            {
                this.product = null;
            }

        }
        public override void getRightProduct(string productName)
        {
            foreach (var row in data)
            {
                if (row[0].Contains(productName))
                {
                    this.product = row;
                }
            }
        }
        public override string ShowProcess(List<string> fruits, List<string> extras, List<string> syrups, List<string> liqueurs)
        {

            string textForLabel;
            textForLabel = "Base spirit: " + this.baseSpirit;
            textForLabel += "\r\nExtra: ";
            foreach (string item in extras)
                textForLabel += item + ' ';
            textForLabel += "\r\nFruits: ";
            foreach (string item in fruits)
                textForLabel += item + ' ';
            textForLabel += "\r\nSyrups: ";
            foreach (string item in syrups)
                textForLabel += item + ' ';
            textForLabel += "\r\nLiqueurs: ";
            foreach (string item in liqueurs)
                textForLabel += item + ' ';
            Console.WriteLine(textForLabel);
            return textForLabel;
        }
    }/// <summary>
    /// Concret Builder for Cocktail products
    /// </summary>
    class ShotBuilder:DrinkBuilder  // Concret Builder for Shot glasses
    {
        public override void BuildDrink(List<string> fruits, List<string> extras, List<string> syrups, List<string> liqueurs)
        {
            this.product = data.Find(x => x[0] == this.baseSpirit);
        }
        public override string ShowProcess(List<string> fruits, List<string> extras, List<string> syrups, List<string> liqueurs)
        {

            string textForLabel;
            textForLabel = "Base spirit: " + this.baseSpirit
            +"\r\nWise choice, getting your order!";
           
            return textForLabel;
        }

    }     
    
}

