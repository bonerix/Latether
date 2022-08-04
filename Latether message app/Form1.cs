using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Latether_message_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MessageBox_Enter(object sender, EventArgs e)
        {
            if (messageBox.Text == "Type a message...")
            {
                messageBox.Text = "";
                messageBox.ForeColor = SystemColors.ControlText;
            } 
        }

        private void MessageBox_Leave(object sender, EventArgs e)
        {
            if (messageBox.Text == "")
            {
                messageBox.Text = "Type a message...";
                messageBox.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    s.Connect(IPAddress.Parse("192.168.1.61"), 42069);
                    byte[] data = Encoding.Default.GetBytes(usernameBox.Text + ": " + messageBox.Text);
                    s.Send(data);
                    s.Disconnect(false);
                }
                catch
                {
                    MessageBox.Show("No connection.", "BRUH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UsernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Username")
            {
                usernameBox.Text = "";
                usernameBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {
                usernameBox.Text = "Username";
                usernameBox.ForeColor = SystemColors.WindowFrame;
            }
        }
    }
}
