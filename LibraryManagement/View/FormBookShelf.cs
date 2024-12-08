using LibraryManagement.Controller;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagement.View
{
    public partial class FormBookShelf : Form
    {
        private BookShelfController bookShelfController = new BookShelfController();

        public FormBookShelf()
        {
            InitializeComponent();
        }

        private void FormBookShelf_Load(object sender, EventArgs e)
        {
            LoadShelvesToComboBox();
        }

        private void LoadShelvesToComboBox()
        {
            var shelves = bookShelfController.GetAll();
            if (shelves.ErrCode == EnumErrCode.Success && shelves.Data != null)
            {
                comboBox_Shelves.DataSource = shelves.Data;
                comboBox_Shelves.DisplayMember = "ShelfName";
                comboBox_Shelves.ValueMember = "ShelfID";
            }
            else
            {
                MessageBox.Show(shelves.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox_Shelves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Shelves.SelectedValue is int shelfId)
            {
                LoadBooksByShelf(shelfId);
            }
        }

        private void LoadBooksByShelf(int shelfId)
        {
            var books = bookShelfController.GetBooksByShelf(shelfId);
            if (books.ErrCode == EnumErrCode.Success && books.Data != null)
            {
                dataGridView_Books.DataSource = books.Data;
            }
            else
            {
                dataGridView_Books.DataSource = null;
                MessageBox.Show(books.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
