using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.View.Employee
{
    public partial class Form_Employee : Form
    {
        public Form_Employee()
        {
            InitializeComponent();
        }

        private void Form_Employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Form_CheckOutOfDate form_CheckOfDate = new Form_CheckOutOfDate(this);
            ShareFunction.ShowFormInPanel(form_CheckOfDate, panel_body);
        }

        public void ShowFormInPanel(Form formToShow)
        {
            ShareFunction.ShowFormInPanel(formToShow, panel_body);
        }

        private void Form_Employee_Resize(object sender, EventArgs e)
        {
            if (panel_body.Controls.Count > 0)
            {
                var f = (Form)panel_body.Controls[0];
                f.Width = panel_body.Width;
                f.Height = panel_body.Height;
            }
        }
    }
}
