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
            checkedListFruits = new CheckedListBox();
            checkedListSyrup = new CheckedListBox();
            panel1 = new Panel();
            button1 = new Button();
            comboBoxAlcohol = new ComboBox();
            buttonLaunch = new Button();
            labelLiqueur = new Label();
            checkedListLiqueur = new CheckedListBox();
            labelSyrup = new Label();
            labelOther = new Label();
            labelAlcohol = new Label();
            labelFruits = new Label();
            checkedListExtra = new CheckedListBox();
            labelInfoBox = new Label();
            labelInfo2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // checkedListFruits
            // 
            checkedListFruits.ForeColor = SystemColors.MenuHighlight;
            checkedListFruits.FormattingEnabled = true;
            checkedListFruits.Items.AddRange(new object[] { "Pineapple", "Lime ", "Orange", "Lemon", "Berry" });
            checkedListFruits.Location = new Point(320, 39);
            checkedListFruits.Name = "checkedListFruits";
            checkedListFruits.Size = new Size(120, 94);
            checkedListFruits.TabIndex = 0;
            // 
            // checkedListSyrup
            // 
            checkedListSyrup.ForeColor = SystemColors.MenuHighlight;
            checkedListSyrup.FormattingEnabled = true;
            checkedListSyrup.Items.AddRange(new object[] { "SimpleSyrup", "Orgeat", "Coconut", "Grenadine", "Mint", "Lime" });
            checkedListSyrup.Location = new Point(468, 38);
            checkedListSyrup.Name = "checkedListSyrup";
            checkedListSyrup.Size = new Size(120, 94);
            checkedListSyrup.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBoxAlcohol);
            panel1.Controls.Add(buttonLaunch);
            panel1.Controls.Add(labelLiqueur);
            panel1.Controls.Add(checkedListLiqueur);
            panel1.Controls.Add(labelSyrup);
            panel1.Controls.Add(labelOther);
            panel1.Controls.Add(labelAlcohol);
            panel1.Controls.Add(labelFruits);
            panel1.Controls.Add(checkedListExtra);
            panel1.Controls.Add(checkedListSyrup);
            panel1.Controls.Add(checkedListFruits);
            panel1.Location = new Point(36, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 149);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Highlight;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(13, 106);
            button1.Name = "button1";
            button1.Size = new Size(124, 33);
            button1.TabIndex = 11;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxAlcohol
            // 
            comboBoxAlcohol.FormattingEnabled = true;
            comboBoxAlcohol.Items.AddRange(new object[] { "Vodka", "Gin", "Rum", "Vodka ", "Vodka shot", "Tequila shot", "Rum shot", "Whiskey shot", "Gin shot" });
            comboBoxAlcohol.Location = new Point(13, 38);
            comboBoxAlcohol.Name = "comboBoxAlcohol";
            comboBoxAlcohol.Size = new Size(121, 23);
            comboBoxAlcohol.TabIndex = 10;
            // 
            // buttonLaunch
            // 
            buttonLaunch.BackgroundImageLayout = ImageLayout.None;
            buttonLaunch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonLaunch.ForeColor = SystemColors.Highlight;
            buttonLaunch.ImageAlign = ContentAlignment.TopCenter;
            buttonLaunch.Location = new Point(13, 67);
            buttonLaunch.Name = "buttonLaunch";
            buttonLaunch.Size = new Size(124, 33);
            buttonLaunch.TabIndex = 7;
            buttonLaunch.Text = "Make the drink";
            buttonLaunch.UseVisualStyleBackColor = true;
            buttonLaunch.Click += buttonLaunch_Click;
            // 
            // labelLiqueur
            // 
            labelLiqueur.AutoSize = true;
            labelLiqueur.Font = new Font("Mistral", 15.75F);
            labelLiqueur.Location = new Point(648, 10);
            labelLiqueur.Name = "labelLiqueur";
            labelLiqueur.Size = new Size(62, 26);
            labelLiqueur.TabIndex = 8;
            labelLiqueur.Text = "Liqueur";
            // 
            // checkedListLiqueur
            // 
            checkedListLiqueur.ForeColor = SystemColors.MenuHighlight;
            checkedListLiqueur.FormattingEnabled = true;
            checkedListLiqueur.Items.AddRange(new object[] { "Chartreuse", "Campari", "Orange", "Coffee" });
            checkedListLiqueur.Location = new Point(618, 39);
            checkedListLiqueur.Name = "checkedListLiqueur";
            checkedListLiqueur.Size = new Size(120, 94);
            checkedListLiqueur.TabIndex = 7;
            // 
            // labelSyrup
            // 
            labelSyrup.AutoSize = true;
            labelSyrup.Font = new Font("Mistral", 15.75F);
            labelSyrup.Location = new Point(490, 10);
            labelSyrup.Name = "labelSyrup";
            labelSyrup.Size = new Size(57, 26);
            labelSyrup.TabIndex = 6;
            labelSyrup.Text = "Syrups";
            // 
            // labelOther
            // 
            labelOther.AutoSize = true;
            labelOther.Font = new Font("Mistral", 15.75F);
            labelOther.Location = new Point(199, 10);
            labelOther.Name = "labelOther";
            labelOther.Size = new Size(50, 26);
            labelOther.TabIndex = 4;
            labelOther.Text = "Extra";
            // 
            // labelAlcohol
            // 
            labelAlcohol.AutoSize = true;
            labelAlcohol.Font = new Font("Mistral", 15.75F);
            labelAlcohol.Location = new Point(28, 9);
            labelAlcohol.Name = "labelAlcohol";
            labelAlcohol.Size = new Size(85, 26);
            labelAlcohol.TabIndex = 3;
            labelAlcohol.Text = "Base Spirit";
            // 
            // labelFruits
            // 
            labelFruits.AutoSize = true;
            labelFruits.Font = new Font("Mistral", 15.75F);
            labelFruits.Location = new Point(346, 10);
            labelFruits.Name = "labelFruits";
            labelFruits.Size = new Size(55, 26);
            labelFruits.TabIndex = 5;
            labelFruits.Text = "Fruits";
            // 
            // checkedListExtra
            // 
            checkedListExtra.ForeColor = SystemColors.MenuHighlight;
            checkedListExtra.FormattingEnabled = true;
            checkedListExtra.Items.AddRange(new object[] { "White cream", "Cream", "Beer", "Soda", "Cola" });
            checkedListExtra.Location = new Point(169, 39);
            checkedListExtra.Name = "checkedListExtra";
            checkedListExtra.Size = new Size(120, 94);
            checkedListExtra.TabIndex = 3;
            // 
            // labelInfoBox
            // 
            labelInfoBox.AutoSize = true;
            labelInfoBox.BackColor = SystemColors.ButtonHighlight;
            labelInfoBox.BorderStyle = BorderStyle.Fixed3D;
            labelInfoBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelInfoBox.ForeColor = SystemColors.HotTrack;
            labelInfoBox.Location = new Point(384, 164);
            labelInfoBox.Name = "labelInfoBox";
            labelInfoBox.Size = new Size(50, 22);
            labelInfoBox.TabIndex = 9;
            labelInfoBox.Text = "Ready";
            // 
            // labelInfo2
            // 
            labelInfo2.AutoSize = true;
            labelInfo2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInfo2.Location = new Point(36, 325);
            labelInfo2.Name = "labelInfo2";
            labelInfo2.Size = new Size(0, 20);
            labelInfo2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(36, 290);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(90, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(634, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(358, 206);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(423, 374);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(480, 175);
            label3.Name = "label3";
            label3.Size = new Size(164, 28);
            label3.TabIndex = 12;
            label3.Text = "Now In Process";
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(811, 607);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(labelInfo2);
            Controls.Add(labelInfoBox);
            Controls.Add(panel1);
            ForeColor = SystemColors.HotTrack;
            Name = "Form1";
            Text = "Your Bartender";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListFruits;
        private CheckedListBox checkedListSyrup;
        private Panel panel1;
        private CheckedListBox checkedListExtra;
        private Label labelAlcohol;
        private Label labelSyrup;
        private Label labelOther;
        private Label labelFruits;
        private Button buttonLaunch;
        private Label labelLiqueur;
        private CheckedListBox checkedListLiqueur;
        private Label labelInfoBox;
        private ComboBox comboBoxAlcohol;
        private Label labelInfo2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
    }
}
