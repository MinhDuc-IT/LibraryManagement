using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class ReturnHistoryController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<ReturnHistory> AddReturnHistory(int rentalSlipDetailId, int quantity, decimal AmountPaid)
        {
            FunctionResult<ReturnHistory> rs = new FunctionResult<ReturnHistory>();
            try
            {
                ReturnHistory returnHistory = new ReturnHistory();
                var dateNow = DateTime.Now;
                returnHistory.RentalSlipDetailID = rentalSlipDetailId;
                returnHistory.ReturnDate = dateNow;
                returnHistory.Quantity = quantity;
                returnHistory.AmountPaid = AmountPaid;

                db.ReturnHistories.InsertOnSubmit(returnHistory);
                db.SubmitChanges();
                rs.ErrCode = EnumErrCode.Success;
                rs.Data = returnHistory;
                rs.ErrDesc = "Thêm mới lich sử hoàn trả thành công";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = null;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<decimal> getRevenueByDay()
        {
            FunctionResult<decimal> rs = new FunctionResult<decimal>();
            try
            {
                var today = DateTime.Now;
                var totalRevenue = db.ReturnHistories
                                     .Where(rh => rh.ReturnDate == today)
                                     .Sum(rh => rh.AmountPaid); 

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = totalRevenue ;
                rs.ErrDesc = "Lấy doanh thu trong ngày thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = 0;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<decimal> getRevenueByWeek()
        {
            FunctionResult<decimal> rs = new FunctionResult<decimal>();
            try
            {
                var today = DateTime.Now;
                var startOfWeek = today.AddDays(-(int)(today.DayOfWeek == DayOfWeek.Sunday ? 7 : Convert.ToInt32(today.DayOfWeek)) + (int)DayOfWeek.Monday);

                var totalRevenue = db.ReturnHistories
                                     .Where(rh => rh.ReturnDate >= startOfWeek && rh.ReturnDate <= today)
                                     .Sum(rh => rh.AmountPaid);

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = totalRevenue;
                rs.ErrDesc = "Lấy doanh thu trong tuần thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = 0;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<decimal> getRevenueByMonth()
        {
            FunctionResult<decimal> rs = new FunctionResult<decimal>();
            try
            {
                var today = DateTime.Now;
                var startOfMonth = new DateTime(today.Year, today.Month, 1);
                var totalRevenue = db.ReturnHistories
                                     .Where(rh => rh.ReturnDate >= startOfMonth && rh.ReturnDate <= today)
                                     .Sum(rh => rh.AmountPaid);

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = totalRevenue;
                rs.ErrDesc = "Lấy doanh thu trong tháng thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = 0;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
    }
}
