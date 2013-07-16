using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JDOPClients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Third client = new Third();
            client.Show();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            First client = new First();
            client.Show();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Second client = new Second();
            client.Show();
            button2.Enabled = false;
        }
    }
}
