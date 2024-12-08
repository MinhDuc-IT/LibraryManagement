using LibraryManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.View.Employee
{
    public partial class Form_Customer : Form
    {
        private CustomerController customerCtrl = new CustomerController();
        public Form_Customer()
        {
            InitializeComponent();
        }

        private void resetInput()
        {
            txt_ID_Cus.Text = "";
            txt_Name_Cus.Text = "";
            txt_gender.Text = "";
            dateTime_dob.Value = DateTime.Now;
            txt_phone.Text = "";
            txt_address.Text = "";
            txt_cccd.Text = "";
            dateTime_startdate.Value = DateTime.Now;
            btn_add.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //if (btn_xoa.Visible == true || btn_sua.Visible == true)
            //{
            //    if (MessageBox.Show("Bạn có chắc muốn chuyển tác vụ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        btn_sua.Visible = false;
            //        btn_xoa.Visible = false;
            //        resetInput();
            //        return;
            //    }
            //}
            string name = txt_Name_Cus.Text;
            string gender = txt_gender.Text;
            DateTime dateofbirth = dateTime_dob.Value;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string cccd = txt_cccd.Text;
            DateTime startdate = dateTime_startdate.Value;

            var cus = customerCtrl.Create(name, gender, dateofbirth, address, phone, cccd, startdate);
            switch (cus.ErrCode)
            {
                case Model.EnumErrCode.IsValidInput:
                    MessageBox.Show(cus.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Model.EnumErrCode.Error:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Cus.DataSource = cus.Data;
                    Form_Customer_Load(sender, e);
                    break;
            }
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            var cus = customerCtrl.GetAll();
            switch (cus.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Cus.DataSource = null;
                    dataGridView_Cus.DataSource = cus.Data;
                    break;
            }
        }

        private void dataGridView_Cus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //btn_sua.Visible = true;
            //btn_xoa.Visible = true;
            DataGridViewRow selectedRow = dataGridView_Cus.Rows[e.RowIndex];

            txt_ID_Cus.Text = selectedRow.Cells["CustomerID"].Value.ToString();
            txt_Name_Cus.Text = selectedRow.Cells["Name"].Value.ToString();
            txt_gender.Text = selectedRow.Cells["Gender"].Value.ToString();
            dateTime_dob.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
            txt_phone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
            txt_address.Text = selectedRow.Cells["Address"].Value.ToString();
            txt_cccd.Text = selectedRow.Cells["CitizenIdentification"].Value.ToString();
            dateTime_startdate.Value = Convert.ToDateTime(selectedRow.Cells["StartDate"].Value);
            btn_add.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa người dùng này không?",
                                          "Xác nhận sửa",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            int id = int.Parse(txt_ID_Cus.Text);
            string name = txt_Name_Cus.Text;
            string gender = txt_gender.Text;
            DateTime dateofbirth = dateTime_dob.Value;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string cccd = txt_cccd.Text;
            DateTime startdate = dateTime_startdate.Value;

            var cus = customerCtrl.Edit(id, name, gender, dateofbirth, address, phone, cccd, startdate);
            switch (cus.ErrCode)
            {
                case Model.EnumErrCode.IsValidInput:
                    MessageBox.Show(cus.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Model.EnumErrCode.Error:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Cus.DataSource = cus.Data;
                    Form_Customer_Load(sender, e);
                    break;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?",
                                          "Xác nhận xóa",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            int id = int.Parse(txt_ID_Cus.Text);
            var cus = customerCtrl.Delete(id);
            switch (cus.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Cus.DataSource = cus.Data;
                    Form_Customer_Load(sender, e);
                    break;
            }
            resetInput();
            //btn_sua.Visible = false;
            //btn_xoa.Visible = false;
        }
    }
}
