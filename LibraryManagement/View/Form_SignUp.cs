using LibraryManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement.View
{
    public partial class Form_SignUp : Form
    {
        AuthController authCtrl = new AuthController();
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            var userName = txt_userName.Text;
            var password = txt_password.Text;
            var confirmPassword = txt_cfPassword.Text;
            var Email = txt_Email.Text;

            var rs = authCtrl.SignUp(userName, Email, password, confirmPassword);
            bool valid = false;
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    valid = true;
                    break;
                case Model.EnumErrCode.IsValidInput:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
            if (valid)
            {
                Form_Login form_Login = new Form_Login();
                form_Login.ShowDialog();
                this.Close();
            }

        }
    }
}
