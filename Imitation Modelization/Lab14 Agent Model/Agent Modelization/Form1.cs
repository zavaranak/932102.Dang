using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

//using System.Threading;
using System.Windows.Forms;

namespace Agent_Modelization
{
    public partial class Bank : Form
    {
        private BankModel VTBBranch;
        private PictureBox animation,animation2;
        public Bank()
        {
            InitializeComponent();
            animation = new PictureBox();
            animation.Size = new Size(74, 50);
            animation.Location = new Point(64, 135);
            animation.Image = Properties.Resources.animation;
            animation.SizeMode = PictureBoxSizeMode.StretchImage;
            animation.BackColor = Color.Transparent; 
            panel1.Controls.Add(animation);
            animation.Visible = false;

            animation2 = new PictureBox();
            animation2.Size = new Size(74, 50);
            animation2.Location = new Point(449, 135);
            animation2.Image = Properties.Resources.animation;
            animation2.SizeMode = PictureBoxSizeMode.StretchImage;
            animation2.BackColor = Color.Transparent;
            panel1.Controls.Add(animation2);
            animation2.Visible = false;
        }
        private void UpdateInterface()
        {
            showAvailableAgents.Text = (VTBBranch.agents.Length - VTBBranch.busyAgents).ToString();
            showClientsInQueue.Text = (VTBBranch.queue).ToString();
            showServedClients.Text = (VTBBranch.servedClients).ToString();
            showWorkShift.Text = (VTBBranch.operatingTime).ToString("F1");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int N = (int)(inputNumberOfAgents.Value);
            VTBBranch = new BankModel(N, timer2, timer3, timer4);
            initAgent(N);
            timer1.Start();
        }
        private void DoBankingProcess()
        {
            VTBBranch.DoBankService();
            UpdateInterface();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DoBankingProcess();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (VTBBranch?.agents != null && VTBBranch.agents.Length > 0)
            {
                for (int i = 0; i < VTBBranch.agents.Length; i++)
                {
                    panel1.Controls.Remove(VTBBranch.agents[i].agentState);
                }
            }
        }
        private void initAgent(int N)
        {
            int initX = 18;
            int initY = 270;
            int agentHeight = 100;
            int agentWidth = 118;

            for (int i = 0; i < N; i++)
            {
                if (i == 5) { initX = 18; initY += agentHeight; }
                VTBBranch.agents[i].agentState = new PictureBox();
                VTBBranch.agents[i].agentState.Image = Properties.Resources.agentReady;
                VTBBranch.agents[i].agentState.Location = new System.Drawing.Point(initX, initY);
                VTBBranch.agents[i].agentState.SizeMode = PictureBoxSizeMode.StretchImage;
                VTBBranch.agents[i].agentState.Size = new System.Drawing.Size(90, 60);
                this.panel1.Controls.Add(VTBBranch.agents[i].agentState);
                initX += agentWidth;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (labelClientArrival.ForeColor == Color.Red)
            {
                labelClientArrival.ForeColor = Color.Transparent;
                timer2.Stop();
            }
            else if (labelClientArrival.ForeColor == Color.Transparent)
            {
                labelClientArrival.ForeColor = Color.Red;
            }
            //showAvailableAgents.Text = (VTBBranch.agents.Length - VTBBranch.busyAgents).ToString();
            UpdateInterface();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int StepX = VTBBranch.currentFreeAgent.agentState.Location.X - animation2.Location.X;
            int StepY = VTBBranch.currentFreeAgent.agentState.Location.Y - animation2.Location.Y;
            animation2.Visible = true;
            int newX, newY;
            if (Math.Abs(StepX) > 50) newX = animation2.Location.X + 50 * Math.Sign(StepX);
            else newX = animation2.Location.X + StepX;
            if (Math.Abs(StepY) > 50) newY = animation2.Location.Y + 50 * Math.Sign(StepY);
            else newY = animation2.Location.Y + StepY;
            animation2.Location = new Point(newX, newY);

            if (animation2.Location == VTBBranch.currentFreeAgent.agentState.Location)
            {
                animation2.Location = new Point(449, 135);
                animation2.Visible = false;
                VTBBranch.ChangeAgentState();
                timer4.Stop();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (VTBBranch.allAgentsBusy)
            {
                animation.Visible = true;
                int step = animation.Location.X + 30;
                animation.Location = new Point(step, 135);
                if (animation.Location.X > 449)
                {
                    //showClientsInQueue.Text = (VTBBranch.queue).ToString();
                    UpdateInterface();
                    animation.Location = new Point(64, 135);
                    animation.Visible = false;
                    timer3.Stop();
                }
            }
            else
            {
                int StepX = VTBBranch.currentFreeAgent.agentState.Location.X- animation.Location.X;
                int StepY = VTBBranch.currentFreeAgent.agentState.Location.Y- animation.Location.Y;
                animation.Visible = true;
                int newX, newY;
                if (Math.Abs(StepX) > 50) newX = animation.Location.X + 50 *Math.Sign(StepX);
                else newX = animation.Location.X + StepX;
                if (Math.Abs(StepY) > 50) newY = animation.Location.Y + 50 * Math.Sign(StepY);
                else newY = animation.Location.Y + StepY;
                animation.Location = new Point(newX,newY);
                
                if(animation.Location == VTBBranch.currentFreeAgent.agentState.Location)
                {
                    animation.Location = new Point(64, 135);
                    animation.Visible = false;
                    VTBBranch.ChangeAgentState();
                    timer3.Stop();
                }

            }
        }

    }

    class Agent
    {
        public Agent()
        {
            busy = false;
            timeWithClient = 0;

        }
        public bool busy;
        public PictureBox agentState;
        public double timeWithClient;
    }
    class BankModel
    {
        public BankModel(int N, Timer timerCA, Timer timerMovingCLient, Timer timerQueuing)
        {
            queue = 0;
            operatingTime = 0;
            busyAgents = 0;
            agents = new Agent[N];
            for (int i = 0; i < N; i++)
            {
                agents[i] = new Agent();
            }
            servedClients = 0;
            clientTimer = timerCA;
            movingClient = timerMovingCLient;
            queueToAgent = timerQueuing;
            clientArrival = EstimateTime(0.2);
            clientTimer.Start();
        }
        public double operatingTime;
        public int busyAgents;
        public int queue;
        public int servedClients;
        public double clientArrival;
        public Agent[] agents;
        private Timer clientTimer;
        private Timer movingClient;
        private Timer queueToAgent;
        public bool allAgentsBusy;
        public Agent currentFreeAgent;


        public void DoBankService()
        {
            //Шаг 3 Лекция 6
            bool clienComesSooner = true;
            double tempTime = clientArrival;
            ////Check if one agent is going to be free sooner than client arival 
            for (int i = 0; i < agents.Length; i++)
            {
                if ((clientArrival > agents[i].timeWithClient) && agents[i].busy)
                {
                    clienComesSooner = false; 
                    currentFreeAgent = agents[i];
                    tempTime = agents[i].timeWithClient;
                }
            }
            operatingTime = tempTime;
            //Шаг 4 Лекция 6
            //Queuing logic
            if (clienComesSooner)
            {
                if (busyAgents < agents.Length)
                {
                    for (int i = 0; i < agents.Length; i++)
                    {
                        if (!agents[i].busy)
                        {
                            allAgentsBusy = false;
                            currentFreeAgent = agents[i];
                            movingClient.Start();
                            //ChangeAgentState();
                            break;
                        }
                    }
                }
                else
                {
                    allAgentsBusy = true;
                    queue++;
                    movingClient.Start();
                }
                //Шаг 2 Лекция 6
                clientArrival = operatingTime + EstimateTime(0.2);
                clientTimer.Start();
                //
            }
            else
            {
                allAgentsBusy = false;
                busyAgents--;
                if (queue == 0)
                {
                    currentFreeAgent.busy = false;
                    currentFreeAgent.agentState.Image = Properties.Resources.agentReady;
                }
                else
                { 
                    queue--;
                    currentFreeAgent.agentState.Image = Properties.Resources.agentReady;
                    queueToAgent.Start();
                    currentFreeAgent.timeWithClient = operatingTime + EstimateTime(0.8);
                }
                servedClients++;
            }
        }
        public void ChangeAgentState()
        {

            currentFreeAgent.busy = true;
            currentFreeAgent.agentState.Image = Properties.Resources.agentBusy;
            busyAgents++;
            currentFreeAgent.timeWithClient = operatingTime + EstimateTime(0.8);
        }
        public double EstimateTime(double mean)
        {
            double dev = 0.2;

            Random rand = new Random(); //reuse this if you are generating many
            double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            return (mean + dev * randStdNormal); //random normal(mean,stdDev^2)
        }
    }
}
