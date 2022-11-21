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
        public bool scelta;
        private prodotto[] prodotti = new prodotto[100];
        private carrello carrello = new carrello("69");
        private prodotto prodotto1 = new prodotto("igds324","occhiali","logitech","occhiali succulenti");
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double prezzofinale = 0;
            MessageBox.Show($"{prezzofinale}" + "$");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            carrello.Aggiungi(prodotto1);
            listView1.Items.Add(prodotto1.Nome);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            carrello.Rimuovi(prodotto1);
            label1.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }
    }
}