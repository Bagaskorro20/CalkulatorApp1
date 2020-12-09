using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalkulatorApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_OnPerhitungan(int index, int a, int b)
        {
            var Hitung = new Class1();

            if(index == 0)
            {
                Hasile.Items.Add(string.Format("Hasil Penjumlahan : {0} + {1} = {2}", a, b, Hitung.Penjumlahan(a, b)));
            }
            else if(index == 1)
            {
                Hasile.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, Hitung.Pengurangan(a, b)));
            }
            else if(index == 2)
            {
                Hasile.Items.Add(string.Format("Hasil Perkalian : {0} * {1} = {2}", a, b, Hitung.Perkalian(a, b)));
            }
            else
            {
                Hasile.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, Hitung.Pembagian(a, b)));
            }

            private void btnHitung_Click(object sender, EventArgs e)
            {
                Form2 myForm = new Form2();

                myForm.OnPerhitungan += Form1_OnPerhitungan;
                myForm.ShowDialog();
            }

        }
    }
}
