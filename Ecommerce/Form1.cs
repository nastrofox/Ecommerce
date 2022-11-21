using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Ecommerce
{
    public partial class Form1 : Form
    {
        private prodotto[] prodotti = new prodotto[100];
        private carrello carrello = new carrello("69");
        private prodotto prodotto1 = new prodotto("igds324","occhiali","logitech","occhiali succulenti");
        public Form1()
        {
            InitializeComponent();
        }
        double prezzofinale = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{prezzofinale}" + "$");
            prezzofinale = 0;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            carrello.Aggiungi(prodotto1);
            listView1.Items.Add(prodotto1.Nome);
        }
    }
}