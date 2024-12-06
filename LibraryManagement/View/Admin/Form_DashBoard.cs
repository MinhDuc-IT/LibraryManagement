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
    public partial class Form_DashBoard : Form
    {
        private BookController bookCtrl = new BookController();
        private UserController userCtrl = new UserController();
        public Form_DashBoard()
        {
            InitializeComponent();
            loadBookData();
            loadUserData();
        }

        private void loadBookData()
        {
            var rs = bookCtrl.GetAll();
            lb_BookNum.Text = rs.Data.Count.ToString();
        }

        private void loadUserData()
        {
            var rs = userCtrl.GetAll();
            lb_userNum.Text = rs.Data.Count.ToString();
            int employeeNum = 0;
            int adminNum = 0;
            for (int i = 0; i < rs.Data.Count; i++)
            {
                var user = rs.Data[i];
                if (user.Role == "Admin")
                {
                    adminNum++;
                }
                else
                {
                    employeeNum++;
                }
            }
            lb_AdminNum.Text = adminNum.ToString();
            lb_EmployeeNum.Text = employeeNum.ToString();
        }

        private void Form_DashBoard_Resize(object sender, EventArgs e)
        {
            int panelWidth = (flowPanel.Width - (flowPanel.Padding.Left + flowPanel.Padding.Right + 21)) / 4;

            foreach (Control control in flowPanel.Controls)
            {
                if (control is Panel panel)
                {
                    panel.Width = panelWidth;
                    //panel.Height = 170; // Chiều cao cố định
                }
            }
        }
    }
}
