using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.View.Employee;

namespace LibraryManagement.View
{
    public partial class Form_Employee : Form
    {
        public Form_Employee()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Return_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ReturnBooks());
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Customer());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Search());
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }
    }
}
