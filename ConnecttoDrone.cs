using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
/*
//
//Class that handles the connection to the drone via server. 
//
*/

namespace Brain_Drone2
{
    public static class DroneConnection
    {
        public static string ipaddress = "127.0.0.1"; ///
        public static int portnumber = 6969;
        public static string command;
        public static string battery; 
        public static TcpClient client;
           
        public static void createconnection()  ///Connect to node server using a tcp connecion.  
        {
            try
            {
                client = new TcpClient();
                client.Connect(ipaddress, portnumber);
            }
            catch (SocketException )
            {
                MessageBox.Show("Could not connect to drone!");
                prcs_handler.flag = false;

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        public static void closeconnection()// Close  the connection. 
        {

            try
            {    
				client.Client.Disconnect(false); 
            }
            catch (SocketException)
            {
                MessageBox.Show("Already Disconnected.");

            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }
        public static void sendcommand()// Sending the commands to the drone through the node js server. 
        {
            
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(command);

            try
            {
                NetworkStream stream = client.GetStream();
                stream.Write(msg, 0, msg.Length);
            }
            catch (SocketException)
            {
                MessageBox.Show("Command cannot be sent.");
            }
            catch (Exception)
            {
                MessageBox.Show("Command cannot be sent."); 
            }
        }
        public static void receiveBatteryInfo()
        {// Receive the battery data from the node.js server.

                NetworkStream netStream= client.GetStream();
                byte[] bytes = new byte[client.ReceiveBufferSize];
                netStream.Read(bytes, 0, (int)client.ReceiveBufferSize);
                battery = Encoding.UTF8.GetString(bytes);
          
        }
    }
}