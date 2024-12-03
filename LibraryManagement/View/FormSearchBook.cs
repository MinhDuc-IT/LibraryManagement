using LibraryManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormSearchBook : Form
    {
        private string connectionString = "Server=LAPTOP-AMORBTV2;Database=LibraryManagement;Integrated Security=true;";

        public FormSearchBook()
        {
            InitializeComponent();
        }

        private void FormSearchBook_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dbContext = new LibraryManagementDataContext(connectionString);

            string query = txtSearch.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                dgvBookList.DataSource = dbContext.Books
                    .Select(b => new
                    {
                        b.BookID,
                        b.Name,
                        ShelfName = b.Shelf.ShelfName,
                        b.Publisher,
                        b.DateOfRelease,
                        b.Author,
                        b.Quantity,
                        b.Price
                    })
                    .ToList();
            }
            else
            {
                var filteredItems = dbContext.Books
                    .Where(b =>
                        b.Name.ToLower().Contains(query) ||          // Tìm trong tên sách
                        b.Author.ToLower().Contains(query) ||        // Tìm trong tên tác giả
                        b.Publisher.ToLower().Contains(query) ||     // Tìm trong nhà xuất bản
                        b.Shelf.ShelfName.ToLower().Contains(query)) // Tìm trong tên kệ
                    .Select(b => new
                    {
                        b.BookID,
                        b.Name,
                        ShelfName = b.Shelf.ShelfName,
                        b.Publisher,
                        b.DateOfRelease,
                        b.Author,
                        b.Quantity,
                        b.Price
                    })
                    .ToList();

                dgvBookList.DataSource = filteredItems;
            }
            //LoadGridByKeyword();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var dbContext = new LibraryManagementDataContext(connectionString);
            // Lọc danh sách bằng LINQ (chỉ giữ lại các mục chứa từ khóa)
            var items = dbContext.Books
                .Select(b => new {
                    b.BookID,
                    b.Name,
                    SelfName = b.Shelf.ShelfName,
                    b.Publisher,
                    b.DateOfRelease,
                    b.Author,
                    b.Quantity,
                    b.Price
                })
                .ToList();
            dgvBookList.DataSource = items;
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
