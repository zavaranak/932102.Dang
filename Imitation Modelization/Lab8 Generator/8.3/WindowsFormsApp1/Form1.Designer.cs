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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorABox = new System.Windows.Forms.TextBox();
            this.errorVBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.variance2Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.avarage2Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chiBox = new System.Windows.Forms.TextBox();
            this.varianceBox = new System.Windows.Forms.TextBox();
            this.avarageBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.prob5 = new System.Windows.Forms.TextBox();
            this.trialNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialNum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorABox);
            this.panel1.Controls.Add(this.errorVBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.variance2Box);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.avarage2Box);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.chiBox);
            this.panel1.Controls.Add(this.varianceBox);
            this.panel1.Controls.Add(this.avarageBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 467);
            this.panel1.TabIndex = 0;
            // 
            // errorABox
            // 
            this.errorABox.Location = new System.Drawing.Point(664, 350);
            this.errorABox.Name = "errorABox";
            this.errorABox.ReadOnly = true;
            this.errorABox.Size = new System.Drawing.Size(100, 20);
            this.errorABox.TabIndex = 29;
            this.errorABox.Text = "ready";
            this.errorABox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorVBox
            // 
            this.errorVBox.Location = new System.Drawing.Point(664, 385);
            this.errorVBox.Name = "errorVBox";
            this.errorVBox.ReadOnly = true;
            this.errorVBox.Size = new System.Drawing.Size(100, 20);
            this.errorVBox.TabIndex = 28;
            this.errorVBox.Text = "ready";
            this.errorVBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(512, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Error Variance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(512, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Error Avarage";
            // 
            // variance2Box
            // 
            this.variance2Box.Location = new System.Drawing.Point(368, 422);
            this.variance2Box.Name = "variance2Box";
            this.variance2Box.ReadOnly = true;
            this.variance2Box.Size = new System.Drawing.Size(100, 20);
            this.variance2Box.TabIndex = 25;
            this.variance2Box.Text = "ready";
            this.variance2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(248, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 40);
            this.label9.TabIndex = 24;
            this.label9.Text = "Variance\r\n(Empirical)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(248, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 40);
            this.label12.TabIndex = 23;
            this.label12.Text = "Variance\r\n(Mathematical)\r\n";
            // 
            // avarage2Box
            // 
            this.avarage2Box.Location = new System.Drawing.Point(132, 420);
            this.avarage2Box.Name = "avarage2Box";
            this.avarage2Box.ReadOnly = true;
            this.avarage2Box.Size = new System.Drawing.Size(100, 20);
            this.avarage2Box.TabIndex = 22;
            this.avarage2Box.Text = "ready";
            this.avarage2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 40);
            this.label11.TabIndex = 21;
            this.label11.Text = "Avarage\r\n(Empirical)";
            // 
            // chiBox
            // 
            this.chiBox.Location = new System.Drawing.Point(624, 420);
            this.chiBox.Name = "chiBox";
            this.chiBox.ReadOnly = true;
            this.chiBox.Size = new System.Drawing.Size(192, 20);
            this.chiBox.TabIndex = 18;
            this.chiBox.Text = "ready";
            this.chiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varianceBox
            // 
            this.varianceBox.Location = new System.Drawing.Point(368, 367);
            this.varianceBox.Name = "varianceBox";
            this.varianceBox.ReadOnly = true;
            this.varianceBox.Size = new System.Drawing.Size(100, 20);
            this.varianceBox.TabIndex = 19;
            this.varianceBox.Text = "ready";
            this.varianceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avarageBox
            // 
            this.avarageBox.Location = new System.Drawing.Point(132, 367);
            this.avarageBox.Name = "avarageBox";
            this.avarageBox.ReadOnly = true;
            this.avarageBox.Size = new System.Drawing.Size(100, 20);
            this.avarageBox.TabIndex = 20;
            this.avarageBox.Text = "ready";
            this.avarageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(512, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Chi-square";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 40);
            this.label8.TabIndex = 18;
            this.label8.Text = "Avarage\r\n(Mathematical)\r\n";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(184, 3);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Label = "#VAL";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(641, 333);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.prob4);
            this.panel2.Controls.Add(this.prob3);
            this.panel2.Controls.Add(this.prob2);
            this.panel2.Controls.Add(this.prob1);
            this.panel2.Controls.Add(this.prob5);
            this.panel2.Controls.Add(this.trialNum);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 337);
            this.panel2.TabIndex = 0;
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 2;
            this.prob4.Location = new System.Drawing.Point(83, 145);
            this.prob4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(68, 20);
            this.prob4.TabIndex = 17;
            this.prob4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prob4.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 2;
            this.prob3.Location = new System.Drawing.Point(83, 103);
            this.prob3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(68, 20);
            this.prob3.TabIndex = 16;
            this.prob3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prob3.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 2;
            this.prob2.Location = new System.Drawing.Point(83, 66);
            this.prob2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(68, 20);
            this.prob2.TabIndex = 15;
            this.prob2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prob2.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 2;
            this.prob1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.prob1.Location = new System.Drawing.Point(83, 30);
            this.prob1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(68, 20);
            this.prob1.TabIndex = 14;
            this.prob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prob1.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // prob5
            // 
            this.prob5.Location = new System.Drawing.Point(83, 178);
            this.prob5.Name = "prob5";
            this.prob5.ReadOnly = true;
            this.prob5.Size = new System.Drawing.Size(68, 20);
            this.prob5.TabIndex = 13;
            this.prob5.Text = "auto";
            this.prob5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trialNum
            // 
            this.trialNum.Location = new System.Drawing.Point(26, 241);
            this.trialNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.trialNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.trialNum.Name = "trialNum";
            this.trialNum.Size = new System.Drawing.Size(120, 20);
            this.trialNum.TabIndex = 8;
            this.trialNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trialNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number Of Trials";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prob 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prob 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prob 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prob 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prob 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(58, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 469);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "8.3 Updated to 9";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trialNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown trialNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prob5;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox chiBox;
        private System.Windows.Forms.TextBox varianceBox;
        private System.Windows.Forms.TextBox avarageBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox variance2Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox avarage2Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox errorABox;
        private System.Windows.Forms.TextBox errorVBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

