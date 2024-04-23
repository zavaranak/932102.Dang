
using static System.Runtime.InteropServices.JavaScript.JSType;
using WinFormsLabel = System.Windows.Forms.Label;

namespace YourBartender
{
    public partial class Form1 : Form
    {
        //private DrinkBuilder bartender;
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
            var filePath = "Cocktail.csv"; // Replace with your file path
            using (var reader = new StreamReader(filePath))
            {
                // Skip the header row
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split each line into a list of strings (cells)
                    var rowData = line.Split(',').ToList();

                    if (rowData[1] == "Vodka" || rowData[1] == "Gin" || rowData[1] == "Rum")
                        dataCocktail.Add(rowData);
                    if (rowData[1] == "Shot")
                        dataShot.Add(rowData);
                }
            }
            // Access data after reading
            foreach (var row in dataCocktail) Console.WriteLine(string.Join(',', row)); // Print each row

            foreach (var row in dataShot) Console.WriteLine(string.Join(',', row)); // Print each row
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            myChoice.FormattingEnabled = true;
            myChoice.Location = new Point(36, 550);
            myChoice.Size = new Size(121, 23);
            myChoice.Visible = false;
            this.Controls.Add(myChoice);
            //Launching();
            LauchingWithoutPattern();
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

            ingredients.Add(fruits);
            ingredients.Add(syrups);
            ingredients.Add(extras);
            ingredients.Add(liqueurs);
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

            Bundler clientChoices = new Bundler();
            ParamForStrategy param = new ParamForStrategy();
            param.labels = new List<WinFormsLabel> { label1, label3, labelInfo2, labelInfoBox };
            param.pictureBoxs = new List<PictureBox> { pictureBox2 };
            param.comboBox = myChoice;
            param.comboBox.SelectionChangeCommitted += ((sender, args) =>
            {
                this.Controls.Remove(myChoice);
            });
            switch (baseSpirit)
            {
                case "Vodka shot":
                case "Tequila shot":
                case "Rum shot":
                case "Whiskey shot":
                case "Gin shot":
                    clientChoices.setBartender(new ShotMaker());
                    clientChoices.FillIngredients(dataShot, baseSpirit, ingredients);
                    clientChoices.BrinkToClient(param);
                    break;
                case "Vodka":
                case "Gin":
                case "Rum":
                    this.Controls.Add(myChoice);
                    clientChoices.setBartender(new CocktailMaker());
                    clientChoices.FillIngredients(dataCocktail, baseSpirit, ingredients);
                    clientChoices.BrinkToClient(param);
                    break;
                case "Beer":
                    clientChoices.FillIngredients(dataCocktail, baseSpirit, ingredients);
                    clientChoices.setBartender(new BeerMaker());
                    clientChoices.BrinkToClient(param);
                    break;
            }

            Console.WriteLine(clientChoices.baseSpirit);

            /*if (baseSpirit == "Vodka shot" || baseSpirit == "Tequila shot" || baseSpirit == "Rum shot" || baseSpirit == "Whiskey shot" || baseSpirit == "Gin shot")
            {
                bartender = new ShotBuilder();
                bartender.baseSpirit = baseSpirit;
                bartender.data = dataShot;
                bartender.BuildDrink(null, null, null, null);
                labelInfo2.Text = bartender.product[0];
                labelInfoBox.Text = bartender.ShowProcess(null, null, null, null);
                pictureBox2.Image = Image.FromFile(@"cocktailIMG/" + bartender.product[6]);
                label1.ForeColor = SystemColors.HotTrack;
                label1.Text = "Your order:";
                label3.Text = "Your drink is ready!";
            }
            if (baseSpirit == "Vodka" || baseSpirit == "Gin" || baseSpirit == "Rum")
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
            }*/
        }

        public void LauchingWithoutPattern()
        {
            List<string> product = new List<string>();
            List<List<string>> tempProducts = new List<List<string>>();
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

            ingredients.Add(fruits);
            ingredients.Add(syrups);
            ingredients.Add(extras);
            ingredients.Add(liqueurs);
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
            ParamForStrategy param = new ParamForStrategy();
            param.labels = new List<WinFormsLabel> { label1, label3, labelInfo2, labelInfoBox };
            param.pictureBoxs = new List<PictureBox> { pictureBox2 };
            param.comboBox = myChoice;
            param.comboBox.SelectionChangeCommitted += ((sender, args) =>
            {
                this.Controls.Remove(myChoice);
            });
            switch (baseSpirit)
            {
                case "Vodka shot":
                case "Tequila shot":
                case "Rum shot":
                case "Whiskey shot":
                case "Gin shot":
                    product = dataShot.Find(x => x[0] == baseSpirit);
                    param.labels[0].ForeColor = SystemColors.HotTrack;
                    param.labels[0].Text = "Your order:";
                    param.labels[1].Text = "Your drink is ready!";
                    param.labels[2].Text = product[0];
                    param.labels[3].Text = "Base spirit: " + baseSpirit + "\r\nWise choice, getting your order!";
                    param.pictureBoxs[0].Image = Image.FromFile(@"cocktailIMG/" + product[6]);
                    break;
                case "Vodka":
                case "Gin":
                case "Rum":
                    var canMake = 0;
                    var tempProduct = new List<string>();
                    tempProducts.Clear();
                    foreach (var row in dataCocktail)
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

                    if (canMake == 1) product = tempProduct;
                    else if (canMake > 1) product = null;
                    if (tempProducts.Any())
                    {
                        if (tempProducts.Count == 1)
                        {
                            Console.WriteLine(product[0] + "options2");
                            param.labels[0].ForeColor = SystemColors.HotTrack;
                            param.labels[0].Text = "Your order:";
                            param.labels[1].Text = "Your drink is ready!";
                            param.labels[2].Text = product[0];
                            param.labels[3].Text = "Base spirit: " + baseSpirit
                                                                   + "\r\nWise choice, getting your order!";
                            param.pictureBoxs[0].Image = Image.FromFile(@"cocktailIMG/" + product[6]);
                        }

                        if (tempProducts.Count > 1)
                        {
                            this.Controls.Add(myChoice);
                            param.labels[0].ForeColor = Color.Red;
                            param.labels[0].Text = "Please choose one\r\nfrom these options";
                            param.comboBox.Visible = true;

                            if (tempProducts != null)
                                foreach (var item in tempProducts)
                                {
                                    param.comboBox.Items.Add(item[0]);
                                    param.labels[2].Text += item[0] + "\r\n";
                                }

                            param.comboBox.SelectionChangeCommitted += (sender, args) =>
                                {
                                    string selectedItem;
                                    param.comboBox = (ComboBox)sender; // Cast sender to ComboBox
                                    selectedItem = (string)param.comboBox.SelectedItem; // Get the selected item
                                    param.labels[0].ForeColor = SystemColors.HotTrack;
                                    param.labels[0].Text = "Your order:";
                                    param.labels[2].Text = selectedItem;
                                    param.labels[1].Text = "Your drink is ready!";
                                    var final = tempProducts.Find(x => x[0] == selectedItem);
                                    param.pictureBoxs[0].Image = Image.FromFile(@"cocktailIMG/" + final[6]);
                                }
                                ;
                            param.labels[1].Text = "Now in process...";
                        }
                    }
                    break;
                case "Beer":
                    param.labels[0].ForeColor = SystemColors.HotTrack;
                    param.labels[0].Text = "Your order:";
                    param.labels[1].Text = "Your drink is ready!";
                    param.labels[2].Text = "Beer for the mood";
                    param.labels[3].Text = "BEER" + "\r\nWise choice, getting your order!";
                    param.pictureBoxs[0].Image = Image.FromFile(@"cocktailIMG/beer.jpeg");
                    break;
            }

        }

        /*public void MyChoice_SelectionChangeCommitted(object? sender, EventArgs e) //Select choice and delete comboBox
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

            if (bartender.tempProducts != null)
                foreach (var item in bartender.tempProducts)
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
        }*/

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
            //bartender = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }

    internal class ParamForStrategy
    {
        public List<WinFormsLabel> labels;
        public List<PictureBox> pictureBoxs;
        public ComboBox comboBox;
    }

    internal class Bundler
    {
        public List<List<string>> data;
        public List<List<string>> ingredients;
        public List<string> product = new();
        public List<List<string>> tempProducts = new();
        public DrinkMaker bartenderStrategy;
        public string baseSpirit { get; set; }

        public void FillIngredients(List<List<string>> db, string bS, List<List<string>> ingredients)
        {
            data = db;
            baseSpirit = bS;
            this.ingredients = ingredients;
            tempProducts.Clear();
        }

        public void setBartender(DrinkMaker newBartender)
        {
            bartenderStrategy = newBartender;
        }

        public void BrinkToClient(ParamForStrategy param)
        {
            bartenderStrategy.DecideProduct(data, ingredients, baseSpirit, ref tempProducts,
                ref product);
            bartenderStrategy.MakeDrink(param, baseSpirit, product, tempProducts);
        }
    }

    internal class DrinkMaker
    {
        public virtual void DecideProduct(List<List<string>> data, List<List<string>> ingredients,
            string baseSpirit, ref List<List<string>> tempProducts, ref List<string> product)
        {
        }

        public virtual void MakeDrink(ParamForStrategy param, string baseSpirit, List<string> product,
            List<List<string>> tempProducts)
        {
        }
    }

    internal class CocktailMaker : DrinkMaker
    {
        public override void DecideProduct(List<List<string>> data, List<List<string>> ingredients,
            string baseSpirit, ref List<List<string>> tempProducts, ref List<string> product)
        {
            var canMake = 0;
            tempProducts.Clear();
            var tempProduct = new List<string>();
            tempProducts = new List<List<string>>();
            foreach (var row in data)
                if (row.Contains(baseSpirit))
                {
                    var checkextra = false;
                    var checksyrups = false;
                    var checkfruits = false;
                    var checkliqueurs = false;
                    if (row[4] == "")
                        checkextra = true;
                    else
                        foreach (var item in ingredients[2])
                            if (row[4].Contains(item))
                                checkextra = true;
                    if (row[2] == "")
                        checkfruits = true;
                    else
                        foreach (var item in ingredients[0])
                            if (row[2].Contains(item))
                                checkfruits = true;
                    if (row[3] == "")
                        checksyrups = true;
                    else
                        foreach (var item in ingredients[1])
                            if (row[3].Contains(item))
                                checksyrups = true;
                    if (row[5] == "")
                        checkliqueurs = true;
                    else
                        foreach (var item in ingredients[3])
                            if (row[5].Contains(item))
                                checkliqueurs = true;
                    if (checkextra && checkfruits && checksyrups && checkliqueurs)
                    {
                        tempProduct = row;
                        canMake++;
                        tempProducts.Add(row);
                    }
                }

            foreach (var prd in tempProducts) Console.WriteLine(prd[0]);

            Console.WriteLine(tempProducts.Count + "options1");
            if (canMake == 1) product = tempProduct;
            else if (canMake > 1) product = null;
        }

        public override void MakeDrink(ParamForStrategy param, string baseSpirit, List<string> product,
            List<List<string>> tempProducts)
        {
            if (tempProducts.Any())
            {
                if (tempProducts.Count == 1)
                {
                    Console.WriteLine(product[0] + "options2");
                    param.labels[0].ForeColor = SystemColors.HotTrack;
                    param.labels[0].Text = "Your order:";
                    param.labels[1].Text = "Your drink is ready!";
                    param.labels[2].Text = product[0];
                    param.labels[3].Text = "Base spirit: " + baseSpirit
                                                           + "\r\nWise choice, getting your order!";
                    param.pictureBoxs[0].Image = Image.FromFile(@"cocktailIMG/" + product[6]);
                }

                if (tempProducts.Count > 1)
                {
                    param.labels[0].ForeColor = Color.Red;
                    param.labels[0].Text = "Please choose one\r\nfrom these options";
                    param.comboBox.Visible = true;

                    if (tempProducts != null)
                        foreach (var item in tempProducts)
                        {
                            param.comboBox.Items.Add(item[0]);
                            param.labels[2].Text += item[0] + "\r\n";
                        }

                    param.comboBox.SelectionChangeCommitted += (sender, args) =>
                        {
                            string selectedItem;
                            param.comboBox = (ComboBox)sender; // Cast sender to ComboBox
                            selectedItem = (string)param.comboBox.SelectedItem; // Get the selected item
                            param.labels[0].ForeColor = SystemColors.HotTrack;
                            param.labels[0].Text = "Your order:";
                            param.labels[2].Text = selectedItem;
                            param.labels[1].Text = "Your drink is ready!";
                            var final = tempProducts.Find(x => x[0] == selectedItem);
                            param.pictureBoxs[0].Image = Image.FromFile(@"cocktailIMG/" + final[6]);
                        }
                        ;
                    param.labels[1].Text = "Now in process...";
                }
            }
        }
    }

    internal class ShotMaker : DrinkMaker
    {
        public override void DecideProduct(List<List<string>> data, List<List<string>> ingredients,
            string baseSpirit,
            ref List<List<string>> tempProducts, ref List<string> product)
        {
            product = data.Find(x => x[0] == baseSpirit);
        }

        public override void MakeDrink(ParamForStrategy param, string baseSpirit, List<string> product,
            List<List<string>> tempProducts)
        {
            param.labels[0].ForeColor = SystemColors.HotTrack;
            param.labels[0].Text = "Your order:";
            param.labels[1].Text = "Your drink is ready!";
            param.labels[2].Text = product[0];
            param.labels[3].Text = "Base spirit: " + baseSpirit
                                                   + "\r\nWise choice, getting your order!";
            param.pictureBoxs[0].Image = Image.FromFile(@"cocktailIMG/" + product[6]);
        }
    }

    internal class BeerMaker : DrinkMaker
    {
        public override void MakeDrink(ParamForStrategy param, string baseSpirit, List<string> product,
            List<List<string>> tempProducts)
        {
            param.labels[0].ForeColor = SystemColors.HotTrack;
            param.labels[0].Text = "Your order:";
            param.labels[1].Text = "Your drink is ready!";
            param.labels[2].Text = "Beer for the mood";
            param.labels[3].Text = "BEER"
                                   + "\r\nWise choice, getting your order!";
            param.pictureBoxs[0].Image = Image.FromFile(@"cocktailIMG/beer.jpeg");
        }
    }


    /*class DrinkBuilder
    {
        public List<List<string>> data;
        public List<string> product { get; set; }
        public List<List<string>> tempProducts { get; set; }
        public string baseSpirit { get; set; }

        public virtual void BuildDrink(List<string> fruits, List<string> extras, List<string> syrups,
            List<string> liqueurs)
        {

        }

        public virtual void getRightProduct(string productName)
        {
        }

        public virtual string ShowProcess(List<string> fruits, List<string> extras, List<string> syrups,
            List<string> liqueurs)
        {
            return null;
        }
    }

    /// <summary>
    /// Buider
    /// </summary>
    class CocktailBuilder : DrinkBuilder
    {
        public override void BuildDrink(List<string> fruits, List<string> extras, List<string> syrups,
            List<string> liqueurs)
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

        public override string ShowProcess(List<string> fruits, List<string> extras, List<string> syrups,
            List<string> liqueurs)
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
            return textForLabel;
        }
    }

    /// <summary>
    /// Concret Builder for Cocktail products
    /// </summary>
    class ShotBuilder : DrinkBuilder // Concret Builder for Shot glasses
    {
        public override void BuildDrink(List<string> fruits, List<string> extras, List<string> syrups,
            List<string> liqueurs)
        {
            this.product = data.Find(x => x[0] == this.baseSpirit);
        }

        public override string ShowProcess(List<string> fruits, List<string> extras, List<string> syrups,
            List<string> liqueurs)
        {

            string textForLabel;
            textForLabel = "Base spirit: " + this.baseSpirit
                                           + "\r\nWise choice, getting your order!";

            return textForLabel;
        }

    }*/

}
