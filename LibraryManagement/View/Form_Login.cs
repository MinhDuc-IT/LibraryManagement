using LibraryManagement.Controller;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement.View
{
    public partial class Form_Login : Form
    {
        private AuthController authCtrl = new AuthController();
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;

            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập vào tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(mk))
                {
                    MessageBox.Show("Vui lòng nhập vào mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMK.Focus();
                }
                else
                {
                    var rs = authCtrl.Login(tk, mk);
                    bool valid = false;
                    switch (rs.ErrCode)
                    {
                        case Model.EnumErrCode.Error:
                            MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case Model.EnumErrCode.Success:
                            //MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        var data = rs.Data;
                        if (data.Role == "Admin")
                        {
                            Form_Admin form_admin = new Form_Admin();
                            form_admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form_Employee form_employee = new Form_Employee();
                            form_employee.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
        private void cb_mk_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = cb_mk.Checked;
            if (isChecked)
            {
                txtMK.PasswordChar = '\0'; 
            }
            else
            {
                txtMK.PasswordChar = '*'; 
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp form_signup = new Form_SignUp();
            form_signup.Show();
            this.Hide();
        }
    }
}
