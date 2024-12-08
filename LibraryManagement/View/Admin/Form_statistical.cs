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

namespace LibraryManagement.View.Admin
{
    public partial class Form_statistical : Form
    {
        private StatisticalController statisticalCtrl = new StatisticalController();
        public Form_statistical()
        {
            InitializeComponent();
            dtp_revenue.Format = DateTimePickerFormat.Custom;
            dtp_revenue.CustomFormat = "yyyy";
            dtp_revenue.ShowUpDown = true;
        }
        private void loadChartData(int year)
        {
            chart.Series["ChartBDC"].Points.Clear(); 

            var list = statisticalCtrl.GetRevenueByYear(year);
            if (list.ErrCode == EnumErrCode.Success && list.Data != null)
            {
                foreach (var revenue in list.Data)
                {
                    int month = revenue.Key;
                    decimal amount = revenue.Value;

                    chart.Series["ChartBDC"].Points.AddXY($"Tháng {month}", amount);
                }
            }
            else
            {
                MessageBox.Show(list.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Đặt khoảng cách giữa các tháng trên trục X
            chart.ChartAreas[0].AxisX.Interval = 1;
        }
        private void loadCustomerData(int year)
        {
            var data = statisticalCtrl.GetTotalCustomersByYear(year);
            if (data.ErrCode == EnumErrCode.Success && data.Data != null)
            {
                lb_CustomerNum.Text = $"{data.Data}";
            }
            else
            {
                MessageBox.Show(data.ErrDesc, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_statistical_Load(object sender, EventArgs e)
        {
            var Year = DateTime.Now.Year;
            loadChartData(Year);
            loadCustomerData(Year);
        }

        private void dtp_revenue_ValueChanged(object sender, EventArgs e)
        {
            int year = dtp_revenue.Value.Year;
            loadChartData(year);
            loadCustomerData(year);
        }
    }
}
