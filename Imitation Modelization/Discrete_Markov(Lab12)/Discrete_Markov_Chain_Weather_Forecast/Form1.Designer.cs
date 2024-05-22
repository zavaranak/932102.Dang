namespace DiscreteMarkovChainWeatherForecast
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.daysForwardInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClear = new System.Windows.Forms.Label();
            this.labelOvercast = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.currentStateComboBox = new System.Windows.Forms.ComboBox();
            this.weatherChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCloudy = new System.Windows.Forms.Label();
            this.resultClear = new System.Windows.Forms.Label();
            this.resultCloudy = new System.Windows.Forms.Label();
            this.resultOvercast = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.daysForwardInput)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherChart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(474, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Forecast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // daysForwardInput
            // 
            this.daysForwardInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysForwardInput.Location = new System.Drawing.Point(281, 20);
            this.daysForwardInput.Name = "daysForwardInput";
            this.daysForwardInput.Size = new System.Drawing.Size(131, 26);
            this.daysForwardInput.TabIndex = 1;
            this.daysForwardInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Days Forward";
            // 
            // labelClear
            // 
            this.labelClear.AutoSize = true;
            this.labelClear.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelClear.Location = new System.Drawing.Point(74, 99);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(73, 33);
            this.labelClear.TabIndex = 4;
            this.labelClear.Text = "Clear";
            // 
            // labelOvercast
            // 
            this.labelOvercast.AutoSize = true;
            this.labelOvercast.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOvercast.ForeColor = System.Drawing.Color.Crimson;
            this.labelOvercast.Location = new System.Drawing.Point(468, 99);
            this.labelOvercast.Name = "labelOvercast";
            this.labelOvercast.Size = new System.Drawing.Size(107, 33);
            this.labelOvercast.TabIndex = 5;
            this.labelOvercast.Text = "Overcast";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultOvercast);
            this.panel1.Controls.Add(this.resultCloudy);
            this.panel1.Controls.Add(this.resultClear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.currentStateComboBox);
            this.panel1.Controls.Add(this.weatherChart);
            this.panel1.Controls.Add(this.labelCloudy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.daysForwardInput);
            this.panel1.Controls.Add(this.labelOvercast);
            this.panel1.Controls.Add(this.labelClear);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 484);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Initial State";
            // 
            // currentStateComboBox
            // 
            this.currentStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentStateComboBox.FormattingEnabled = true;
            this.currentStateComboBox.Items.AddRange(new object[] {
            "Clear",
            "Cloudy",
            "Overcast"});
            this.currentStateComboBox.Location = new System.Drawing.Point(80, 18);
            this.currentStateComboBox.Name = "currentStateComboBox";
            this.currentStateComboBox.Size = new System.Drawing.Size(121, 28);
            this.currentStateComboBox.TabIndex = 11;
            this.currentStateComboBox.Text = "--Select--";
            // 
            // weatherChart
            // 
            this.weatherChart.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea9.AxisX.Minimum = 1D;
            chartArea9.AxisY.Maximum = 100D;
            chartArea9.AxisY.Minimum = 0D;
            chartArea9.Name = "ChartArea1";
            this.weatherChart.ChartAreas.Add(chartArea9);
            this.weatherChart.Location = new System.Drawing.Point(0, 135);
            this.weatherChart.Name = "weatherChart";
            series25.BorderWidth = 2;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.IsXValueIndexed = true;
            series25.Name = "Series1";
            series26.BorderWidth = 2;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series26.Name = "Series2";
            series27.BorderWidth = 2;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Name = "Series3";
            this.weatherChart.Series.Add(series25);
            this.weatherChart.Series.Add(series26);
            this.weatherChart.Series.Add(series27);
            this.weatherChart.Size = new System.Drawing.Size(684, 349);
            this.weatherChart.TabIndex = 10;
            this.weatherChart.Text = "chart1";
            // 
            // labelCloudy
            // 
            this.labelCloudy.AutoSize = true;
            this.labelCloudy.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloudy.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelCloudy.Location = new System.Drawing.Point(275, 99);
            this.labelCloudy.Name = "labelCloudy";
            this.labelCloudy.Size = new System.Drawing.Size(93, 33);
            this.labelCloudy.TabIndex = 6;
            this.labelCloudy.Text = "Cloudy";
            // 
            // resultClear
            // 
            this.resultClear.AutoSize = true;
            this.resultClear.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultClear.Location = new System.Drawing.Point(162, 105);
            this.resultClear.Name = "resultClear";
            this.resultClear.Size = new System.Drawing.Size(39, 25);
            this.resultClear.TabIndex = 13;
            this.resultClear.Text = "--%";
            // 
            // resultCloudy
            // 
            this.resultCloudy.AutoSize = true;
            this.resultCloudy.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultCloudy.Location = new System.Drawing.Point(374, 105);
            this.resultCloudy.Name = "resultCloudy";
            this.resultCloudy.Size = new System.Drawing.Size(39, 25);
            this.resultCloudy.TabIndex = 14;
            this.resultCloudy.Text = "--%";
            // 
            // resultOvercast
            // 
            this.resultOvercast.AutoSize = true;
            this.resultOvercast.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultOvercast.Location = new System.Drawing.Point(581, 105);
            this.resultOvercast.Name = "resultOvercast";
            this.resultOvercast.Size = new System.Drawing.Size(39, 25);
            this.resultOvercast.TabIndex = 15;
            this.resultOvercast.Text = "--%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(695, 498);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Weather Forecast";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daysForwardInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown daysForwardInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Label labelOvercast;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCloudy;
        private System.Windows.Forms.DataVisualization.Charting.Chart weatherChart;
        private System.Windows.Forms.ComboBox currentStateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultOvercast;
        private System.Windows.Forms.Label resultCloudy;
        private System.Windows.Forms.Label resultClear;
        private System.Windows.Forms.Timer timer1;
    }
}

