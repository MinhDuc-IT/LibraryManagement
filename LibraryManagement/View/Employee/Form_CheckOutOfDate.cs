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

namespace LibraryManagement.View.Employee
{
    public partial class Form_CheckOutOfDate : Form
    {
        private Form_Employee mainForm; // Tham chiếu đến Form_Employee

        public Form_CheckOutOfDate(Form_Employee parentForm)
        {
            InitializeComponent();
            mainForm = parentForm; // Gán tham chiếu
        }

        RentalSlipController rentalSlipController = new RentalSlipController();

        public Form_CheckOutOfDate()
        {
            InitializeComponent();
        }

        private void Form_CheckOutOfDate_Load(object sender, EventArgs e)
        {
            Width = Parent.Width;
            Height = Parent.Height;
        }

        private void btn_MakeRentalSlip_Click(object sender, EventArgs e)
        {
            //int customerID = int.Parse(txt_CustomerID.Text);
            if(!int.TryParse(txt_CustomerID.Text, out int customerID))
            {
                MessageBox.Show("Hãy nhập mã khách hàng trước. Vui lòng kiểm tra lại.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_MakeRentalSlip.Enabled = false;
                return;
            }
            var formRentalSlip = new Form_RentalSlip(customerID);
            mainForm.ShowFormInPanel(formRentalSlip);
        }

        //private void btn_Search_Click(object sender, EventArgs e)
        //{
        //    int customerID;
        //    if (!int.TryParse(txt_CustomerID.Text, out customerID))
        //    {
        //        MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Gọi phương thức lấy phiếu thuê của khách hàng
        //    var result = rentalSlipController.GetRentalSlipsByCustomer(customerID);

        //    switch (result.ErrCode)
        //    {
        //        case Model.EnumErrCode.Error:
        //            MessageBox.Show(result.ErrDesc, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            break;
        //        case Model.EnumErrCode.Empty:
        //            MessageBox.Show(result.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            break;
        //        case Model.EnumErrCode.InvalidInput:
        //            MessageBox.Show(result.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            break;
        //        case Model.EnumErrCode.Success:
        //            // Kiểm tra phiếu thuê có bị trễ hạn hay không
        //            var overdueRentalSlips = result.Data.Where(rs => rs.DueDate < DateTime.Now && rs.RentalSlipDetails.Any(rsd => rsd.ReturnStatus == false)).ToList();

        //            if (overdueRentalSlips.Any())
        //            {
        //                // Hiển thị danh sách phiếu thuê trễ hạn
        //                btn_MakeRentalSlip.Enabled = false;
        //                dataGridView_ListRentalSlips.DataSource = overdueRentalSlips;
        //                label_OnTime.Visible = false;
        //                label_OverDue.Visible = true;
        //            }
        //            else
        //            {
        //                // Không có phiếu thuê trễ hạn, cho phép tạo phiếu thuê mới
        //                btn_MakeRentalSlip.Enabled = true;
        //                label_OnTime.Visible = true;
        //                label_OverDue.Visible = false;
        //                dataGridView_ListRentalSlips.DataSource = null;
        //            }
        //            break;
        //    }
        //}

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int customerID;
            if (!int.TryParse(txt_CustomerID.Text, out customerID))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = rentalSlipController.GetRentalSlipsByCustomer(customerID);

            switch (result.ErrCode)
            {
                case EnumErrCode.Error:
                    MessageBox.Show(result.ErrDesc, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case EnumErrCode.Empty:
                    MessageBox.Show(result.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case EnumErrCode.InvalidInput:
                    MessageBox.Show(result.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case EnumErrCode.Success:
                    var overdueRentalSlips = result.Data
                        .Where(rs => rs.DueDate < DateTime.Now &&
                                     rs.RentalSlipDetails.Any(rsd => rsd.ReturnStatus == false))
                        .ToList();

                    if (overdueRentalSlips.Any())
                    {
                        btn_MakeRentalSlip.Enabled = false;
                        dataGridView_ListRentalSlips.DataSource = overdueRentalSlips;
                        label_OnTime.Visible = false;
                        label_OverDue.Visible = true;
                    }
                    else
                    {
                        btn_MakeRentalSlip.Enabled = true;
                        label_OnTime.Visible = true;
                        label_OverDue.Visible = false;
                        dataGridView_ListRentalSlips.DataSource = null;
                    }
                    break;
            }
        }
    }
}
