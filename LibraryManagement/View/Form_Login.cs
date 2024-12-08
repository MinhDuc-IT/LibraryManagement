using LibraryManagement.Controller;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private bool checkEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, emailPattern))
            {
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;

            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập vào Email", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
            }
            else
            {
                if (!checkEmail(tk))
                {
                    MessageBox.Show("Định dạng Email không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTK.Focus();
                }
                else if (string.IsNullOrEmpty(mk))
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
    }
}
