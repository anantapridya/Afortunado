using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TenantMonet
{
    public partial class InputKendaraan : Form
    {
        public InputKendaraan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            tbMerek.Text = "";
            tbPlatNomor.Text = "";
            tbHarga.Text = "0";
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbMerek.Text == "" || tbPlatNomor.Text == "" || tbHarga.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                Vehicles tambah = new Vehicles();
                tambah.Type = tbMerek.Text;
                tambah.ID = tbPlatNomor.Text;
                tambah.Price = Convert.ToInt32(tbHarga.Text);
                tambah.inputkendaraan(tambah.Type, tambah.ID, tambah.Price);
                Clear();
                MessageBox.Show("Data Berhasil di Input");
            }

        }

        private void InputKendaraan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu back = new Menu();
            back.Show();
        }
    }
}
