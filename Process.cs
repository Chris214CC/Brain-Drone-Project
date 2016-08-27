using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Brain_Drone2
{
    public static class prcs_handler
{ 
       static Process cmd;
       public static bool flag = false;

       public static void start_prcs() // Starts the node.js server using the command prompt.
        {
            try
            {
                cmd = new Process();
                cmd.StartInfo.FileName = @"cmd.exe";
                cmd.StartInfo.Arguments = @"/k node server.js";
                cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                cmd.Start();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString()); 
            }
        }
        public static void stop_prcs() // Stops the node server by closing the command prompt. 
        {
            try
            {
                flag = false; 
                cmd.CloseMainWindow();
                cmd.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Already Disconnected!"); 
            }
        }
        public static void check()// Check if the command prompt is running. If it is flag = true means that the process has started. 
        {
            Process[] pname = Process.GetProcessesByName("cmd.exe");
            if (pname.Length == 0)
            {
                flag = true;
            }
        }
    }
 
}
