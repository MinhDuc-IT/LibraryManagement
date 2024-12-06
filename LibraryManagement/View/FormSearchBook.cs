using LibraryManagement.Controller;
using System;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormSearchBook : Form
    {
        private readonly SearchBook_ctrl _searchBookCtrl;

        public FormSearchBook()
        {
            InitializeComponent();
            _searchBookCtrl = new SearchBook_ctrl();
        }

        private void FormSearchBook_Load(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                dgvBookList.DataSource = _searchBookCtrl.GetAllBooks();
            }
            else
            {
                dgvBookList.DataSource = _searchBookCtrl.SearchBooks(query);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvBookList.DataSource = _searchBookCtrl.GetAllBooks();
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
