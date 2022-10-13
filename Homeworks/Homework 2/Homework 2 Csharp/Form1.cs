using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_2_Csharp
{
    public partial class Form1 : Form
    {
        public Double sum;
        public Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sum += r.NextDouble();
            this.richTextBox1.AppendText("\n" + r.NextDouble());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }
    }
}
