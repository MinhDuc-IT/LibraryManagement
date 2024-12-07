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
    public partial class Form_RentalSlip : Form
    {
        private int ReceivedCustomerID;

        public Form_RentalSlip(int receivedcustomerID)
        {
            InitializeComponent();
            ReceivedCustomerID = receivedcustomerID;
            txt_CustomerID.Text = receivedcustomerID.ToString();
        }

        RentalSlipController rentalSlipController = new RentalSlipController();
        //private List<RentalSlipDetailTemp> tempRentalSlipDetails = new List<RentalSlipDetailTemp>();
        private List<RentalSlipDetail> tempRentalSlipDetails = new List<RentalSlipDetail>();

        private void Form_RentalSlip_Load(object sender, EventArgs e)
        {
            Width = Parent.Width;
            Height = Parent.Height;

            // Khởi tạo lại danh sách tạm khi form load
            tempRentalSlipDetails = new List<RentalSlipDetail>();
            dataGridView_RentalDetails.DataSource = null;

            var rs = rentalSlipController.GetAllBooks();
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Books.DataSource = rs.Data;
                    break;
            }
        }

        private void dataGridView_RentalDetails_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btn_AddRentalDetail_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_BookID.Text, out int bookID) ||
                !int.TryParse(txt_Quantity.Text, out int quantity) ||
                !decimal.TryParse(txt_RentalFee.Text, out decimal rentalFee))
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng kiểm tra lại.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (quantity <= 0 || rentalFee <= 0)
            {
                MessageBox.Show("Số lượng và giá phải lớn hơn 0.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tempRentalSlipDetails.Add(new RentalSlipDetail
            {
                BookID = bookID,
                Quantity = quantity,
                RentalFee = rentalFee
            });

            dataGridView_RentalDetails.DataSource = null;
            dataGridView_RentalDetails.DataSource = tempRentalSlipDetails;
        }

        private void btn_AddRentalSlip_Click(object sender, EventArgs e)
        {
            if (!tempRentalSlipDetails.Any())
            {
                MessageBox.Show("Danh sách chi tiết phiếu thuê đang trống. Vui lòng thêm chi tiết trước khi tạo phiếu.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(txt_RentalDate.Text, out DateTime rentalDate) ||
                !DateTime.TryParse(txt_DueDate.Text, out DateTime dueDate))
            {
                MessageBox.Show("Ngày thuê hoặc ngày trả không hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newRentalSlip = new RentalSlip
            {
                CustomerID = ReceivedCustomerID,
                RentalDate = rentalDate,
                DueDate = dueDate
            };

            //int rentalSlipID = rentalSlipController.AddRentalSlip(newRentalSlip);

            var result = rentalSlipController.AddRentalSlip(newRentalSlip);

            if (result.ErrCode != EnumErrCode.Success)
            {
                MessageBox.Show($"Tạo phiếu thuê thất bại! Lỗi: {result.ErrDesc}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int rentalSlipID = result.Data;

            foreach (var rentalDetail in tempRentalSlipDetails)
            {
                rentalDetail.RentalSlipID = rentalSlipID;
            }

            //rentalSlipController.AddRentalSlipDetails(tempRentalSlipDetails);

            var detailsResult = rentalSlipController.AddRentalSlipDetails(tempRentalSlipDetails);

            if (detailsResult.ErrCode != EnumErrCode.Success)
            {
                MessageBox.Show($"Thêm chi tiết phiếu thuê thất bại! Lỗi: {detailsResult.ErrDesc}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Tạo phiếu thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tempRentalSlipDetails.Clear();
            dataGridView_RentalDetails.DataSource = null;
        }

        private void dataGridView_RentalDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = dataGridView_RentalDetails.Rows[e.RowIndex];
            txt_BookID.Text = r.Cells[2].Value.ToString();
            txt_Quantity.Text = r.Cells[3].Value.ToString();
            txt_RentalFee.Text = r.Cells[4].Value.ToString();
        }

        private void dataGridView_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Books_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = dataGridView_Books.Rows[e.RowIndex];
            txt_BookID.Text = r.Cells[0].Value.ToString();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = txt_Search.Text;

            var rs = rentalSlipController.SearchBooks(query);
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Books.DataSource = rs.Data;
                    break;
            }
        }

        private void Form_RentalSlip_FormClosing(object sender, FormClosingEventArgs e)
        {
            tempRentalSlipDetails.Clear();
        }
    }
}
