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
    public partial class First : Form
    {
        Comm client1 = new Comm();
        public First()
        {
            InitializeComponent();
        }

        private void First_Load(object sender, EventArgs e)
        {
            client1.connect(Client1Textbox, client1labl);

        }

        private void CLient1Butn_Click(object sender, EventArgs e)
        {
            client1.communicate(client1combo.Text, Client1Textbox);
        }
    }
}
