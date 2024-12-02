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
        public Form_DashBoard()
        {
            InitializeComponent();
        }

        private void Form_DashBoard_Resize(object sender, EventArgs e)
        {
            int panelWidth = (flowPanel.Width - (flowPanel.Padding.Left + flowPanel.Padding.Right)) / 4;

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
