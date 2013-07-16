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
    public partial class Third : Form
    {
        Comm client3 = new Comm();


        public Third()
        {
            InitializeComponent();
        }

        private void Third_Load(object sender, EventArgs e)
        {
            client3.connect(client3Textbox, Client3Labl);
        }

        private void Client3btn_Click(object sender, EventArgs e)
        {
            client3.communicate(client3combo.Text, client3Textbox);
        }
    }
}
