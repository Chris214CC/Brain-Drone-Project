using System;
using System.ComponentModel;
using System.Windows.Forms;
using Emotiv;
using System.Diagnostics;

/// <summary>
/// Emotiv old version: 3.0.0
/// </summary>

namespace Brain_Drone2
{
    public partial class MainWindow : Form
    {
        EmoEngine engine = EmoEngine.Instance;// Access to the EDK is viaa the EmoEngine
        static uint userId = 0; // userID is used to uniquely identify a user's headset
        static System.IO.StreamWriter engineLog = new System.IO.StreamWriter("engineLog.log");
        static System.IO.StreamWriter expLog = new System.IO.StreamWriter("expLog.log");
        static System.IO.StreamWriter cogLog = new System.IO.StreamWriter("cogLog_chr.log");
        static System.IO.StreamWriter affLog = new System.IO.StreamWriter("affLog.log");

        static Boolean takeoff_bool = false;
        static Int32 takeoff_count = 0;
        static Int32 forward_count = 0;
        static Int32 left_count = 0;
        static Int32 right_count = 0;
       static Stopwatch stopwatch = new Stopwatch();


        public MainWindow()
        {
            InitializeComponent();       

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventHandler()
        {
            engine.ProcessEvents();              

        }
        private void toHeadsetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            engine.EmoEngineDisconnected +=
               new EmoEngine.EmoEngineDisconnectedEventHandler(engine_EmoEngineDisconnected);
            engine.UserAdded +=
                new EmoEngine.UserAddedEventHandler(engine_UserAdded);
            engine.UserRemoved +=
                new EmoEngine.UserRemovedEventHandler(engine_UserRemoved);
            engine.EmoStateUpdated +=
                new EmoEngine.EmoStateUpdatedEventHandler(engine_EmoStateUpdated);
            //engine.ExpressivEmoStateUpdated +=
            //    new EmoEngine.ExpressivEmoStateUpdatedEventHandler(engine_ExpressivEmoStateUpdated);
            engine.CognitivEmoStateUpdated +=
                new EmoEngine.CognitivEmoStateUpdatedEventHandler(engine_CognitivEmoStateUpdated);
            //engine.AffectivEmoStateUpdated +=
            //    new EmoEngine.AffectivEmoStateUpdatedEventHandler(engine_AffectivEmoStateUpdated);
            engine.EmoEngineEmoStateUpdated +=
                new EmoEngine.EmoEngineEmoStateUpdatedEventHandler(engine_EmoEngineEmoStateUpdated);
            engine.CognitivTrainingStarted +=
                new EmoEngine.CognitivTrainingStartedEventEventHandler(engine_CognitivTrainingStarted);
            engine.CognitivTrainingSucceeded +=
                new EmoEngine.CognitivTrainingSucceededEventHandler(engine_CognitivTrainingSucceeded);
            engine.CognitivTrainingCompleted +=
                new EmoEngine.CognitivTrainingCompletedEventHandler(engine_CognitivTrainingCompleted);
            engine.CognitivTrainingRejected +=
                new EmoEngine.CognitivTrainingRejectedEventHandler(engine_CognitivTrainingRejected);
           

            //engine.Connect();
            //EmoEngine.Instance.RemoteConnect("127.0.0.1", 1726);
            EmoEngine.Instance.RemoteConnect("127.0.0.1", 3008);

            timer1.Start();
        }

        static void engine_EmoEngineConnected(object sender, EmoEngineEventArgs e)
        {
            MessageBox.Show("Connected");

        }
        static void engine_EmoEngineDisconnected(object sender, EmoEngineEventArgs e)
        {
            MessageBox.Show("disconnected");
        }
        static void engine_UserAdded(object sender, EmoEngineEventArgs e)
        {
            MessageBox.Show("user added (" + e.userId + ")");
            userId = e.userId;

        }
        static void engine_UserRemoved(object sender, EmoEngineEventArgs e)
        {
            MessageBox.Show("user removed");
        }
        private void engine_EmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
        {
            EmoState es = e.emoState;

            Single timeFromStart = es.GetTimeFromStart();
            


        }
        private void engine_EmoEngineEmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
        {

            EmoState es = e.emoState;

            Single timeFromStart = es.GetTimeFromStart();

            Int32 headsetOn = es.GetHeadsetOn();

            EdkDll.EE_SignalStrength_t signalStrength = es.GetWirelessSignalStatus();
            
            Int32 chargeLevel = 0;
            Int32 maxChargeLevel = 0;
            es.GetBatteryChargeLevel(out chargeLevel, out maxChargeLevel);
            textBox2.Text = chargeLevel.ToString() + '/' + maxChargeLevel.ToString();
            // HT_Signalstrt.Text = signalStrength.ToString(); 

            engineLog.Write(
                "{0},{1},{2},{3},{4},",
                timeFromStart,
                headsetOn, signalStrength, chargeLevel, maxChargeLevel);


            engineLog.WriteLine("");
            engineLog.Flush();
        }
        
        static void count_clear(string command)
        {
            //clearing the count
            switch (command)
            {
                case "f":
                    forward_count = 0;
                    break;
                case "t":
                    takeoff_count = 0;
                    break;
                case "tf":
                    forward_count = 0;
                    takeoff_count = 0;
                    break;
                default:
                    break;
            }
        }
        static void xy_cordinate(int x, int y)
        {
            //calcualte the x y cordinate and based on that cordinate pass command to the drone
            FlightWindow outer = new FlightWindow();
            if (x < -6)
            {
                //turning left
                if (left_count % 4 == 0)
                {
                    outer.manualLeft();                    
                  
                }
                left_count++;

            }
            else if (x > 6)
            {
                if (right_count % 4 == 0)
                {
                    outer.manualright();
                }
                right_count++;
            }


        }
        private void engine_CognitivEmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
        {
            EmoState es = e.emoState;
            FlightWindow outer = new FlightWindow();
            Single timeFromStart = es.GetTimeFromStart();
            Single power = es.CognitivGetCurrentActionPower(); // get power
            EdkDll.EE_CognitivAction_t cogAction = es.CognitivGetCurrentAction(); // get detected command

            Boolean isActive = es.CognitivIsActive();
            textBox1.Text = "Action:" + cogAction.ToString() + "|" + "Power" + power;
            switch (cogAction)
            {                                 
                case EdkDll.EE_CognitivAction_t.COG_NEUTRAL:
                    {
                        count_clear("tf");
                        outer.manualHover();   //forcing manula hovering.
                        break;
                    }
                case EdkDll.EE_CognitivAction_t.COG_PUSH:
                    {
                        count_clear("tf");                      
                        outer.button1_Click(sender, e);        // forward command               
                        break;
                    }
                case EdkDll.EE_CognitivAction_t.COG_PULL:
                    {
                        count_clear("t");
                        if (forward_count % 2 == 0)
                        {                            
                            outer.Backwards_Click(sender, e);      // forwad backward
                        }
                        forward_count++;
                        
                        break;
                    }
                case EdkDll.EE_CognitivAction_t.COG_LIFT:
                    {
                        // if (takeoff_bool == false)
                        // {
                        if (takeoff_count % 3 == 0)
                        {
                            outer.Takeoff_Click(sender, e);     // takeoff
                           
                        }
                            
                            //takeoff_bool = true;

                        //}
                        //else
                        //{
                        //    // already take off so rotate
                        //    if (takeoff_count % 2 == 0)
                        //    {
                        //        outer.button7_Click(sender, e); /// more up
                        //    }
                         takeoff_count++;
                        //}
                        count_clear("f");
                       
                        break;
                    }
                case EdkDll.EE_CognitivAction_t.COG_DROP:
                    {
                        outer.Landing_Click(sender, e);  // landing 
                        count_clear("tf");
                        takeoff_bool = false;                        
                        break;
                    }               
            }           
            
           
           // Console.Write("{0}", cogAction);
            cogLog.WriteLine("{0},{1},{2},{3}",timeFromStart,cogAction, power, isActive);   // writing to log file 
            cogLog.Flush();
        }
        static void engine_CognitivTrainingStarted(object sender, EmoEngineEventArgs e)
        {
            MessageBox.Show("Start Cognitiv Training");
        }
        private void engine_CognitivTrainingSucceeded(object sender, EmoEngineEventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Cognitiv Training Success. Accept/Reject?", "Cognitiv Training", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Accept!");
                engine.CognitivSetTrainingControl(0, EdkDll.EE_CognitivTrainingControl_t.COG_ACCEPT);
            }
            else
            {              
                    engine.CognitivSetTrainingControl(0, EdkDll.EE_CognitivTrainingControl_t.COG_ACCEPT);              
               
            }
        }
        static void engine_CognitivTrainingRejected(object sender, EmoEngineEventArgs e)
        {
            MessageBox.Show("Cognitiv Training Rejected.");
        }
        static void engine_CognitivTrainingCompleted(object sender, EmoEngineEventArgs e)
        {
            MessageBox.Show("Cognitiv Training Completed.");
        }

        private void toDroneToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (prcs_handler.flag == false)
            {
                prcs_handler.start_prcs();
                prcs_handler.check();
                DroneConnection.createconnection();               
            }
            else
            {
                MessageBox.Show("Already connected");
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aRDroneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emotivToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightWindow frm = new FlightWindow();
            frm.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DroneConnection.closeconnection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            eventHandler();                      
            stopwatch.Start();
        }



        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Signal_To_Drone_lbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void HT_Signalstrt_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
