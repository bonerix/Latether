using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

			Thread thr1= new Thread(Recieve);
			thr1.Start();
		}

		static byte[] data;
		static Socket socket;

		private void Recieve()
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.98"), 42069));
			
			//Recieving from server
			socket.Listen(1);
			Socket accepteddata = socket.Accept();
			data = new byte[accepteddata.SendBufferSize];
			int j = accepteddata.Receive(data);
			richTextBox1.Text += Encoding.Default.GetString(data) + "\n";
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

		private void MessageBoxKeyDown(object sender, KeyEventArgs e)
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
					messageBox.Text = "";
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
