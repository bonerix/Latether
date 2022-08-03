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

namespace Latether_message_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputBox_Enter(object sender, EventArgs e)
        {
            if (inputBox.Text == "Type a message...")
            {
                inputBox.Text = "";
                inputBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void InputBox_Leave(object sender, EventArgs e)
        {
            if (inputBox.Text == "")
            {
                inputBox.Text = "Type a message...";
                inputBox.ForeColor = SystemColors.WindowFrame;
            }
        }
    }
}
