using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.Controller;
using LibraryManagement.Model;


namespace LibraryManagement.View
{
    public partial class FormLogin : Form
    {
        private  LoginController _loginController = new LoginController();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (_loginController.ValidateUser(username, password))
            {
                txtEmail.Text = "";
                txtPassword.Text = "";
                FormMain f = new FormMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                txtPassword.Text = "";
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
