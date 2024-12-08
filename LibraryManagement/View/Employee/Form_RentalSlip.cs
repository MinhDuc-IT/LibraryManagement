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

        //private void Form_RentalSlip_Load(object sender, EventArgs e)
        //{
        //    Width = Parent.Width;
        //    Height = Parent.Height;

        //    // Khởi tạo lại danh sách tạm khi form load
        //    tempRentalSlipDetails = new List<RentalSlipDetail>();
        //    dataGridView_RentalDetails.DataSource = null;

        //    var rs = rentalSlipController.GetAllBooks();
        //    switch (rs.ErrCode)
        //    {
        //        case Model.EnumErrCode.Error:
        //            MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            break;
        //        case Model.EnumErrCode.Empty:
        //            MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            break;
        //        case Model.EnumErrCode.Success:
        //            dataGridView_Books.DataSource = rs.Data;
        //            break;
        //    }
        //}

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void Form_RentalSlip_Load(object sender, EventArgs e)
        {
            Width = Parent.Width;
            Height = Parent.Height;

            // Khởi tạo lại danh sách tạm khi form load
            tempRentalSlipDetails = new List<RentalSlipDetail>();
            dataGridView_RentalDetails.DataSource = null;

            var rs = rentalSlipController.GetAllBooks();
            var list = rs.Data;
            dataGridView_Books.DataSource = null;

            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    //dataGridView_Books.DataSource = rs.Data;
                    if (list != null && list.Any())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("BookID", typeof(int));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("ShelfID", typeof(int));
                        dt.Columns.Add("Publisher", typeof(string));
                        dt.Columns.Add("DateOfRelease", typeof(DateTime));
                        dt.Columns.Add("Author", typeof(string));
                        dt.Columns.Add("Quantity", typeof(int));
                        dt.Columns.Add("Price", typeof(decimal));
                        dt.Columns.Add("Description", typeof(string));
                        dt.Columns.Add("Image", typeof(Image));

                        //dt.Columns.Add("IsDeleted", typeof(bool));

                        foreach (var book in list)
                        {
                            Image img = null;
                            if (book.Image != null)
                            {
                                img = ByteArrayToImage(book.Image.ToArray());
                            }

                            dt.Rows.Add(book.BookID, book.Name, book.ShelfID, book.Publisher, book.DateOfRelease, book.Author, book.Quantity, book.Price, book.Description, book.Image);
                        }
                        dataGridView_Books.DataSource = dt;
                        DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView_Books.Columns["Image"];
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
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

            UpdateDataGridViewRentalDetails();
        }

        private void btn_AddRentalSlip_Click(object sender, EventArgs e)
        {
            if (!tempRentalSlipDetails.Any())
            {
                MessageBox.Show("Danh sách chi tiết phiếu thuê đang trống. Vui lòng thêm chi tiết trước khi tạo phiếu.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dateTimePicker_RentalDate.Text, out DateTime rentalDate) ||
                !DateTime.TryParse(dateTimePicker_DueDate.Text, out DateTime dueDate))
            {
                MessageBox.Show("Ngày thuê hoặc ngày trả không hợp lệ.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rentalDate > dueDate)
            {
                MessageBox.Show("Ngày thuê không được sau ngày trả.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txt_BookID.Text = r.Cells[0].Value.ToString();
            txt_Quantity.Text = r.Cells[1].Value.ToString();
            txt_RentalFee.Text = r.Cells[2].Value.ToString();

            btn_AddRentalDetail.Enabled = false;
            btn_EditRentalDetail.Enabled = true;
            btn_DeleteRentalDetail.Enabled = true;
            txt_BookID.ReadOnly = true;
        }

        private void dataGridView_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Books_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = dataGridView_Books.Rows[e.RowIndex];
            txt_BookID.Text = r.Cells[0].Value.ToString();
            txt_Quantity.Text = "";
            txt_RentalFee.Text = "";

            btn_AddRentalDetail.Enabled = true;
            btn_EditRentalDetail.Enabled = false;
            btn_DeleteRentalDetail.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = txt_Search.Text;

            var rs = rentalSlipController.SearchBooks(query);
            var list = rs.Data;
            dataGridView_Books.DataSource = null;

            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    //dataGridView_Books.DataSource = rs.Data;
                    if (list != null && list.Any())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("BookID", typeof(int));
                        dt.Columns.Add("Name", typeof(string));
                        dt.Columns.Add("ShelfID", typeof(int));
                        dt.Columns.Add("Publisher", typeof(string));
                        dt.Columns.Add("DateOfRelease", typeof(DateTime));
                        dt.Columns.Add("Author", typeof(string));
                        dt.Columns.Add("Quantity", typeof(int));
                        dt.Columns.Add("Price", typeof(decimal));
                        dt.Columns.Add("Description", typeof(string));
                        dt.Columns.Add("Image", typeof(Image));

                        //dt.Columns.Add("IsDeleted", typeof(bool));

                        foreach (var book in list)
                        {
                            Image img = null;
                            if (book.Image != null)
                            {
                                img = ByteArrayToImage(book.Image.ToArray());
                            }

                            dt.Rows.Add(book.BookID, book.Name, book.ShelfID, book.Publisher, book.DateOfRelease, book.Author, book.Quantity, book.Price, book.Description, book.Image);
                        }
                        dataGridView_Books.DataSource = dt;
                        DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView_Books.Columns["Image"];
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                    break;
            }
        }

        private void Form_RentalSlip_FormClosing(object sender, FormClosingEventArgs e)
        {
            tempRentalSlipDetails.Clear();
        }

        private void btn_EditRentalDetail_Click(object sender, EventArgs e)
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

            // Tìm RentalSlipDetail cần sửa trong danh sách tạm
            var rentalSlipDetailToEdit = tempRentalSlipDetails.FirstOrDefault(r => r.BookID == bookID);

            if (rentalSlipDetailToEdit != null)
            {
                // Cập nhật các giá trị cần sửa
                rentalSlipDetailToEdit.Quantity = quantity;
                rentalSlipDetailToEdit.RentalFee = rentalFee;

                // Cập nhật lại giao diện DataGridView
                UpdateDataGridViewRentalDetails();

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách trong danh sách tạm để sửa.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DeleteRentalDetail_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_BookID.Text, out int bookID);

            var rentalSlipDetailToDelete = tempRentalSlipDetails.FirstOrDefault(r => r.BookID == bookID);

            if (rentalSlipDetailToDelete != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Xóa bản ghi khỏi danh sách tạm
                    tempRentalSlipDetails.Remove(rentalSlipDetailToDelete);

                    // Cập nhật lại giao diện DataGridView
                    UpdateDataGridViewRentalDetails();

                    txt_BookID.Text = "";
                    txt_Quantity.Text = "";
                    txt_RentalFee.Text = "";

                    MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách trong danh sách tạm để xóa.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDataGridViewRentalDetails()
        {
            dataGridView_RentalDetails.DataSource = null;
            var list = tempRentalSlipDetails.Select(rs => new
            {
                rs.BookID,
                rs.Quantity,
                rs.RentalFee,
                Image = rentalSlipController.GetBookImageById(rs.BookID)
            }).ToList();

            dataGridView_RentalDetails.DataSource = null;
            if (list != null && list.Any())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("BookID", typeof(int));
                dt.Columns.Add("Quantity", typeof(int));
                dt.Columns.Add("RentalFee", typeof(decimal));
                dt.Columns.Add("Image", typeof(Image));

                //dt.Columns.Add("IsDeleted", typeof(bool));

                foreach (var book in list)
                {
                    Image img = null;
                    if (book.Image != null)
                    {
                        img = ByteArrayToImage(book.Image.ToArray());
                    }

                    dt.Rows.Add(book.BookID, book.Quantity, book.RentalFee, book.Image);
                }
                dataGridView_RentalDetails.DataSource = dt;
                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView_RentalDetails.Columns["Image"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }
    }
}
