using LibraryManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement.View
{
    public partial class Form_User : Form
    {
        private UserController userCtrl = new UserController();
        public Form_User()
        {
            InitializeComponent();
            cb_gender.SelectedIndex = 0;
            cb_role.SelectedIndex = 0;
        }
        private void resetInput()
        {
            txt_Email.Text = "";
            txt_password.Text = "";
            cb_role.SelectedIndex = 0;
            txt_address.Text = "";
            cb_gender.SelectedIndex = 0;
            txt_userName.Text = "";
            dtp_dateOfBirth.Value = DateTime.Now;
            txt_phone.Text = "";
            txt_cccd.Text = "";
            txt_Id.Text = "";
            btn_add.Enabled = true;
            txt_Email.Enabled = true;
            txt_password.Enabled = true;
            cb_role.Enabled = true;
            btn_delete.Enabled = true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var userName = txt_userName.Text;
            var Email = txt_Email.Text;
            var password = txt_password.Text;
            var address = txt_address.Text;
            var phone = txt_phone.Text;
            var cccd = txt_cccd.Text;
            var role = cb_role.SelectedItem.ToString();
            var gender = cb_gender.SelectedItem.ToString();
            DateTime dateOfBirth = dtp_dateOfBirth.Value;

            var rs = userCtrl.AddUser(Email, password, role, address, gender, userName, phone, dateOfBirth, cccd);
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetInput();
                    Form_User_Load(sender, e);
                    break;
                case Model.EnumErrCode.IsValidInput:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }

        private void Form_User_Load(object sender, EventArgs e)
        {
            var rs = userCtrl.GetAll();
            var list = new List<Model.User>();
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    //MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list = userCtrl.GetAll().Data;
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = dataGridView1.Rows[e.RowIndex];
            txt_Id.Text = r.Cells[0].Value.ToString();
            txt_Email.Text = r.Cells[1].Value.ToString();
            txt_password.Text = r.Cells[2].Value.ToString();
            txt_userName.Text = r.Cells[3].Value.ToString();
            dtp_dateOfBirth.Text = r.Cells[4].Value.ToString();
            txt_address.Text = r.Cells[5].Value.ToString();
            cb_gender.Text = r.Cells[6].Value.ToString();
            txt_phone.Text = r.Cells[7].Value.ToString();
            txt_cccd.Text = r.Cells[8]. Value.ToString();
            cb_role.Text = r.Cells[9].Value.ToString();
            cb_role.Enabled = cb_role.Text != "Admin";
            btn_delete.Enabled = cb_role.Text != "Admin";
            btn_add.Enabled = false;
            txt_Email.Enabled = false;
            txt_password.Enabled = false;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txt_Id.Text);
            var userName = txt_userName.Text;
            var address = txt_address.Text;
            var phone = txt_phone.Text;
            var cccd = txt_cccd.Text;
            var role = cb_role.SelectedItem.ToString();
            var gender = cb_gender.SelectedItem.ToString();
            DateTime dateOfBirth = dtp_dateOfBirth.Value;

            var rs = userCtrl.EditUser(id, role, address, gender, userName, phone, dateOfBirth, cccd);
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetInput();
                    Form_User_Load(sender, e);
                    break;
                case Model.EnumErrCode.IsValidInput:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txt_Id.Text);
            var rs = userCtrl.DeleteUser(id);
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetInput();
                    Form_User_Load(sender, e);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
    }
}
