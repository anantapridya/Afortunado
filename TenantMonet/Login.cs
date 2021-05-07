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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Username = tbUsername.Text;
            adm.Password = tbPassword.Text;
            if(adm.login(adm.Username,adm.Password))
            {
                MessageBox.Show("Login Berhasil");
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password SALAH");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
