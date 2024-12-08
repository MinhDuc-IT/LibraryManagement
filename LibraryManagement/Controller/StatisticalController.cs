using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class StatisticalController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<Dictionary<int, decimal>> GetRevenueByYear(int year)
        {
            FunctionResult<Dictionary<int, decimal>> rs = new FunctionResult<Dictionary<int, decimal>>();
            try
            {
                Dictionary<int, decimal> monthlyRevenue = new Dictionary<int, decimal>();

                for (int month = 1; month <= 12; month++)
                {
                    DateTime startDate = new DateTime(year, month, 1);
                    DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                    decimal totalRevenue = db.ReturnHistories
                                             .Where(rh => rh.ReturnDate >= startDate && rh.ReturnDate <= endDate)
                                             .Sum(rh => (decimal?)rh.AmountPaid) ?? 0;

                    monthlyRevenue.Add(month, totalRevenue);
                }

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = monthlyRevenue;
                rs.ErrDesc = "Lấy doanh thu theo tháng trong năm thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = null;
                rs.ErrDesc = "Có lỗi xảy ra: " + ex.Message;
            }
            return rs;
        }
        public FunctionResult<int> GetTotalCustomersByYear(int year)
        {
            FunctionResult<int> rs = new FunctionResult<int>();

            try
            {
                int totalCustomers = db.Customers
                                       .Where(c => c.StartDate.Year == year && c.IsDeleted == false)
                                       .Count();

                rs.Data = totalCustomers;
                rs.ErrCode = EnumErrCode.Success;
                rs.ErrDesc = "Lấy tổng số khách hàng thành công.";
            }
            catch (Exception ex)
            {
                rs.Data = 0;
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = $"Có lỗi xảy ra: {ex.Message}";
            }
            return rs;
        }

    }
}
