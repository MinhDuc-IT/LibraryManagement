using LibraryManagement.Controller;
using System;
using System.Reflection;
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
            //Width = Parent.Width;
            //Height = Parent.Height;

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
                    dgvBookList.DataSource = rs.Data;
                    break;
            }

            //var rs_nq = nq_ctrl.GetAll();
            //switch (rs.ErrCode)
            //{
            //    case Models.EnumErrCode.Error:
            //        MessageBox.Show(rs_nq.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        break;
            //    case Models.EnumErrCode.Empty:
            //        MessageBox.Show(rs_nq.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        break;
            //    case Models.EnumErrCode.Success:
            //        cbx_nhomQuyen.DataSource = rs_nq.Data;
            //        cbx_nhomQuyen.DisplayMember = "TenNhomQuyen";
            //        break;
            //}
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
                    dgvBookList.DataSource = rs.Data;
                    break;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvBookList.DataSource = null;

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
                    dgvBookList.DataSource = rs.Data;
                    break;
            }
        }

        //private void FormSearchBook_Load(object sender, EventArgs e)
        //{
        //    btnReset_Click(sender, e);
        //}

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string query = txtSearch.Text;

        //    if (string.IsNullOrWhiteSpace(query))
        //    {
        //        dgvBookList.DataSource = _searchBookCtrl.GetAll();
        //    }
        //    else
        //    {
        //        dgvBookList.DataSource = _searchBookCtrl.SearchBooks(query);
        //    }
        //}

        //private void btnReset_Click(object sender, EventArgs e)
        //{
        //    dgvBookList.DataSource = _searchBookCtrl.GetAll();
        //}

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
