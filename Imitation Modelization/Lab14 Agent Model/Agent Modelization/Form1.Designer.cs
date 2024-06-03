namespace Agent_Modelization
{
    partial class Bank
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelClientArrival = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.showAvailableAgents = new System.Windows.Forms.Label();
            this.inputNumberOfAgents = new System.Windows.Forms.NumericUpDown();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNumberOfAgents = new System.Windows.Forms.Label();
            this.showClientsInQueue = new System.Windows.Forms.Label();
            this.showServedClients = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showWorkShift = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumberOfAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelClientArrival);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.showAvailableAgents);
            this.panel1.Controls.Add(this.inputNumberOfAgents);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.labelNumberOfAgents);
            this.panel1.Controls.Add(this.showClientsInQueue);
            this.panel1.Controls.Add(this.showServedClients);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(32, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 488);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(262, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Agents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(506, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "(available)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Agent_Modelization.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Agent_Modelization.Properties.Resources.agent;
            this.pictureBox2.Location = new System.Drawing.Point(64, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // labelClientArrival
            // 
            this.labelClientArrival.AutoSize = true;
            this.labelClientArrival.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientArrival.ForeColor = System.Drawing.Color.Transparent;
            this.labelClientArrival.Location = new System.Drawing.Point(44, 189);
            this.labelClientArrival.Name = "labelClientArrival";
            this.labelClientArrival.Size = new System.Drawing.Size(109, 23);
            this.labelClientArrival.TabIndex = 15;
            this.labelClientArrival.Text = "Client arrives";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Agent_Modelization.Properties.Resources.newclient;
            this.pictureBox6.Location = new System.Drawing.Point(64, 135);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(74, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // showAvailableAgents
            // 
            this.showAvailableAgents.AutoSize = true;
            this.showAvailableAgents.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAvailableAgents.ForeColor = System.Drawing.Color.Transparent;
            this.showAvailableAgents.Location = new System.Drawing.Point(445, 454);
            this.showAvailableAgents.Name = "showAvailableAgents";
            this.showAvailableAgents.Size = new System.Drawing.Size(19, 23);
            this.showAvailableAgents.TabIndex = 9;
            this.showAvailableAgents.Text = "0";
            // 
            // inputNumberOfAgents
            // 
            this.inputNumberOfAgents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumberOfAgents.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumberOfAgents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputNumberOfAgents.Location = new System.Drawing.Point(123, 41);
            this.inputNumberOfAgents.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inputNumberOfAgents.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.inputNumberOfAgents.Name = "inputNumberOfAgents";
            this.inputNumberOfAgents.Size = new System.Drawing.Size(38, 22);
            this.inputNumberOfAgents.TabIndex = 2;
            this.inputNumberOfAgents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNumberOfAgents.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.inputNumberOfAgents.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Agent_Modelization.Properties.Resources.servedclient;
            this.pictureBox5.Location = new System.Drawing.Point(423, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(74, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Agent_Modelization.Properties.Resources.client;
            this.pictureBox4.Location = new System.Drawing.Point(423, 135);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // labelNumberOfAgents
            // 
            this.labelNumberOfAgents.AutoSize = true;
            this.labelNumberOfAgents.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfAgents.ForeColor = System.Drawing.Color.Transparent;
            this.labelNumberOfAgents.Location = new System.Drawing.Point(41, 82);
            this.labelNumberOfAgents.Name = "labelNumberOfAgents";
            this.labelNumberOfAgents.Size = new System.Drawing.Size(126, 23);
            this.labelNumberOfAgents.TabIndex = 3;
            this.labelNumberOfAgents.Text = "Agents on duty";
            // 
            // showClientsInQueue
            // 
            this.showClientsInQueue.AutoSize = true;
            this.showClientsInQueue.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showClientsInQueue.ForeColor = System.Drawing.Color.Transparent;
            this.showClientsInQueue.Location = new System.Drawing.Point(506, 150);
            this.showClientsInQueue.Name = "showClientsInQueue";
            this.showClientsInQueue.Size = new System.Drawing.Size(19, 23);
            this.showClientsInQueue.TabIndex = 8;
            this.showClientsInQueue.Text = "0";
            // 
            // showServedClients
            // 
            this.showServedClients.AutoSize = true;
            this.showServedClients.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showServedClients.ForeColor = System.Drawing.Color.Transparent;
            this.showServedClients.Location = new System.Drawing.Point(506, 38);
            this.showServedClients.Name = "showServedClients";
            this.showServedClients.Size = new System.Drawing.Size(19, 23);
            this.showServedClients.TabIndex = 7;
            this.showServedClients.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(400, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clients in queue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(408, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Served clients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(533, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "(hours)";
            // 
            // showWorkShift
            // 
            this.showWorkShift.AutoSize = true;
            this.showWorkShift.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showWorkShift.ForeColor = System.Drawing.Color.Transparent;
            this.showWorkShift.Location = new System.Drawing.Point(579, 10);
            this.showWorkShift.Name = "showWorkShift";
            this.showWorkShift.Size = new System.Drawing.Size(19, 23);
            this.showWorkShift.TabIndex = 10;
            this.showWorkShift.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Agent_Modelization.Properties.Resources.clock;
            this.pictureBox3.Location = new System.Drawing.Point(534, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonStop);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonStart);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.showWorkShift);
            this.panel2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(-1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 95);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(283, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "VTB BANK";
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStop.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonStop.Location = new System.Drawing.Point(349, 51);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(118, 35);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "CLOSE";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonStart.Location = new System.Drawing.Point(197, 51);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(118, 35);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "OPEN";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 60;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 60;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(130)))));
            this.BackgroundImage = global::Agent_Modelization.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(659, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Bank";
            this.Text = "Bank";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumberOfAgents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNumberOfAgents;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label showAvailableAgents;
        private System.Windows.Forms.Label showClientsInQueue;
        private System.Windows.Forms.Label showServedClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label showWorkShift;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelClientArrival;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.NumericUpDown inputNumberOfAgents;
        private System.Windows.Forms.Timer timer4;
    }
}

