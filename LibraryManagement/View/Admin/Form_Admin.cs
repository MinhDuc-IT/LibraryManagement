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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
            OpenChildForm(new Form_DashBoard());
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
        private void btn_Book_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Book());
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_DashBoard());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_User());
        }
    }
}
