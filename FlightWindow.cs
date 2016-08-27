using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Brain_Drone2
{
    public partial class FlightWindow : Form
    {
        private Thread trd;

        public FlightWindow()
        {
            InitializeComponent();
            if (prcs_handler.flag == true)
            {
                this.trd = new Thread(new ThreadStart(this.ThreadTask));// Thread to get battery info. 
                trd.IsBackground = true;
                try {
                    trd.Start();
                } catch (OutOfMemoryException e)
                {
                    MessageBox.Show("Exception: " + e.ToString());
                }
            }
        }
     
        private void ThreadTask()
        {
            while (true)
            {
                DroneConnection.receiveBatteryInfo();
                this.SetText(DroneConnection.battery);
            }
        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Actual_Battery_Per.InvokeRequired) {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else{
                this.Actual_Battery_Per.Text = text;
            }
            
        }
        private void Keypress_KeyDown(object sender, KeyEventArgs e)
        {
        // Allows for the user to use keyboard
           switch (e.KeyCode)
            {
                case Keys.W:
                    button1_Click(sender, e);                   
                    break;
                case Keys.A:
                    ClockwiseLeft_Click(sender, e);
                    break;
                case Keys.D:
                    button10_Click(sender, e);
                    break;
                case Keys.S:
                    Backwards_Click(sender, e);
                    break;
                case Keys.Q:
                    Left_Click(sender, e);
                    break;
                case Keys.E:
                    RightButton_Click(sender, e);
                    break;
                case Keys.T:
                    button7_Click(sender, e);
                    break;
                case Keys.G:
                    Down_Click(sender, e);
                    break;
                case Keys.V:
                    Takeoff_Click(sender, e);
                    break;
                case Keys.C:
                    Landing_Click(sender, e);
                    break;
            }
        }
   /*The below code sends commands to the server program made in node js.*/
        public void button1_Click(object sender, EventArgs e)// Forward
        {           
                DroneConnection.command = "Forward";
                DroneConnection.sendcommand();
        }

        public void button7_Click(object sender, EventArgs e)//Up
        {
                DroneConnection.command = "Up";
                DroneConnection.sendcommand(); 
        }
        public void button10_Click(object sender, EventArgs e)// ClockwiseRight
        {
                DroneConnection.command = "TurnRight";
                DroneConnection.sendcommand();
        }
        public void Down_Click(object sender, EventArgs e)
        {
                DroneConnection.command = "Down";
                DroneConnection.sendcommand();
        }

        public void Left_Click(object sender, EventArgs e)
        {
                DroneConnection.command = "Left";
                DroneConnection.sendcommand();
        }

        public void ClockwiseLeft_Click(object sender, EventArgs e)
        {
                DroneConnection.command = "TurnLeft";
                DroneConnection.sendcommand();
        }

        public void Takeoff_Click(object sender, EventArgs e)
        {
                DroneConnection.command = "Takeoff";
                DroneConnection.sendcommand();
        }

        public void Backwards_Click(object sender, EventArgs e)
        {
                DroneConnection.command = "Backward";
                DroneConnection.sendcommand();
        }

        public void Landing_Click(object sender, EventArgs e)
        {
                DroneConnection.command = "Land";
                DroneConnection.sendcommand();

        }

        public void RightButton_Click(object sender, EventArgs e)
        {
                DroneConnection.command = "Right";
                DroneConnection.sendcommand();

        }

        private void Off_Click(object sender, EventArgs e)//Connect/Disconnect button
        {          
            if (prcs_handler.flag == false)
            {
                prcs_handler.start_prcs();
                prcs_handler.check();
                DroneConnection.createconnection();
                Thread.Sleep(6000);
                pictureBox1.Load(@"http://localhost:8080/");
                timer1.Start();
                this.trd = new Thread(new ThreadStart(this.ThreadTask));
                trd.IsBackground = true;
                trd.Start();
                Off.Text = "Connected";   
            }

            else
            {
                DroneConnection.closeconnection();
                prcs_handler.stop_prcs();
                trd.Abort();
                timer1.Stop(); 
                Off.Text = "Disconnected";
            }
        }

        public void manualHover()
        {
            DroneConnection.command = "Neutral";
            DroneConnection.sendcommand();
        }
        public void manualontrol_land()
        {
            DroneConnection.command = "Land";
            DroneConnection.sendcommand();
        }
        public void manualontrol_takeoff()
        {
            DroneConnection.command = "Takeoff";
            DroneConnection.sendcommand();
        }
        public void manualLeft()
        {
            DroneConnection.command = "Left";
            DroneConnection.sendcommand();
        }
        public void manualright()
        {
            DroneConnection.command = "Right";
            DroneConnection.sendcommand();
        }
        public void manualup()//Up
        {
            DroneConnection.command = "Up";
            DroneConnection.sendcommand();
        }

        private void Battery_percentage_Click(object sender, EventArgs e)
        {
           
        }

        private void Actual_Battery_Per_TextChanged(object sender, EventArgs e)
        {
            
        }         
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Load(@"http://localhost:8080/");
            // Video stream from the drone is provide via png's
            //that are constantly reloaded to the picture box. 
                                        
        }
        private void DroneSig_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
