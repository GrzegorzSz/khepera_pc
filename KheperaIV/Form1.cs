using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace KheperaIV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            speedValueTextBox.Text = speedBar.Value.ToString();
        }
        
        public static class staticValues
        {
            public static Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            public static bool timer5sTick = false;
            public static byte[] byteMessage = new byte[20];
        }


        public bool connectWithServerSocket(string IPaddr, int port)
        {
            /*connect with server socket. Waiting for connection
             * within 5s. Return true if connection success or
             * false if connection failed*/

            bool connResult = false;

            staticValues.clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IAsyncResult result = staticValues.clientSocket.BeginConnect(IPaddr, port, null, null);
            connResult = result.AsyncWaitHandle.WaitOne(5000, false);
            Console.WriteLine("Connection result: {0}", connResult.ToString());
            return connResult;
        }

        public bool ipAddressIsValid(string address)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(address);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("IP addres validation: ArgumentNullException!");
                return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("IP address validation: FormatException!");
                return false;
            }
            
            return true;
        }

        public void connectionLost()
        {
            messageLabel.Text = "Connection lost!";
        }

        public void sendWithSocket(Socket socket, byte command)
        {
            byte[] message = new byte[20];
            message[0] = command;
            if (socket.Connected)
            {
                try
                {
                    socket.Send(message);
                }
                catch (SocketException e)
                {
                    connectButton_Click(this, new EventArgs());
                    connectionLost();
                }
            }
            else
            {
                connectionLost();
            }
        }

        public void sendWithSocket(Socket socket, string command, byte[] recBuff)
        {
            if (socket.Connected)
            {
                Array.Clear(recBuff, 0, recBuff.Length);
                socket.Send(UTF8Encoding.UTF8.GetBytes(command));
                socket.Receive(recBuff);
            }
            else
            {
                connectionLost();
            }
        }

        private Azimuth calculateAzimuth(Size scrSize, Point point)
        {
            double pathLength = Math.Sqrt(Math.Pow((point.X - scrSize.Width / 2), 2.0) + Math.Pow(scrSize.Height - point.Y, 2.0));
            double sinA = (point.X - scrSize.Width / 2) / pathLength;
            double angle = Math.Round(Math.Asin(sinA)*180/Math.PI, 2);
            Azimuth azimuth = new Azimuth((uint)Math.Round(pathLength, 0), angle);
            Console.WriteLine("Path len: {0}, angle: {1}", azimuth.Length, azimuth.Angle);
            return azimuth;
        }

        private void sendAzimuthToRobot(Azimuth azimuth)
        {
            byte[] buffer = new byte[6];
            Array.Clear(buffer, 0, buffer.Length);
            speedValueTextBox.Text = speedBar.Value.ToString();
            sendWithSocket(staticValues.clientSocket, "a" + azimuth.Length.ToString() + ";" + azimuth.Angle.ToString(), buffer);
        }

        public void startVlcPlayer(string streamAddress)
        {
            Console.WriteLine(streamAddress);
            axVLCPlugin21.playlist.add(streamAddress);
            axVLCPlugin21.playlist.play();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (staticValues.clientSocket.Connected)
            {
                staticValues.clientSocket.Close();
                connectButton.Text = "Connect";
                axVLCPlugin21.playlist.stop_async();
                controlsPanel.Visible = false;
                messageLabel.Text = "Disconnected.";
                return;
            }

            byte[] recBuffer = new byte[1024];
            int port;
            string IPAddr = (IPAddressBox.Text.ToString()).Replace(',', '.').Replace(" ", "").Replace("000", "0").Replace(".00", ".").Replace(".0", ".").Replace("..", ".0.");
            
            Int32.TryParse(portBox.Text.ToString(), out port);
            messageLabel.Text = "Connecting to " + IPAddr;
            Console.WriteLine("Address IP: " + IPAddr);
            Console.WriteLine("Port: " + port);
            if (!ipAddressIsValid(IPAddr) || !Int32.TryParse(portBox.Text.ToString(), out port))
            {
                messageLabel.Text = "Connecting failed.\nIP address or port number is not valid";
                return;
            }

            if(connectWithServerSocket(IPAddr, port) && staticValues.clientSocket.Connected)
            {
                controlsPanel.Visible = true;
                messageLabel.Text = "Connected.\n";
                connectButton.Text = "Disconnect";

                //staticValues.clientSocket.Send(UTF8Encoding.UTF8.GetBytes("Test połączenia OK"));
                //staticValues.clientSocket.Receive(recBuffer);
                sendWithSocket(staticValues.clientSocket, "Test", recBuffer);
                if(recBuffer.Length > 0)
                {
                    messageLabel.Text += (UTF8Encoding.UTF8.GetString(recBuffer));
                }

                //startVlcPlayer("http://" + IPAddr + ":8080/webcam");
                startVlcPlayer("http://" + IPAddr + ":8080/?action=stream");
                //staticValues.clientSocket.Send(UTF8Encoding.UTF8.GetBytes("a"));
                //staticValues.clientSocket.Receive(recBuffer);
                //messageLabel.Text = UTF8Encoding.UTF8.GetString(recBuffer);
                //axWindowsMediaPlayer1.URL = "http://192.168.0.254:8090/webcam.asf";
                //axWindowsMediaPlayer1.URL = "http://" + IPAddr + ":8080/?action=stream";

            }
            else
            {
                connectButton.Text = "Connect";
                messageLabel.Text = "Connection failed!";
            }
        }


        private void IPAddressBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void IPAddressBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void portBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void portBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                connectButton_Click(this, new EventArgs());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staticValues.timer5sTick = true;
            Console.WriteLine("After 5s");
        }

        private void IPAddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectButton_Click(this, new EventArgs());
            }
        }

        private void controlButtonUp_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            sendWithSocket(staticValues.clientSocket, 65);
        }

        private void controlButtonDown_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            sendWithSocket(staticValues.clientSocket, 66);
        }

        private void controlButtonLeft_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            sendWithSocket(staticValues.clientSocket, 68);
        }

        private void controlButtonRight_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            sendWithSocket(staticValues.clientSocket, 67);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData){
                case Keys.Up:
                    controlButtonUp_Click(this, new EventArgs());
                    break;
                case Keys.Down:
                    controlButtonDown_Click(this, new EventArgs());
                    break;
                case Keys.Left:
                    controlButtonLeft_Click(this, new EventArgs());
                    break;
                case Keys.Right:
                    controlButtonRight_Click(this, new EventArgs());
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void speedBar_ValueChanged(object sender, EventArgs e)
        {
            byte[] buffer = new byte[6];
            Array.Clear(buffer, 0, buffer.Length);
            speedValueTextBox.Text = speedBar.Value.ToString();
            sendWithSocket(staticValues.clientSocket, "s" + speedBar.Value.ToString(), buffer);
        }

        private void controlButtonUp_MouseDown(object sender, MouseEventArgs e)
        {
            controlButtonUp_Click(this, new EventArgs());
        }

        private void transparentPanel1_Paint(object sender, PaintEventArgs e)
        {
            transparentPanel1.Location = axVLCPlugin21.Location;
            transparentPanel1.Size = axVLCPlugin21.Size;
            transparentPanel1.BringToFront();
        }

        private void transparentPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine(transparentPanel1.PointToClient(Cursor.Position).ToString());
            Azimuth azimuth = calculateAzimuth(transparentPanel1.Size, transparentPanel1.PointToClient(Cursor.Position));
            sendAzimuthToRobot(azimuth);
        }

        private void pathDrvBtn_Click(object sender, EventArgs e)
        {
            PathDriveForm pd = new PathDriveForm(this, staticValues.clientSocket);
            pd.Show();
        }
    }
}
