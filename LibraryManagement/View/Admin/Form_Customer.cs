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
    public partial class Form_Customer : Form
    {
        private CustomerController customerCtrl = new CustomerController();
        public Form_Customer()
        {
            InitializeComponent();
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            var cus = customerCtrl.GetAll();
            switch (cus.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(cus.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Model.EnumErrCode.Success:
                    dataGridView_Cus.DataSource = null;
                    dataGridView_Cus.DataSource = cus.Data;
                    break;
            }
        }
    }
}
