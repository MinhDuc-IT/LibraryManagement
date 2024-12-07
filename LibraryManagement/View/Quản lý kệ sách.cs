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

namespace LibraryManagement.View
{
    public partial class QLKS : Form
    {
        private LibraryManagementDataContext db = new LibraryManagementDataContext("Data Source=anpt04\\SQLEXPRESS02;Initial Catalog=LibraryManagement;Integrated Security=True");
        Shelf_ctrl ctrl = new Shelf_ctrl();
        public QLKS()
        {
            InitializeComponent();
        }

        private void QLKS_Load(object sender, EventArgs e)
        {
            var shelf = ctrl.GetAll();
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_xoa.Visible == true || btn_sua.Visible == true)
            {
                if (MessageBox.Show("Bạn có chắc muốn chuyển tác vụ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btn_sua.Visible = false;
                    btn_xoa.Visible = false;
                    txt_Shelf_Name.Text = "";
                    return;
                }
            }

            string name = txt_Shelf_Name.Text;

            var shelf = ctrl.Create(name);
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
                    QLKS_Load(sender, e);
                    break;
            }
        }

        private void dataGridView_Shelf_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Hiển thị các nút sửa và xóa
            btn_sua.Visible = true;
            btn_xoa.Visible = true;

            DataGridViewRow selectedRow = dataGridView_Shelf.Rows[e.RowIndex];

            txt_Shelf_ID.Text = selectedRow.Cells["ShelfID"].Value.ToString();
            txt_Shelf_Name.Text = selectedRow.Cells["ShelfName"].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
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
            

            var shelf = ctrl.Edit(id, name);
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
                    QLKS_Load(sender, e);
                    break;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
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
            var shelf = ctrl.Delete(id);
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
                    QLKS_Load(sender, e);
                    break;
            }
            txt_Shelf_Name.Text = "";

            btn_sua.Visible = false;
            btn_xoa.Visible = false;
        }
    }
}
