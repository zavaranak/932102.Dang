namespace ElementaryCellularAutomaton
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
            this.components = new System.ComponentModel.Container();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttontest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textTest = new System.Windows.Forms.TextBox();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.edRule = new System.Windows.Forms.NumericUpDown();
            this.labelRuleSelect = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.textBox2);
            this.controlPanel.Controls.Add(this.textBox1);
            this.controlPanel.Controls.Add(this.buttontest);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.textTest);
            this.controlPanel.Controls.Add(this.buttonLaunch);
            this.controlPanel.Controls.Add(this.edRule);
            this.controlPanel.Controls.Add(this.labelRuleSelect);
            this.controlPanel.Location = new System.Drawing.Point(15, 9);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(190, 539);
            this.controlPanel.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 5;
            // 
            // buttontest
            // 
            this.buttontest.Location = new System.Drawing.Point(59, 319);
            this.buttontest.Name = "buttontest";
            this.buttontest.Size = new System.Drawing.Size(68, 90);
            this.buttontest.TabIndex = 4;
            this.buttontest.Text = "Clear";
            this.buttontest.UseVisualStyleBackColor = true;
            this.buttontest.Click += new System.EventHandler(this.buttontest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIN:";
            // 
            // textTest
            // 
            this.textTest.Location = new System.Drawing.Point(59, 100);
            this.textTest.Name = "textTest";
            this.textTest.ReadOnly = true;
            this.textTest.Size = new System.Drawing.Size(68, 20);
            this.textTest.TabIndex = 2;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(59, 206);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(68, 90);
            this.buttonLaunch.TabIndex = 1;
            this.buttonLaunch.Text = "Start/Stop";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // edRule
            // 
            this.edRule.Location = new System.Drawing.Point(59, 55);
            this.edRule.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.edRule.Name = "edRule";
            this.edRule.Size = new System.Drawing.Size(68, 20);
            this.edRule.TabIndex = 1;
            // 
            // labelRuleSelect
            // 
            this.labelRuleSelect.AutoSize = true;
            this.labelRuleSelect.Location = new System.Drawing.Point(14, 57);
            this.labelRuleSelect.Name = "labelRuleSelect";
            this.labelRuleSelect.Size = new System.Drawing.Size(39, 13);
            this.labelRuleSelect.TabIndex = 0;
            this.labelRuleSelect.Text = "RULE:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(211, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(509, 517);
            this.dataGridView1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label labelRuleSelect;
        private System.Windows.Forms.NumericUpDown edRule;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttontest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

