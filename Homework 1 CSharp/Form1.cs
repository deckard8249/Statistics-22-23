using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Homework_1_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Hello, this is a button";
            richTextBox1.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                this.button3.Text = "DONE";
                this.button3.BackColor = Color.Green;
                button3.Enabled = false;
            }
            else
            {
                this.button3.Text = "KEEP GOING";
                
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox1.BackColor= Color.Red;
        }
    }
}
