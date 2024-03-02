namespace Flight
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edStep = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.edSize = new System.Windows.Forms.NumericUpDown();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EndSpeed5 = new System.Windows.Forms.TextBox();
            this.MH5 = new System.Windows.Forms.TextBox();
            this.Distance5 = new System.Windows.Forms.TextBox();
            this.TimeStep5 = new System.Windows.Forms.TextBox();
            this.EndSpeed4 = new System.Windows.Forms.TextBox();
            this.MH4 = new System.Windows.Forms.TextBox();
            this.Distance4 = new System.Windows.Forms.TextBox();
            this.TimeStep4 = new System.Windows.Forms.TextBox();
            this.EndSpeed3 = new System.Windows.Forms.TextBox();
            this.MH3 = new System.Windows.Forms.TextBox();
            this.Distance3 = new System.Windows.Forms.TextBox();
            this.TimeStep3 = new System.Windows.Forms.TextBox();
            this.EndSpeed2 = new System.Windows.Forms.TextBox();
            this.MH2 = new System.Windows.Forms.TextBox();
            this.Distance2 = new System.Windows.Forms.TextBox();
            this.TimeStep2 = new System.Windows.Forms.TextBox();
            this.EndSpeed1 = new System.Windows.Forms.TextBox();
            this.MH1 = new System.Windows.Forms.TextBox();
            this.Distance1 = new System.Windows.Forms.TextBox();
            this.TimeStep1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edStep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.edSize);
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 203);
            this.panel1.TabIndex = 0;
            // 
            // edStep
            // 
            this.edStep.DecimalPlaces = 3;
            this.edStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.edStep.Location = new System.Drawing.Point(56, 133);
            this.edStep.Name = "edStep";
            this.edStep.Size = new System.Drawing.Size(120, 20);
            this.edStep.TabIndex = 12;
            this.edStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Step";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(101, 158);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 42);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "Clear";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonStart.Location = new System.Drawing.Point(10, 158);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 42);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // edSize
            // 
            this.edSize.Location = new System.Drawing.Point(56, 105);
            this.edSize.Name = "edSize";
            this.edSize.Size = new System.Drawing.Size(120, 20);
            this.edSize.TabIndex = 9;
            this.edSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // edWeight
            // 
            this.edWeight.Location = new System.Drawing.Point(56, 79);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(120, 20);
            this.edWeight.TabIndex = 8;
            this.edWeight.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(56, 53);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 20);
            this.edAngle.TabIndex = 7;
            this.edAngle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(56, 27);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 20);
            this.edSpeed.TabIndex = 6;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(56, 1);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 20);
            this.edHeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(10, 202);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series5";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(747, 418);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "TimeStep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Distance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "MaxHeight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "SpeedAtTheEndPoint";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.EndSpeed5);
            this.panel2.Controls.Add(this.MH5);
            this.panel2.Controls.Add(this.Distance5);
            this.panel2.Controls.Add(this.TimeStep5);
            this.panel2.Controls.Add(this.EndSpeed4);
            this.panel2.Controls.Add(this.MH4);
            this.panel2.Controls.Add(this.Distance4);
            this.panel2.Controls.Add(this.TimeStep4);
            this.panel2.Controls.Add(this.EndSpeed3);
            this.panel2.Controls.Add(this.MH3);
            this.panel2.Controls.Add(this.Distance3);
            this.panel2.Controls.Add(this.TimeStep3);
            this.panel2.Controls.Add(this.EndSpeed2);
            this.panel2.Controls.Add(this.MH2);
            this.panel2.Controls.Add(this.Distance2);
            this.panel2.Controls.Add(this.TimeStep2);
            this.panel2.Controls.Add(this.EndSpeed1);
            this.panel2.Controls.Add(this.MH1);
            this.panel2.Controls.Add(this.Distance1);
            this.panel2.Controls.Add(this.TimeStep1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(189, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 180);
            this.panel2.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(478, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "[5]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "[4]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "[3]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(234, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "[2]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "[1]";
            // 
            // EndSpeed5
            // 
            this.EndSpeed5.Location = new System.Drawing.Point(457, 113);
            this.EndSpeed5.Name = "EndSpeed5";
            this.EndSpeed5.ReadOnly = true;
            this.EndSpeed5.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed5.TabIndex = 27;
            // 
            // MH5
            // 
            this.MH5.Location = new System.Drawing.Point(457, 87);
            this.MH5.Name = "MH5";
            this.MH5.ReadOnly = true;
            this.MH5.Size = new System.Drawing.Size(65, 20);
            this.MH5.TabIndex = 26;
            // 
            // Distance5
            // 
            this.Distance5.Location = new System.Drawing.Point(457, 64);
            this.Distance5.Name = "Distance5";
            this.Distance5.ReadOnly = true;
            this.Distance5.Size = new System.Drawing.Size(65, 20);
            this.Distance5.TabIndex = 25;
            // 
            // TimeStep5
            // 
            this.TimeStep5.Location = new System.Drawing.Point(457, 35);
            this.TimeStep5.Name = "TimeStep5";
            this.TimeStep5.ReadOnly = true;
            this.TimeStep5.Size = new System.Drawing.Size(65, 20);
            this.TimeStep5.TabIndex = 24;
            // 
            // EndSpeed4
            // 
            this.EndSpeed4.Location = new System.Drawing.Point(373, 113);
            this.EndSpeed4.Name = "EndSpeed4";
            this.EndSpeed4.ReadOnly = true;
            this.EndSpeed4.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed4.TabIndex = 23;
            // 
            // MH4
            // 
            this.MH4.Location = new System.Drawing.Point(373, 87);
            this.MH4.Name = "MH4";
            this.MH4.ReadOnly = true;
            this.MH4.Size = new System.Drawing.Size(65, 20);
            this.MH4.TabIndex = 22;
            // 
            // Distance4
            // 
            this.Distance4.Location = new System.Drawing.Point(373, 61);
            this.Distance4.Name = "Distance4";
            this.Distance4.ReadOnly = true;
            this.Distance4.Size = new System.Drawing.Size(65, 20);
            this.Distance4.TabIndex = 21;
            // 
            // TimeStep4
            // 
            this.TimeStep4.Location = new System.Drawing.Point(373, 35);
            this.TimeStep4.Name = "TimeStep4";
            this.TimeStep4.ReadOnly = true;
            this.TimeStep4.Size = new System.Drawing.Size(65, 20);
            this.TimeStep4.TabIndex = 20;
            // 
            // EndSpeed3
            // 
            this.EndSpeed3.Location = new System.Drawing.Point(292, 113);
            this.EndSpeed3.Name = "EndSpeed3";
            this.EndSpeed3.ReadOnly = true;
            this.EndSpeed3.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed3.TabIndex = 19;
            // 
            // MH3
            // 
            this.MH3.Location = new System.Drawing.Point(292, 87);
            this.MH3.Name = "MH3";
            this.MH3.ReadOnly = true;
            this.MH3.Size = new System.Drawing.Size(65, 20);
            this.MH3.TabIndex = 18;
            // 
            // Distance3
            // 
            this.Distance3.Location = new System.Drawing.Point(292, 61);
            this.Distance3.Name = "Distance3";
            this.Distance3.ReadOnly = true;
            this.Distance3.Size = new System.Drawing.Size(65, 20);
            this.Distance3.TabIndex = 17;
            // 
            // TimeStep3
            // 
            this.TimeStep3.Location = new System.Drawing.Point(292, 35);
            this.TimeStep3.Name = "TimeStep3";
            this.TimeStep3.ReadOnly = true;
            this.TimeStep3.Size = new System.Drawing.Size(65, 20);
            this.TimeStep3.TabIndex = 16;
            // 
            // EndSpeed2
            // 
            this.EndSpeed2.Location = new System.Drawing.Point(211, 113);
            this.EndSpeed2.Name = "EndSpeed2";
            this.EndSpeed2.ReadOnly = true;
            this.EndSpeed2.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed2.TabIndex = 15;
            // 
            // MH2
            // 
            this.MH2.Location = new System.Drawing.Point(211, 87);
            this.MH2.Name = "MH2";
            this.MH2.ReadOnly = true;
            this.MH2.Size = new System.Drawing.Size(65, 20);
            this.MH2.TabIndex = 14;
            // 
            // Distance2
            // 
            this.Distance2.Location = new System.Drawing.Point(211, 61);
            this.Distance2.Name = "Distance2";
            this.Distance2.ReadOnly = true;
            this.Distance2.Size = new System.Drawing.Size(65, 20);
            this.Distance2.TabIndex = 13;
            // 
            // TimeStep2
            // 
            this.TimeStep2.Location = new System.Drawing.Point(211, 35);
            this.TimeStep2.Name = "TimeStep2";
            this.TimeStep2.ReadOnly = true;
            this.TimeStep2.Size = new System.Drawing.Size(65, 20);
            this.TimeStep2.TabIndex = 12;
            // 
            // EndSpeed1
            // 
            this.EndSpeed1.Location = new System.Drawing.Point(127, 113);
            this.EndSpeed1.Name = "EndSpeed1";
            this.EndSpeed1.ReadOnly = true;
            this.EndSpeed1.Size = new System.Drawing.Size(65, 20);
            this.EndSpeed1.TabIndex = 11;
            // 
            // MH1
            // 
            this.MH1.Location = new System.Drawing.Point(127, 87);
            this.MH1.Name = "MH1";
            this.MH1.ReadOnly = true;
            this.MH1.Size = new System.Drawing.Size(65, 20);
            this.MH1.TabIndex = 10;
            // 
            // Distance1
            // 
            this.Distance1.Location = new System.Drawing.Point(127, 61);
            this.Distance1.Name = "Distance1";
            this.Distance1.ReadOnly = true;
            this.Distance1.Size = new System.Drawing.Size(65, 20);
            this.Distance1.TabIndex = 9;
            // 
            // TimeStep1
            // 
            this.TimeStep1.Location = new System.Drawing.Point(127, 35);
            this.TimeStep1.Name = "TimeStep1";
            this.TimeStep1.ReadOnly = true;
            this.TimeStep1.Size = new System.Drawing.Size(65, 20);
            this.TimeStep1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "[Result]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown edSize;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EndSpeed5;
        private System.Windows.Forms.TextBox MH5;
        private System.Windows.Forms.TextBox Distance5;
        private System.Windows.Forms.TextBox TimeStep5;
        private System.Windows.Forms.TextBox EndSpeed4;
        private System.Windows.Forms.TextBox MH4;
        private System.Windows.Forms.TextBox Distance4;
        private System.Windows.Forms.TextBox TimeStep4;
        private System.Windows.Forms.TextBox EndSpeed3;
        private System.Windows.Forms.TextBox MH3;
        private System.Windows.Forms.TextBox Distance3;
        private System.Windows.Forms.TextBox TimeStep3;
        private System.Windows.Forms.TextBox EndSpeed2;
        private System.Windows.Forms.TextBox MH2;
        private System.Windows.Forms.TextBox Distance2;
        private System.Windows.Forms.TextBox TimeStep2;
        private System.Windows.Forms.TextBox EndSpeed1;
        private System.Windows.Forms.TextBox MH1;
        private System.Windows.Forms.TextBox Distance1;
        private System.Windows.Forms.TextBox TimeStep1;
        private System.Windows.Forms.NumericUpDown edStep;
    }
}

