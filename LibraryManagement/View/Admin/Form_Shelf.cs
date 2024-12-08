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

namespace LibraryManagement.View.Admin
{
    public partial class Form_Shelf : Form
    {
        private ShelfController shelfCtrl = new ShelfController();
        public Form_Shelf()
        {
            InitializeComponent();
        }

        private void resetInput()
        {
            txt_Shelf_ID.Text = "";
            txt_Shelf_Name.Text = "";
            btn_add.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_Shelf_Name.Text;

            var shelf = shelfCtrl.Create(name);
            switch (shelf.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(shelf.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(shelf.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Shelf.DataSource = shelf.Data;
                    Form_Shelf_Load(sender, e);
                    resetInput();
                    break;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa kệ sách này không?",
                                          "Xác nhận xóa",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            int id = int.Parse(txt_Shelf_ID.Text);
            var shelf = shelfCtrl.Delete(id);
            switch (shelf.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(shelf.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(shelf.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Shelf.DataSource = shelf.Data;
                    Form_Shelf_Load(sender, e);
                    resetInput();
                    break;
            }
            txt_Shelf_Name.Text = "";
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa kệ sách này không?",
                                          "Xác nhận sửa",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);


            if (result == DialogResult.No)
            {
                return;
            }
            int id = int.Parse(txt_Shelf_ID.Text);
            string name = txt_Shelf_Name.Text;


            var shelf = shelfCtrl.Edit(id, name);
            switch (shelf.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(shelf.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(shelf.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Shelf.DataSource = shelf.Data;
                    Form_Shelf_Load(sender, e);
                    resetInput();
                    break;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void Form_Shelf_Load(object sender, EventArgs e)
        {
            var shelf = shelfCtrl.GetAll();
            switch (shelf.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(shelf.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(shelf.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Shelf.DataSource = null;
                    dataGridView_Shelf.DataSource = shelf.Data;
                    break;
            }
        }

        private void dataGridView_Shelf_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add.Enabled = false;
            DataGridViewRow selectedRow = dataGridView_Shelf.Rows[e.RowIndex];

            txt_Shelf_ID.Text = selectedRow.Cells["ShelfID"].Value.ToString();
            txt_Shelf_Name.Text = selectedRow.Cells["ShelfName"].Value.ToString();
        }
    }
}
