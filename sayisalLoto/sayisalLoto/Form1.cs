using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        public void karsilastir(string a,string b, TextBox txt)
        {
            if (b.Equals(a))
            {
                txt.BackColor = Color.Green;
            }
            else
                txt.BackColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi1.Text = rnd.Next(1, 4).ToString();
            sayi2.Text = rnd.Next(1, 4).ToString();
            sayi3.Text = rnd.Next(1, 4).ToString();
            karsilastir(sayi1.Text, rnd1.ToString(), rnd1);
            karsilastir(sayi2.Text, rnd2.ToString(), rnd2);
            karsilastir(sayi3.Text, rnd3.ToString(), rnd3);
        }
    }
}
