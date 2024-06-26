﻿namespace CurrencyModel
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.edEuro = new System.Windows.Forms.NumericUpDown();
            this.edUSD = new System.Windows.Forms.NumericUpDown();
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelInitial = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.edPound = new System.Windows.Forms.NumericUpDown();
            this.edFranc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFranc)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.edPound);
            this.controlPanel.Controls.Add(this.edFranc);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.buttonLaunch);
            this.controlPanel.Controls.Add(this.edEuro);
            this.controlPanel.Controls.Add(this.edUSD);
            this.controlPanel.Controls.Add(this.labelEuro);
            this.controlPanel.Controls.Add(this.labelUSD);
            this.controlPanel.Controls.Add(this.labelInitial);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(690, 89);
            this.controlPanel.TabIndex = 0;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLaunch.Location = new System.Drawing.Point(493, 15);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(154, 59);
            this.buttonLaunch.TabIndex = 1;
            this.buttonLaunch.Text = "Start/Stop";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // edEuro
            // 
            this.edEuro.Location = new System.Drawing.Point(184, 42);
            this.edEuro.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edEuro.Name = "edEuro";
            this.edEuro.Size = new System.Drawing.Size(57, 20);
            this.edEuro.TabIndex = 5;
            this.edEuro.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // edUSD
            // 
            this.edUSD.Location = new System.Drawing.Point(184, 9);
            this.edUSD.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edUSD.Name = "edUSD";
            this.edUSD.Size = new System.Drawing.Size(57, 20);
            this.edUSD.TabIndex = 4;
            this.edUSD.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEuro.Location = new System.Drawing.Point(117, 45);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(52, 17);
            this.labelEuro.TabIndex = 2;
            this.labelEuro.Text = "EURO:";
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUSD.Location = new System.Drawing.Point(117, 9);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(41, 17);
            this.labelUSD.TabIndex = 1;
            this.labelUSD.Text = "USD:";
            // 
            // labelInitial
            // 
            this.labelInitial.AutoSize = true;
            this.labelInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInitial.Location = new System.Drawing.Point(12, 9);
            this.labelInitial.Name = "labelInitial";
            this.labelInitial.Size = new System.Drawing.Size(89, 17);
            this.labelInitial.TabIndex = 0;
            this.labelInitial.Text = "Initial Price";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 95);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "USD";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.Legend = "Legend1";
            series2.Name = "EURO";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "FRANC";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "POUND";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(690, 356);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // edPound
            // 
            this.edPound.Location = new System.Drawing.Point(337, 42);
            this.edPound.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edPound.Name = "edPound";
            this.edPound.Size = new System.Drawing.Size(57, 20);
            this.edPound.TabIndex = 9;
            this.edPound.Value = new decimal(new int[] {
            115,
            0,
            0,
            0});
            // 
            // edFranc
            // 
            this.edFranc.Location = new System.Drawing.Point(337, 9);
            this.edFranc.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edFranc.Name = "edFranc";
            this.edFranc.Size = new System.Drawing.Size(57, 20);
            this.edFranc.TabIndex = 8;
            this.edFranc.Value = new decimal(new int[] {
            103,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "POUND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "FRANC:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFranc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.Label labelInitial;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.NumericUpDown edEuro;
        private System.Windows.Forms.NumericUpDown edUSD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown edPound;
        private System.Windows.Forms.NumericUpDown edFranc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

