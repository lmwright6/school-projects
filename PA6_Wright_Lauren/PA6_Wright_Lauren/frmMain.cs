using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//Lauren Wright MIS220-001

namespace PA6_Wright_Lauren
{
    public partial class frmMain : Form
    {

        private Robot robot;

        private void frmMain_Load(object sender, EventArgs e)
        {
            robot = new Robot();
            robot.Crash += new EventHandler(CrashHandler);
            lblPosition.Text = robot.Position.ToString();
            lblRobot.Text = Convert.ToChar(233).ToString();

        }

        public frmMain()
        {
            InitializeComponent();
           
        }

        private void WBtn_Click(object sender, EventArgs e)
        {
            
            robot.Direction = RobotDirection.W;
            lblRobot.Text = Convert.ToChar(231).ToString();  // Left arrow
            MySpecialListBox.Items.Add("RobotDirection.W");

          
        }

        private void NBtn_Click(object sender, EventArgs e)
        {
            robot.Direction = RobotDirection.N;
            lblRobot.Text = Convert.ToChar(233).ToString();  // Up arrow

                MySpecialListBox.Items.Add("RobotDirection.N");
            
        }

        private void SBtn_Click(object sender, EventArgs e)
        {

            robot.Direction = RobotDirection.S;
            lblRobot.Text = Convert.ToChar(234).ToString();  // Down arrow
           
                MySpecialListBox.Items.Add("RobotDirection.S");
            
        }

        private void EBtn_Click(object sender, EventArgs e)
        {
            robot.Direction = RobotDirection.E;
            lblRobot.Text = Convert.ToChar(232).ToString();  // Right arrow
            
                MySpecialListBox.Items.Add("RobotDirection.E");
            
        }

        private void Go1Btn_Click(object sender, EventArgs e)
        {
            this.MoveRobot(1);

           
                MySpecialListBox.Items.Add("MoveRobot(1)");
            
        }

        private void Go10Btn_Click(object sender, EventArgs e)
        {
            this.MoveRobot(10);
            MySpecialListBox.Items.Add("MoveRobot(10)");
            
        }

        private void MoveRobot(int units)
        {
            
            robot.Go(units);
            Point rp = robot.Position;
            lblRobot.Location = new Point(rp.X + 100, -rp.Y + 100);
            lblPosition.Text = rp.ToString();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            RobotProgBar.Value = 0;

            if (PlayBtn.Text == "Stop")
            {
                PlayBtn.Text = "Play";
                instructionTimer.Enabled = false;
                Go10Btn.Enabled = true;
                Go1Btn.Enabled = true;
                NBtn.Enabled = true;
                SBtn.Enabled = true;
                EBtn.Enabled = true;
                WBtn.Enabled = true;
            }
            else
            {
                
                MySpecialListBox.SelectedIndex = 0;
                instructionTimer.Enabled = true;
                PlayBtn.Text = "Stop";
                Go10Btn.Enabled = false;
                Go1Btn.Enabled = false;
                NBtn.Enabled = false;
                SBtn.Enabled = false;
                EBtn.Enabled = false;
                WBtn.Enabled = false;
                

            }

        }

        private void CrashHandler(object sender, EventArgs e)
        {
            instructionTimer.Enabled = false;
            MessageBox.Show("Crash!");
            
        }

       

      
        private void instructionTimer_Tick(object sender, EventArgs e)
        {
            string command = MySpecialListBox.GetItemText(MySpecialListBox.SelectedItem);
            doWork(command);
            RobotProgBar.Maximum = MySpecialListBox.Items.Count;
            RobotProgBar.Value++;
            
            if(MySpecialListBox.Items.Count -1 <= MySpecialListBox.SelectedIndex)
            {

                if (LoopCheckBox.Checked == false)
                {

                    instructionTimer.Enabled = false;
                    MessageBox.Show("Tracking complete");
                    PlayBtn.Text = "Play";
                    Go10Btn.Enabled = true;
                    Go1Btn.Enabled = true;
                    NBtn.Enabled = true;
                    SBtn.Enabled = true;
                    EBtn.Enabled = true;
                    WBtn.Enabled = true;
                }
                else
                {
                    MySpecialListBox.SelectedIndex = 0;
                    RobotProgBar.Value = 0;
                }
            }

            else{
                MySpecialListBox.SelectedIndex++;
            }

        }

        private void doWork(string command)
        {
            if (command  == "RobotDirection.N")
            {
                robot.Direction = RobotDirection.N;
                lblRobot.Text = Convert.ToChar(233).ToString();  // Up arrow
            }
            else if (command == "RobotDirection.E")
            {
                robot.Direction = RobotDirection.E;
                lblRobot.Text = Convert.ToChar(232).ToString();  // Up arrow
            }
            else if (command == "RobotDirection.S")
            {
                robot.Direction = RobotDirection.S;
                lblRobot.Text = Convert.ToChar(234).ToString(); 
            }
            else if (command == "RobotDirection.W")
            {
                robot.Direction = RobotDirection.W;
                lblRobot.Text = Convert.ToChar(231).ToString();
            }
            else if (command  == "MoveRobot(1)")
            {
                this.MoveRobot(1);
            }
            else if (command == "MoveRobot(10)")
            {
                this.MoveRobot(10);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            robot = new Robot();
            Point rp = robot.Position;
            lblRobot.Location = new Point(100, 100);
            lblPosition.Text = rp.ToString();
            robot.Direction = RobotDirection.N;
            lblRobot.Text = Convert.ToChar(233).ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            robot = new Robot();
            ResetBtn.PerformClick();
            MySpecialListBox.Items.Clear();
            robot.Direction = RobotDirection.N;
            MySpecialListBox.Items.Add("RobotDirection.N");
        }

        private void DataFillBtn_Click(object sender, EventArgs e)
        {
            MySpecialListBox.Items.Add("RobotDirection.N");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("RobotDirection.E");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("RobotDirection.S");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("RobotDirection.W");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
            MySpecialListBox.Items.Add("MoveRobot(10)");
           
        }
    }
}
