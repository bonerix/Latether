
namespace Latether_message_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.messageBox.Location = new System.Drawing.Point(12, 357);
            this.messageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(704, 23);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "Type a message...";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            this.messageBox.Enter += new System.EventHandler(this.MessageBox_Enter);
            this.messageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterDown);
            this.messageBox.Leave += new System.EventHandler(this.MessageBox_Leave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 40);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(704, 313);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // usernameBox
            // 
            this.usernameBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usernameBox.Location = new System.Drawing.Point(12, 12);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(228, 23);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.Text = "Username";
            this.usernameBox.Enter += new System.EventHandler(this.UsernameBox_Enter);
            this.usernameBox.Leave += new System.EventHandler(this.UsernameBox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 391);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.messageBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox usernameBox;
    }
}

