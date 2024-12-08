using LibraryManagement.Controller;
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
    public partial class Form_Search : Form
    {
        private SearchBookController _searchBookCtrl = new SearchBookController();
        public Form_Search()
        {
            InitializeComponent();
        }
        private void loadData(List<DTO.SeacrchBookResponse> rs)
        {
            var list = rs;
            dgvBookList.DataSource = null;

            if (list.Any())
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("BookID", typeof(string));
                dt.Columns.Add("Book Name", typeof(string));
                dt.Columns.Add("Shelf Name", typeof(string));
                dt.Columns.Add("Publisher", typeof(string));
                dt.Columns.Add("Date Of Release", typeof(DateTime));
                dt.Columns.Add("Author", typeof(string));
                dt.Columns.Add("Quantity", typeof(int));
                dt.Columns.Add("price", typeof(string));
                dt.Columns.Add("Image", typeof(Image));

                foreach (var book in list)
                {
                    Image img = null;

                    if (book.BookImage != null)
                    {
                        img = ByteArrayToImage(book.BookImage);
                    }

                    string priceFormat = book.Price.ToString("N0");

                    dt.Rows.Add(book.BookID, book.Name, book.ShelfName, book.Publisher, book.DateOfRelease, book.Author, book.Quantity, priceFormat, img);
                }

                dgvBookList.DataSource = dt;

                DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dgvBookList.Columns["Image"];
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }
        private void Form_Search_Load(object sender, EventArgs e)
        {
            var rs = _searchBookCtrl.GetAll();
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvBookList.DataSource = null;

                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvBookList.DataSource = null;
                    break;
                case Model.EnumErrCode.Success:
                    loadData(rs.Data);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            var rs = _searchBookCtrl.SearchBooks(query);
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvBookList.DataSource = null;

                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvBookList.DataSource = null;

                    break;
                case Model.EnumErrCode.Success:
                    loadData(rs.Data);
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form_Search_Load(sender, e);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
