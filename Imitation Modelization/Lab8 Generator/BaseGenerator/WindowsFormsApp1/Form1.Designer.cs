namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionBox = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.answerLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.BackColor = System.Drawing.Color.White;
            this.questionBox.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionBox.Location = new System.Drawing.Point(48, 40);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(378, 45);
            this.questionBox.TabIndex = 0;
            this.questionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Button1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Button1.Location = new System.Drawing.Point(82, 105);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(313, 54);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Ответь";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.answerLabel);
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Controls.Add(this.questionBox);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(20, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 315);
            this.panel1.TabIndex = 2;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.answerLabel.Location = new System.Drawing.Point(158, 193);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(159, 61);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.Text = "label1";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.answerLabel.Click += new System.EventHandler(this.answerLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 347);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "YesOrNo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label answerLabel;
    }
}

