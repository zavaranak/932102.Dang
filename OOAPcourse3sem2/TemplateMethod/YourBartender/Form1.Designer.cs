namespace YourBartender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelController = new Panel();
            buttonOtherDrink = new Button();
            RumTemplateButton = new Button();
            GinTemplateButton = new Button();
            VodkaTemplateButton = new Button();
            panelDetails = new Panel();
            liqueurInfo = new Label();
            syrupInfo = new Label();
            fruitInfo = new Label();
            extraInfo = new Label();
            baseSpiritInfo = new Label();
            labelLiqueur = new Label();
            labelSyrup = new Label();
            labelOther = new Label();
            labelFruits = new Label();
            labelAlcohol = new Label();
            labelInfoBox = new Label();
            label2 = new Label();
            panel3 = new Panel();
            buttonClear = new Button();
            panelChoices = new Panel();
            panelBeer = new Panel();
            labelBeer = new Label();
            labelProcess = new Label();
            pictureBox1 = new PictureBox();
            panelController.SuspendLayout();
            panelDetails.SuspendLayout();
            panel3.SuspendLayout();
            panelBeer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelController
            // 
            panelController.BackgroundImageLayout = ImageLayout.None;
            panelController.Controls.Add(buttonOtherDrink);
            panelController.Controls.Add(RumTemplateButton);
            panelController.Controls.Add(GinTemplateButton);
            panelController.Controls.Add(VodkaTemplateButton);
            panelController.Location = new Point(22, 52);
            panelController.Name = "panelController";
            panelController.Size = new Size(777, 89);
            panelController.TabIndex = 2;
            // 
            // buttonOtherDrink
            // 
            buttonOtherDrink.BackgroundImageLayout = ImageLayout.None;
            buttonOtherDrink.Font = new Font("Algerian", 15F, FontStyle.Bold | FontStyle.Italic);
            buttonOtherDrink.ForeColor = Color.Tomato;
            buttonOtherDrink.ImageAlign = ContentAlignment.TopCenter;
            buttonOtherDrink.Location = new Point(586, 3);
            buttonOtherDrink.Name = "buttonOtherDrink";
            buttonOtherDrink.Size = new Size(170, 61);
            buttonOtherDrink.TabIndex = 15;
            buttonOtherDrink.Text = "Beer";
            buttonOtherDrink.UseVisualStyleBackColor = true;
            buttonOtherDrink.Click += buttonOtherDrink_Click;
            // 
            // RumTemplateButton
            // 
            RumTemplateButton.BackgroundImageLayout = ImageLayout.None;
            RumTemplateButton.Font = new Font("Algerian", 15F, FontStyle.Bold | FontStyle.Italic);
            RumTemplateButton.ForeColor = Color.LightCoral;
            RumTemplateButton.ImageAlign = ContentAlignment.TopCenter;
            RumTemplateButton.Location = new Point(398, 3);
            RumTemplateButton.Name = "RumTemplateButton";
            RumTemplateButton.Size = new Size(170, 61);
            RumTemplateButton.TabIndex = 13;
            RumTemplateButton.Text = "Rum";
            RumTemplateButton.UseVisualStyleBackColor = true;
            RumTemplateButton.Click += RumTemplateButton_Click;
            // 
            // GinTemplateButton
            // 
            GinTemplateButton.BackgroundImageLayout = ImageLayout.None;
            GinTemplateButton.Font = new Font("Algerian", 15F, FontStyle.Bold | FontStyle.Italic);
            GinTemplateButton.ForeColor = Color.Red;
            GinTemplateButton.ImageAlign = ContentAlignment.TopCenter;
            GinTemplateButton.Location = new Point(200, 3);
            GinTemplateButton.Name = "GinTemplateButton";
            GinTemplateButton.Size = new Size(176, 61);
            GinTemplateButton.TabIndex = 14;
            GinTemplateButton.Text = "Gin";
            GinTemplateButton.UseVisualStyleBackColor = true;
            GinTemplateButton.Click += GinTemplateButton_Click;
            // 
            // VodkaTemplateButton
            // 
            VodkaTemplateButton.BackgroundImageLayout = ImageLayout.None;
            VodkaTemplateButton.Font = new Font("Algerian", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            VodkaTemplateButton.ForeColor = Color.DarkRed;
            VodkaTemplateButton.ImageAlign = ContentAlignment.TopCenter;
            VodkaTemplateButton.Location = new Point(3, 3);
            VodkaTemplateButton.Name = "VodkaTemplateButton";
            VodkaTemplateButton.Size = new Size(179, 61);
            VodkaTemplateButton.TabIndex = 12;
            VodkaTemplateButton.Text = "Vodka";
            VodkaTemplateButton.UseVisualStyleBackColor = true;
            VodkaTemplateButton.Click += VodkaTemplateButton_Click;
            // 
            // panelDetails
            // 
            panelDetails.AutoSize = true;
            panelDetails.Controls.Add(liqueurInfo);
            panelDetails.Controls.Add(syrupInfo);
            panelDetails.Controls.Add(fruitInfo);
            panelDetails.Controls.Add(extraInfo);
            panelDetails.Controls.Add(baseSpiritInfo);
            panelDetails.Controls.Add(labelLiqueur);
            panelDetails.Controls.Add(labelSyrup);
            panelDetails.Controls.Add(labelOther);
            panelDetails.Controls.Add(labelFruits);
            panelDetails.Controls.Add(labelAlcohol);
            panelDetails.ForeColor = SystemColors.HotTrack;
            panelDetails.Location = new Point(22, 51);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(774, 96);
            panelDetails.TabIndex = 16;
            // 
            // liqueurInfo
            // 
            liqueurInfo.AutoSize = true;
            liqueurInfo.Font = new Font("Stencil", 11F);
            liqueurInfo.ForeColor = Color.Tomato;
            liqueurInfo.Location = new Point(658, 36);
            liqueurInfo.Name = "liqueurInfo";
            liqueurInfo.Size = new Size(23, 18);
            liqueurInfo.TabIndex = 23;
            liqueurInfo.Text = "...";
            // 
            // syrupInfo
            // 
            syrupInfo.AutoSize = true;
            syrupInfo.Font = new Font("Stencil", 11F);
            syrupInfo.ForeColor = Color.Tomato;
            syrupInfo.Location = new Point(505, 36);
            syrupInfo.Name = "syrupInfo";
            syrupInfo.Size = new Size(23, 18);
            syrupInfo.TabIndex = 22;
            syrupInfo.Text = "...";
            // 
            // fruitInfo
            // 
            fruitInfo.AutoSize = true;
            fruitInfo.Font = new Font("Stencil", 11F);
            fruitInfo.ForeColor = Color.Tomato;
            fruitInfo.Location = new Point(363, 36);
            fruitInfo.Name = "fruitInfo";
            fruitInfo.Size = new Size(23, 18);
            fruitInfo.TabIndex = 21;
            fruitInfo.Text = "...";
            // 
            // extraInfo
            // 
            extraInfo.AutoSize = true;
            extraInfo.Font = new Font("Stencil", 11F);
            extraInfo.ForeColor = Color.Tomato;
            extraInfo.Location = new Point(227, 36);
            extraInfo.Name = "extraInfo";
            extraInfo.Size = new Size(23, 18);
            extraInfo.TabIndex = 20;
            extraInfo.Text = "...";
            // 
            // baseSpiritInfo
            // 
            baseSpiritInfo.AutoSize = true;
            baseSpiritInfo.Font = new Font("Stencil", 11F);
            baseSpiritInfo.ForeColor = Color.Tomato;
            baseSpiritInfo.Location = new Point(66, 36);
            baseSpiritInfo.Name = "baseSpiritInfo";
            baseSpiritInfo.Size = new Size(23, 18);
            baseSpiritInfo.TabIndex = 19;
            baseSpiritInfo.Text = "...";
            // 
            // labelLiqueur
            // 
            labelLiqueur.AutoSize = true;
            labelLiqueur.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelLiqueur.Location = new Point(638, 11);
            labelLiqueur.Name = "labelLiqueur";
            labelLiqueur.Size = new Size(71, 22);
            labelLiqueur.TabIndex = 8;
            labelLiqueur.Text = "Liqueur";
            // 
            // labelSyrup
            // 
            labelSyrup.AutoSize = true;
            labelSyrup.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelSyrup.Location = new Point(491, 10);
            labelSyrup.Name = "labelSyrup";
            labelSyrup.Size = new Size(65, 22);
            labelSyrup.TabIndex = 6;
            labelSyrup.Text = "Syrups";
            // 
            // labelOther
            // 
            labelOther.AutoSize = true;
            labelOther.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelOther.Location = new Point(215, 10);
            labelOther.Name = "labelOther";
            labelOther.Size = new Size(51, 22);
            labelOther.TabIndex = 4;
            labelOther.Text = "Extra";
            // 
            // labelFruits
            // 
            labelFruits.AutoSize = true;
            labelFruits.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelFruits.Location = new Point(344, 11);
            labelFruits.Name = "labelFruits";
            labelFruits.Size = new Size(56, 22);
            labelFruits.TabIndex = 5;
            labelFruits.Text = "Fruits";
            // 
            // labelAlcohol
            // 
            labelAlcohol.AutoSize = true;
            labelAlcohol.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            labelAlcohol.Location = new Point(32, 10);
            labelAlcohol.Name = "labelAlcohol";
            labelAlcohol.Size = new Size(97, 22);
            labelAlcohol.TabIndex = 3;
            labelAlcohol.Text = "Base Spirit";
            // 
            // labelInfoBox
            // 
            labelInfoBox.AutoSize = true;
            labelInfoBox.BackColor = SystemColors.ButtonHighlight;
            labelInfoBox.BorderStyle = BorderStyle.Fixed3D;
            labelInfoBox.Font = new Font("Niagara Solid", 20F, FontStyle.Italic);
            labelInfoBox.ForeColor = SystemColors.HotTrack;
            labelInfoBox.Location = new Point(5, 9);
            labelInfoBox.Name = "labelInfoBox";
            labelInfoBox.Size = new Size(55, 31);
            labelInfoBox.TabIndex = 9;
            labelInfoBox.Text = "Ready";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Niagara Solid", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 3);
            label2.Name = "label2";
            label2.Size = new Size(109, 34);
            label2.TabIndex = 15;
            label2.Text = "Your choice!";
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonClear);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(labelInfoBox);
            panel3.Location = new Point(22, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 42);
            panel3.TabIndex = 17;
            // 
            // buttonClear
            // 
            buttonClear.BackgroundImageLayout = ImageLayout.None;
            buttonClear.Font = new Font("Niagara Solid", 15F);
            buttonClear.ForeColor = SystemColors.Highlight;
            buttonClear.ImageAlign = ContentAlignment.TopCenter;
            buttonClear.Location = new Point(627, 9);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(129, 27);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Back";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // panelChoices
            // 
            panelChoices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelChoices.AutoScroll = true;
            panelChoices.AutoSize = true;
            panelChoices.ForeColor = Color.Crimson;
            panelChoices.Location = new Point(22, 176);
            panelChoices.Name = "panelChoices";
            panelChoices.Size = new Size(386, 390);
            panelChoices.TabIndex = 18;
            // 
            // panelBeer
            // 
            panelBeer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBeer.AutoScroll = true;
            panelBeer.AutoSize = true;
            panelBeer.Controls.Add(labelBeer);
            panelBeer.Location = new Point(268, 159);
            panelBeer.Name = "panelBeer";
            panelBeer.Size = new Size(294, 338);
            panelBeer.TabIndex = 19;
            panelBeer.Visible = false;
            // 
            // labelBeer
            // 
            labelBeer.AutoSize = true;
            labelBeer.Font = new Font("Nirmala UI", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelBeer.ForeColor = Color.Crimson;
            labelBeer.Location = new Point(20, 15);
            labelBeer.Name = "labelBeer";
            labelBeer.Size = new Size(258, 45);
            labelBeer.TabIndex = 16;
            labelBeer.Text = "NO BEER, SORRY";
            // 
            // labelProcess
            // 
            labelProcess.AutoSize = true;
            labelProcess.Font = new Font("Niagara Solid", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProcess.Location = new Point(486, 205);
            labelProcess.Name = "labelProcess";
            labelProcess.Size = new Size(0, 34);
            labelProcess.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(772, 442);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(811, 607);
            Controls.Add(pictureBox1);
            Controls.Add(panelBeer);
            Controls.Add(panelDetails);
            Controls.Add(labelProcess);
            Controls.Add(panelChoices);
            Controls.Add(panel3);
            Controls.Add(panelController);
            ForeColor = SystemColors.HotTrack;
            Name = "Form1";
            Text = "Your Bartender";
            panelController.ResumeLayout(false);
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelBeer.ResumeLayout(false);
            panelBeer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelController;
        private Label labelAlcohol;
        private Label labelSyrup;
        private Label labelOther;
        private Label labelFruits;
        private Label labelLiqueur;
        private Label labelInfoBox;
        private Button VodkaTemplateButton;
        private Button RumTemplateButton;
        private Button GinTemplateButton;
        private Label label2;
        private Panel panelDetails;
        private Panel panel3;
        private Button buttonClear;
        private Panel panelChoices;
        private Label baseSpiritInfo;
        private Label syrupInfo;
        private Label fruitInfo;
        private Label extraInfo;
        private Label liqueurInfo;
        private Label labelProcess;
        private Button buttonOtherDrink;
        private Panel panelBeer;
        private Label labelBeer;
        private PictureBox pictureBox1;
    }
}
