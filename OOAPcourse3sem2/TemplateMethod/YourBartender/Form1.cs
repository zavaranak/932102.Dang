using System.CodeDom.Compiler;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

/*using System.Reflection.Emit;*/
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YourBartender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadData();
            panelDetails.Visible = false;
        }
        int pictureBoxWidth = 170; // Adjust as needed
        int pictureBoxHeight = 170; // Adjust as needed
        int horizontalSpacing = 20; // Adjust as needed
        int leftPosition = 15; // Adjust as needed
        public List<List<string>> GinList = new List<List<string>>();
        public List<List<string>> VodkaList = new List<List<string>>();
        public List<List<string>> RumList = new List<List<string>>();
        public List<List<string>> BeerList = new List<List<string>>();
        public List<Label> LabelList = new List<Label>();
        CocktailMaker bartender;
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
                    if (rowData[1] == "Vodka") VodkaList.Add(rowData);
                    if (rowData[1] == "Rum") RumList.Add(rowData);
                    if (rowData[1] == "Gin") GinList.Add(rowData);

                }
            }
        }
        private void VodkaTemplateButton_Click(object sender, EventArgs e)
        {
            SetInterFace();
            bartender = new VodkaCocktailMaker(labelProcess);
            bartender.ShowChoices(VodkaList, panelChoices, pictureBoxWidth, pictureBoxHeight, leftPosition, horizontalSpacing, LabelList);
        }
        private void GinTemplateButton_Click(object sender, EventArgs e)
        {
            SetInterFace();
            bartender = new GinCocktailMaker(labelProcess);
            bartender.ShowChoices(GinList, panelChoices, pictureBoxWidth, pictureBoxHeight, leftPosition, horizontalSpacing, LabelList);

        }
        private void RumTemplateButton_Click(object sender, EventArgs e)
        {
            SetInterFace();
            bartender = new RumCocktailmaker(labelProcess);
            bartender.ShowChoices(RumList, panelChoices, pictureBoxWidth, pictureBoxHeight, leftPosition, horizontalSpacing, LabelList);
        }
        public void SetInterFace()
        {
            pictureBox1.Visible= false;
            labelInfoBox.Text = "Making you drink...";
            panelDetails.Visible = true;
            LabelList.Add(baseSpiritInfo);
            LabelList.Add(extraInfo);
            LabelList.Add(fruitInfo);
            LabelList.Add(syrupInfo);
            LabelList.Add(liqueurInfo);
            panelBeer.Visible = false;

        }
        class CocktailMaker()
        {
            protected Label process;
            protected List<Label> details = new List<Label>();
            protected string chosenDrink = "";
            protected List<List<string>> choices = new List<List<string>>();
            protected string baseSpirit = "";
            virtual public void ShowChoices(List<List<string>> data, Panel panelChoices, int pictureBoxWidth, int
            pictureBoxHeight, int leftPosition, int horizontalSpacing, List<Label> labelList)
            {
                this.choices = data;
                this.details = labelList;
                List<Image> imgs = new List<Image>();
                for (int i = 0; i < choices.Count; i++)
                {

                    imgs.Add(Image.FromFile(@"cocktailIMG/" + choices[i][6]));
                    PictureBox choiceImg = new PictureBox();
                    if (i == 4)
                    {
                        leftPosition = 15;
                        choiceImg.Top = pictureBoxHeight + 15;
                    }
                    if (i > 4) choiceImg.Top = pictureBoxHeight + 15;
                    choiceImg.Image = imgs[i];
                    choiceImg.Size = new Size(pictureBoxWidth, pictureBoxHeight); ;
                    choiceImg.Left = leftPosition; ;
                    leftPosition += pictureBoxWidth + horizontalSpacing;
                    choiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
                    choiceImg.Name = choices[i][0];
                    choiceImg.Click += (sender, e) =>
                    {
                        PictureBox x = (PictureBox)sender;
                        chosenDrink = x.Name;
                        Console.WriteLine(chosenDrink);

                        List<PictureBox> picturesToRemove = new List<PictureBox>();

                        foreach (Control control in panelChoices.Controls)
                        {
                            if (control is PictureBox pictureBox && pictureBox != x)
                            {
                                picturesToRemove.Add(pictureBox);
                            }
                        }

                        foreach (PictureBox pictureBox in picturesToRemove)
                        {
                            panelChoices.Controls.Remove(pictureBox);
                        }
                        x.Left = 15;
                        x.Top = 15;
                        x.Size = new Size(400, 400);
                        this.ShowFinalChoice();
                    };
                    panelChoices.Controls.Add(choiceImg);
                }
            }
            virtual public void ShowFinalChoice()
            {
                List<string> finalchoice = new List<string>();
                finalchoice = choices.Find(choice => choice[0] == chosenDrink);
                for (int i = 0; i < this.details.Count; i++)
                    if (finalchoice[i + 1] != "") this.details[i].Text = finalchoice[i + 1];
                this.PrepareBaseSpiritMain();
            }
            virtual public void PrepareBaseSpirit()
            {
            }
             public void PrepareBaseSpiritMain()
            {
                this.PrepareBaseSpirit();
                process.Text = "Prepared base spirit ";
                this.Preproccessing();
            }
            virtual public void Preproccessing() { }

        }
        class VodkaCocktailMaker : CocktailMaker
        {
            public VodkaCocktailMaker(Label process)
            {
                this.baseSpirit = "Vodka";
                this.process = (Label)process;
            }
            public override void PrepareBaseSpirit()
            {
                process.Text += this.baseSpirit + "\r\n" + this.chosenDrink + " is now ready" + "\r\nPlease take your drink!";
            }
            public override void Preproccessing() {
                Console.WriteLine("Preproccessing Vodka");
            }
        }
        class GinCocktailMaker : CocktailMaker      //from template CocktailMaker
        {
            public GinCocktailMaker(Label process)
            {
                this.baseSpirit = "Gin";
                this.process = (Label)process;
            }
            public override void PrepareBaseSpirit()
            {
                process.Text += this.baseSpirit + "\r\n" + this.chosenDrink + " is now ready" + "\r\nPlease take your drink!";
            }
            public override void Preproccessing()
            {
                Console.WriteLine("Preproccessing Gin");
            }
        }
        class RumCocktailmaker : CocktailMaker
        {
            public RumCocktailmaker(Label process)
            {
                this.baseSpirit = "Rum";
                this.process = (Label)process;
            }
            public override void PrepareBaseSpirit()
            {
                process.Text += this.baseSpirit + "\r\n" + this.chosenDrink + " is now ready" + "\r\nPlease take your drink!";
            }
            public override void Preproccessing() {
                Console.WriteLine("Preproccessing Rum");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            panelChoices.Controls.Clear();
            labelInfoBox.Text = "Ready";
            panelDetails.Visible = false;
            for (int i = 0; i < LabelList.Count; i++)
                LabelList[i].Text = "...";
            LabelList.Clear();
            labelProcess.Text = "";
            panelBeer.Visible = false;
            pictureBox1.Visible = true;

        }
        private void buttonOtherDrink_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            string choice ="";
            labelInfoBox.Text = "Making you drink...";
            if (BeerList.Count > 0) {
                ShowBeerList(BeerList,choice);
                PrepareBeer(choice);
            }
            else
                panelBeer.Visible = true; //No Beer Sorry
        }
        public void ShowBeerList(List<List<string>> BeerList,string choice) {
            List<Image> imgs = new List<Image>();
            for (int i = 0; i < BeerList.Count; i++)
            {

                imgs.Add(Image.FromFile(@"cocktailIMG/" + BeerList[i][6]));
                PictureBox choiceImg = new PictureBox();
                if (i == 4)
                {
                    leftPosition = 15;
                    choiceImg.Top = pictureBoxHeight + 15;
                }
                if (i > 4) choiceImg.Top = pictureBoxHeight + 15;
                choiceImg.Image = imgs[i];
                choiceImg.Size = new Size(pictureBoxWidth, pictureBoxHeight); ;
                choiceImg.Left = leftPosition; ;
                leftPosition += pictureBoxWidth + horizontalSpacing;
                choiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
                choiceImg.Name = BeerList[i][0];
                choiceImg.Click += (sender, e) =>
                {                    
                    PictureBox x = (PictureBox)sender;
                    choice = x.Name;
                    List<PictureBox> picturesToRemove = new List<PictureBox>();
                    foreach (Control control in panelChoices.Controls)
                    {
                        if (control is PictureBox pictureBox && pictureBox != x)
                        {
                            picturesToRemove.Add(pictureBox);
                        }
                    }
                    foreach (PictureBox pictureBox in picturesToRemove)
                    {
                        panelChoices.Controls.Remove(pictureBox);
                    }
                    x.Left = 15;
                    x.Top = 15;
                    x.Size = new Size(400, 400);
                };
                panelChoices.Controls.Add(choiceImg);
            }
        }
        public void PrepareBeer(string beerName) { }
    }
}

