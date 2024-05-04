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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.chiBox = new System.Windows.Forms.TextBox();
            this.varianceBox = new System.Windows.Forms.TextBox();
            this.avarageBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sizeInput = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.varInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meanInput = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanInput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.chiBox);
            this.panel1.Controls.Add(this.varianceBox);
            this.panel1.Controls.Add(this.avarageBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 407);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(235, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Variance";
            // 
            // chiBox
            // 
            this.chiBox.Location = new System.Drawing.Point(577, 369);
            this.chiBox.Name = "chiBox";
            this.chiBox.ReadOnly = true;
            this.chiBox.Size = new System.Drawing.Size(192, 20);
            this.chiBox.TabIndex = 18;
            this.chiBox.Text = "ready";
            this.chiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varianceBox
            // 
            this.varianceBox.Location = new System.Drawing.Point(313, 369);
            this.varianceBox.Name = "varianceBox";
            this.varianceBox.ReadOnly = true;
            this.varianceBox.Size = new System.Drawing.Size(146, 20);
            this.varianceBox.TabIndex = 19;
            this.varianceBox.Text = "ready";
            this.varianceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avarageBox
            // 
            this.avarageBox.Location = new System.Drawing.Point(86, 367);
            this.avarageBox.Name = "avarageBox";
            this.avarageBox.ReadOnly = true;
            this.avarageBox.Size = new System.Drawing.Size(143, 20);
            this.avarageBox.TabIndex = 20;
            this.avarageBox.Text = "ready";
            this.avarageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(465, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Chi-square";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Avarage\r\n";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(184, 3);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PointWidth=1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Label = "#VAL";
            series2.LabelBorderWidth = 2;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Black;
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(641, 333);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.meanInput);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.varInput);
            this.panel2.Controls.Add(this.sizeInput);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 337);
            this.panel2.TabIndex = 0;
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(30, 246);
            this.sizeInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sizeInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(114, 20);
            this.sizeInput.TabIndex = 8;
            this.sizeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sizeInput.Value = new decimal(new int[] {
            10,
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
            this.label6.Location = new System.Drawing.Point(42, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sample Size";
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
            // varInput
            // 
            this.varInput.DecimalPlaces = 2;
            this.varInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.varInput.Location = new System.Drawing.Point(30, 166);
            this.varInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.varInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.varInput.Name = "varInput";
            this.varInput.Size = new System.Drawing.Size(114, 20);
            this.varInput.TabIndex = 9;
            this.varInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.varInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "VARIANCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "MEAN";
            // 
            // meanInput
            // 
            this.meanInput.DecimalPlaces = 2;
            this.meanInput.Location = new System.Drawing.Point(30, 92);
            this.meanInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.meanInput.Name = "meanInput";
            this.meanInput.Size = new System.Drawing.Size(114, 20);
            this.meanInput.TabIndex = 12;
            this.meanInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lab11";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sizeInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox chiBox;
        private System.Windows.Forms.TextBox varianceBox;
        private System.Windows.Forms.TextBox avarageBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown meanInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown varInput;
    }
}

