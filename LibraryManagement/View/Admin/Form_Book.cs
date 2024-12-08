using LibraryManagement.Controller;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LibraryManagement.View
{
    public partial class Form_Book : Form
    {
        BookController bookCtrl = new BookController();
        public Form_Book()
        {
            InitializeComponent();
        }
        private void resetInput()
        {
            txt_bookName.Text = "";
            txt_description.Text = "";
            txt_quantity.Text = "";
            txt_publisher.Text = "";
            txt_authorName.Text = "";
            txt_price.Text = "";
            dtp_dateOfRelease.Value = DateTime.Now;
            pb_Image.Image = null;
            txt_Id.Text = "";
            cb_shelfID.SelectedIndex = 0;
            btn_add.Enabled = true;
        }
        private void Form_Book_Load(object sender, EventArgs e)
        {
            var list = bookCtrl.GetAll().Data;
            dataGridView1.DataSource = null;

            if (list.Any())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                dt.Columns.Add("Book Name", typeof(string));
                dt.Columns.Add("Description", typeof(string));
                dt.Columns.Add("ShelfId", typeof(string));
                dt.Columns.Add("Quantity", typeof(int));
                dt.Columns.Add("Publisher", typeof(string));
                dt.Columns.Add("Author Name", typeof(string));
                dt.Columns.Add("Price", typeof(string));
                dt.Columns.Add("Date Of Release", typeof(DateTime));
                dt.Columns.Add("Image", typeof(Image));

                foreach (var book in list)
                {
                    Image img = null;

                    if (book.Image != null)
                    {
                        img = ByteArrayToImage(book.Image.ToArray());
                    }

                    string priceFormat = book.Price.ToString("N0");

                    dt.Rows.Add(book.BookID, book.Name, book.Description, book.ShelfID, book.Quantity, book.Publisher, book.Author, priceFormat, book.DateOfRelease, img);
                }

                dataGridView1.DataSource = dt;

                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            }

            var rs_nq = bookCtrl.GetAllShelf();
            switch (rs_nq.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs_nq.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs_nq.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    cb_shelfID.DataSource = rs_nq.Data;
                    cb_shelfID.DisplayMember = "ShelfName";
                    cb_shelfID.ValueMember = "ShelfID";
                    break;
            }
        }
        private void btn_addImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn ảnh";
            open.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = Image.FromFile(open.FileName);
            }
        }
        private byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            var bookName = txt_bookName.Text;
            var description = txt_description.Text;
            var shelfId = cb_shelfID.SelectedValue.ToString();
            var quantity = txt_quantity.Text;
            var publisher = txt_publisher.Text;
            var authorName = txt_authorName.Text;
            string price = txt_price.Text;
            DateTime dateOfRelease = dtp_dateOfRelease.Value;
            byte[] Image = null;
            if (pb_Image.Image != null)
            {
                Image = ImageToByteArray(pb_Image.Image);
            }

            var rs = bookCtrl.AddBook(bookName, description, shelfId, quantity, publisher, authorName, price, dateOfRelease, Image);
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetInput();
                    Form_Book_Load(sender, e);
                    break;
                case Model.EnumErrCode.IsValidInput:
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
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = dataGridView1.Rows[e.RowIndex];
            txt_Id.Text = r.Cells[0].Value.ToString();
            txt_bookName.Text = r.Cells[1].Value.ToString();
            txt_description.Text = r.Cells[2].Value.ToString();
            int shelfID = Convert.ToInt32(r.Cells[3].Value);
            cb_shelfID.SelectedValue = shelfID;
            txt_quantity.Text = r.Cells[4].Value.ToString();
            txt_publisher.Text = r.Cells[5].Value.ToString();
            txt_authorName.Text = r.Cells[6].Value.ToString();
            txt_price.Text = r.Cells[7].Value.ToString();
            dtp_dateOfRelease.Text = r.Cells[8].Value.ToString();
            var imageValue = r.Cells["Image"].Value;

            if (imageValue != null && imageValue is Image image)
            {
                pb_Image.Image = image;
            }
            btn_add.Enabled = false;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Id.Text))
            {
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa quyển sách này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txt_Id.Text);
                    var rs = bookCtrl.DeleteBook(id);
                    switch (rs.ErrCode)
                    {
                        case Model.EnumErrCode.Error:
                            MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case Model.EnumErrCode.Success:
                            MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetInput();
                            Form_Book_Load(sender, e);
                            break;
                        case Model.EnumErrCode.Empty:
                            MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Id.Text))
            {
                int id = Convert.ToInt32(txt_Id.Text);
                var bookName = txt_bookName.Text;
                var description = txt_description.Text;
                var shelfId = cb_shelfID.SelectedValue.ToString();
                var quantity = txt_quantity.Text;
                var publisher = txt_publisher.Text;
                var authorName = txt_authorName.Text;
                string price = txt_price.Text;
                DateTime dateOfRelease = dtp_dateOfRelease.Value;
                byte[] Image = null;
                if (pb_Image.Image != null)
                {
                    Image = ImageToByteArray(pb_Image.Image);
                }
                var rs = bookCtrl.EditBook(id, bookName, description, shelfId, quantity, publisher, authorName, price, dateOfRelease, Image);
                switch (rs.ErrCode)
                {
                    case Model.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case Model.EnumErrCode.Success:
                        MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetInput();
                        Form_Book_Load(sender, e);
                        break;
                    case Model.EnumErrCode.Empty:
                        MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case Model.EnumErrCode.IsValidInput:
                        MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để sửa", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            resetInput();
        }
    }
}
