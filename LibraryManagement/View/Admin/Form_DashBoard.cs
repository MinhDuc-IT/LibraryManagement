using LibraryManagement.Controller;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private ReturnHistoryController returnHistoryCtrl = new ReturnHistoryController();
        private rentalSlipDetailController rentalSlipDetailCtrl = new rentalSlipDetailController();
        private CustomerController customerCtrl = new CustomerController();
        public Form_DashBoard()
        {
            InitializeComponent();
            loadBookData();
            loadUserData();
            loadRevenue();
            loadCustomerData();
        }
        private void loadCustomerData()
        {
            var totalCustomer = customerCtrl.getTotalCustomer().Data;
            var customerInWeek = customerCtrl.getCustomerByWeek().Data;
            var customerInMonth = customerCtrl.getCustomerByMonth().Data;

            lb_CusNum.Text = totalCustomer.ToString();
            lb_CusInWeek.Text = customerInWeek.ToString();
            lb_cusInMonth.Text = customerInMonth.ToString();
        }

        private void loadBookData()
        {
            var rs = bookCtrl.GetAll();
            lb_BookTitleNum.Text = rs.Data.Count.ToString();
            long totalBook = 0;
            foreach(Book book in rs.Data)
            {
                totalBook += book.Quantity;
            }
            lb_BookNum.Text = totalBook.ToString();
            var BookNumOnLoan = rentalSlipDetailCtrl.getAllBooksOnLoan().Data.ToString();
            lb_BookNumOnLoan.Text = BookNumOnLoan;
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

        private void loadRevenue()
        {
            var revenueInDay = returnHistoryCtrl.getRevenueByDay().Data;
            var revenueInWeek = returnHistoryCtrl.getRevenueByWeek().Data;
            var revenueInMonth = returnHistoryCtrl.getRevenueByMonth().Data;

            lb_dayRevenue.Text = revenueInDay.ToString("N0");
            lb_weekRevenue.Text = revenueInWeek.ToString("N0");
            lb_monthRevenue.Text = revenueInMonth.ToString("N0");
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

        private void Form_DashBoard_Load(object sender, EventArgs e)
        {
            var rs = rentalSlipDetailCtrl.GetAllRecentBorrowBooks();
            var list = new List<DTO.RecentBorrowBooks>();
            switch (rs.ErrCode)
            {
                case Model.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Model.EnumErrCode.Success:
                    //MessageBox.Show(rs.ErrDesc, "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list = rs.Data;
                    dataGridView1.DataSource = null;

                    if (list.Any())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Customer Name", typeof(string));
                        dt.Columns.Add("RSID", typeof(int));
                        dt.Columns.Add("Rental Date", typeof(DateTime));
                        dt.Columns.Add("Due Date", typeof(DateTime));
                        dt.Columns.Add("RSDID", typeof(int));
                        dt.Columns.Add("Rental Fee", typeof(string));
                        dt.Columns.Add("Quantity", typeof(int));
                        dt.Columns.Add("BookId", typeof(int));
                        dt.Columns.Add("Book Name", typeof(string));
                        dt.Columns.Add("Image", typeof(Image));

                        foreach (var rsl in list)
                        {
                            Image img = null;

                            if (rsl.bookImage != null)
                            {
                                img = ByteArrayToImage(rsl.bookImage);
                            }

                            string rentalFeeFormatted = rsl.RentalFee.ToString("N0");

                            dt.Rows.Add(rsl.customerName, rsl.retalSlipId, rsl.RentalDate, rsl.DueDate, rsl.rentalSlipDetailId, rentalFeeFormatted, rsl.Quantity, rsl.bookId, rsl.bookName, img);
                        }

                        dataGridView1.DataSource = dt;

                        DataGridViewImageColumn imgColumn = (DataGridViewImageColumn)dataGridView1.Columns["Image"];
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                    break;
                case Model.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrDesc, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
