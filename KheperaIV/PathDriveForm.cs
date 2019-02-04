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

namespace KheperaIV
{
    public partial class PathDriveForm : Form
    {
        public PathDriveForm(Form1 mainForm, Socket socket)
        {
            InitializeComponent();
            staticValues.mainForm = mainForm;
            staticValues.socket = socket;
        }

        public static class staticValues
        {
            public static Form1 mainForm;
            public static Socket socket;
        }

        private bool validateTextBox(string text)
        {
            int result;
            return int.TryParse(text, out result);
        }

        private string buildCommandString()
        {
            string command = "";
            if (roundDrvRadioBtn.Checked)
            {
                if (validateTextBox(roundDrvTextBox.Text))
                {
                    command += "r" + roundDrvTextBox.Text;
                }
            }
            if (squareDrvRadioBtn.Checked)
            {
                if (validateTextBox(squareDrvTextBox.Text))
                {
                    command += "p" + squareDrvTextBox.Text + ";0";
                }
            }
            if (triactDrvRadioBtn.Checked)
            {
                if (validateTextBox(triactDrvTextBox.Text))
                {
                    command += "p" + triactDrvTextBox.Text + ";0";
                }
            }
            return command;
        }

        private void drivePath(string firstCommand, Socket socket)
        {
            string secCommand = "";
            string endPathDrvMessage = "travel_completed";
            string incomingMsg = "";
            int sideCounter = 0;
            byte[] recBuffer = new byte[20];

            Array.Clear(recBuffer, 0, recBuffer.Length);

            if (squareDrvRadioBtn.Checked)
            {
                Console.WriteLine("square....");
                secCommand = "p0;90";
                sideCounter = 4;
                
            } else if (triactDrvRadioBtn.Checked) {
                Console.WriteLine("triactangle");
                sideCounter = 3;
            } else
            {
                Console.WriteLine("Round. counter = 1");
                secCommand = "p0;0";
                sideCounter = 1;
            }

            for (int count = 0; count < sideCounter; count++)
            {
                Array.Clear(recBuffer, 0, recBuffer.Length);
                Console.WriteLine("buff cleared.");
                staticValues.mainForm.sendWithSocket(socket, firstCommand, recBuffer);
                socket.Receive(recBuffer);
                incomingMsg = UTF8Encoding.UTF8.GetString(recBuffer);
                Console.WriteLine("received from robot: {0}", incomingMsg);
                if(endPathDrvMessage.Equals("travel_completed"))
                {
                    Console.Write("-");
                }
                System.Threading.Thread.Sleep(1500);
                staticValues.mainForm.sendWithSocket(socket, secCommand, recBuffer);
                incomingMsg = "";
                socket.Receive(recBuffer);
                incomingMsg = UTF8Encoding.UTF8.GetString(recBuffer);

                System.Threading.Thread.Sleep(1500);
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            string command = buildCommandString();
            if(command.Length > 0)
            {
                drivePath(command, staticValues.socket);
            }
        }
    }
}
