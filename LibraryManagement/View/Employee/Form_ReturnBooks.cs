using LibraryManagement.Controller;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.View.Employee
{
    public partial class Form_ReturnBooks : Form
    {
        private int dateValid;
        private int dateIsValid;
        private decimal rentalFee;
        private int rentalSlipId;
        private int rentalSlipDetailId;
        private int bookId;

        private ReturnBookController rbCtrl = new ReturnBookController();
        private BookController bookCtrl = new BookController();
        private rentalSlipController rentalSlipCtrl = new rentalSlipController();
        private ReturnHistoryController returnHistoryCtrl = new ReturnHistoryController();
        private rentalSlipDetailController rentalSlipDetailCtrl = new rentalSlipDetailController();
        public Form_ReturnBooks()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var cccd = txt_cccd.Text;
            var rs = rbCtrl.GetAllRentalSlipOfCustomer(cccd);
            var list = new List<DTO.RentalSlipOfCustomer>();
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    list = rs.Data;
                    dataGridView1.DataSource = null;

                    if (list.Any())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Customer Name", typeof(string));
                        dt.Columns.Add("RSID", typeof(int));
                        dt.Columns.Add("Rental Date", typeof(DateTime));
                        dt.Columns.Add("Due Date", typeof(DateTime));
                        dt.Columns.Add("RSDID", typeof(int));
                        dt.Columns.Add("Rental Fee", typeof(string)); 
                        dt.Columns.Add("Quantity", typeof(int));
                        dt.Columns.Add("BookId", typeof(int));
                        dt.Columns.Add("Book Name", typeof(string));
                        dt.Columns.Add("Image", typeof(Image));

                        foreach (var rsl in list)
                        {
                            Image img = null;

                            if (rsl.bookImage != null)
                            {
                                img = ByteArrayToImage(rsl.bookImage);
                            }

                            string rentalFeeFormatted = rsl.RentalFee.ToString("N0");

                            dt.Rows.Add(rsl.customerName,rsl.retalSlipId, rsl.RentalDate, rsl.DueDate, rsl.rentalSlipDetailId, rentalFeeFormatted, rsl.Quantity, rsl.bookId, rsl.bookName, img);
                        }

                        dataGridView1.DataSource = dt;

                        DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        private void txt_searchInput_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_searchInput.Text.Trim().ToLower(); 

            if (dataGridView1.DataSource is DataTable dt && !string.IsNullOrEmpty(filterText))
            {
                // Lọc dữ liệu dựa vào cột "Book Name"
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"[Book Name] LIKE '%{filterText}%'";
            }
            else
            {
                // Bỏ lọc nếu không có nội dung tìm kiếm
                if (dataGridView1.DataSource is DataTable originalDt)
                {
                    DataView dv = originalDt.DefaultView;
                    dv.RowFilter = string.Empty;
                }
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var r = dataGridView1.Rows[e.RowIndex];
                var dateNow = DateTime.Now;
                bookId = Convert.ToInt32(r.Cells["BookId"].Value);
                rentalSlipDetailId = Convert.ToInt32(r.Cells["RSDID"].Value);
                rentalSlipId = Convert.ToInt32(r.Cells["RSID"].Value);

                DateTime rentalDate = Convert.ToDateTime(r.Cells["Rental Date"].Value);
                DateTime dueDate = Convert.ToDateTime(r.Cells["Due Date"].Value);

                rentalFee = Convert.ToDecimal(r.Cells["Rental Fee"].Value);
                nud_quantity.Maximum = Convert.ToInt32(r.Cells["Quantity"].Value.ToString());
                nud_quantity.Minimum = 1;
                nud_quantity.Value = nud_quantity.Maximum;

                dateValid = (dueDate - rentalDate).Days;
                dateIsValid = (dateNow - dueDate).Days;

                dateIsValid = dateIsValid > 0 ? dateIsValid : 0;
                txt_overdue.Text = dateIsValid.ToString();
                CalculateTotal((int)nud_quantity.Value);

                var imageValue = r.Cells["Image"].Value;
                if (imageValue != null && imageValue is Image image)
                {
                    pb_book.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình tính toán: " + ex.Message,
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateTotal(int quantity)
        {
            decimal finePerDay = rentalFee * 1.5m;
            decimal fine = quantity * finePerDay * dateIsValid;
            decimal total = quantity * rentalFee * dateValid + fine;

            txt_fine.Text = fine.ToString("N0");
            txt_total.Text = total.ToString("N0");
        }
        private void nud_quantity_ValueChanged(object sender, EventArgs e)
        {
            int quantity = (int)nud_quantity.Value;
            CalculateTotal(quantity);
        }
        private void btn_return_Click(object sender, EventArgs e)
        {
            int quantityPaid = Convert.ToInt32(nud_quantity.Text);
            decimal totalPrice = Convert.ToDecimal(txt_total.Text);

            var rsdRespon = rentalSlipDetailCtrl.UpdateRentalSlipDetail(rentalSlipDetailId, quantityPaid);
            switch (rsdRespon.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rsdRespon.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rsdRespon.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
            var rhRespon = returnHistoryCtrl.AddReturnHistory(rentalSlipDetailId, quantityPaid, totalPrice);
            switch (rhRespon.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rhRespon.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    break;
                default:
                    break;
            }
            var bookRespon =  bookCtrl.UpdateQuantityByReturn(bookId, quantityPaid);
            switch (bookRespon.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(bookRespon.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(bookRespon.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
            var rsRespon = rentalSlipCtrl.UpdateTotalFee(rentalSlipId, totalPrice);
            switch (rsdRespon.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rsRespon.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rsRespon.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            btn_search_Click(sender, e);
        }
    }
}
