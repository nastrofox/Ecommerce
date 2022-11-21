using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce
{
    public partial class conferma : Form
    {
        public conferma()
        {
            InitializeComponent();
        }
        public bool scelta;
        private void button1_Click(object sender, EventArgs e)
        {
            scelta = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scelta = false;
        }
    }
}
