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
    public partial class Form2 : Form
    {
        public delegate void Class1EventHandler(int index, int a, int b);

        public event Class1EventHandler OnPerhitungan;
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Penjumlahan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(txtNilaiA.Text);
            int NilaiB = int.Parse(txtNilaiB.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                OnPerhitungan(0, NilaiA, NilaiB);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                OnPerhitungan(1, NilaiA, NilaiB);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                OnPerhitungan(2, NilaiA, NilaiB);
            }
            else
            {
                OnPerhitungan(3, NilaiA, NilaiB);
            }
        }
    }
}
