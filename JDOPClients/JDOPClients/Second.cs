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
    public partial class Second : Form
    {
        Comm client2 = new Comm();
        public Second()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client2.communicate(Client2Combo.Text, Client2Textbox);

        }

        private void Second_Load(object sender, EventArgs e)
        {
            client2.connect(Client2Textbox,Client2Labl);
        }
    }
}
