using LibraryManagement.DTO;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class rentalSlipDetailController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<RentalSlipDetail> UpdateRentalSlipDetail(int rentalSlipDetailId, int quantity)
        {
            FunctionResult<RentalSlipDetail> rs = new FunctionResult<RentalSlipDetail>();
            try
            {
                var rentalSlipDetail = db.RentalSlipDetails.FirstOrDefault(x => x.RentalSlipDetailID == rentalSlipDetailId);
                if (rentalSlipDetail != null)
                {
                    var rsdQuantity = rentalSlipDetail.Quantity - quantity;
                    if (rsdQuantity == 0)
                    {
                        rentalSlipDetail.ReturnStatus = true;
                    }
                    rentalSlipDetail.Quantity = rsdQuantity;
                    db.SubmitChanges();
                    rs.ErrCode = EnumErrCode.Success;
                    rs.Data = rentalSlipDetail;
                    rs.ErrDesc = "Cập chi tiết phiếu thuê thành công";
                }
                else
                {
                    rs.ErrCode = EnumErrCode.Success;
                    rs.Data = null;
                    rs.ErrDesc = "Không thể tìm thấy chi tiết phiếu thuê với id " + rentalSlipDetailId;
                }
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = null;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<int> getAllBooksOnLoan()
        {
            FunctionResult<int> rs = new FunctionResult<int>();
            try
            {
                var totalBooks = db.RentalSlipDetails
                                     .Sum(rsd => rsd.Quantity);
                rs.ErrCode = EnumErrCode.Success;
                rs.Data = totalBooks;
                rs.ErrDesc = "Lấy số lượng sách đang cho thuê thành công";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = 0;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<List<RecentBorrowBooks>> GetAllRecentBorrowBooks()
        {
            FunctionResult<List<RecentBorrowBooks>> rs = new FunctionResult<List<RecentBorrowBooks>>();
            try
            {
                var query = (from rsd in db.RentalSlipDetails
                            join rsl in db.RentalSlips on rsd.RentalSlipID equals rsl.RentalSlipID
                            join b in db.Books on rsd.BookID equals b.BookID
                            join cus in db.Customers on rsl.CustomerID equals cus.CustomerID
                             //where rsd.ReturnStatus == false
                             orderby rsd.RentalSlipDetailID descending
                            
                            select new RecentBorrowBooks
                            {
                                rentalSlipDetailId = rsd.RentalSlipDetailID,
                                retalSlipId = rsd.RentalSlipID,
                                bookId = b.BookID,
                                customerName = cus.Name,
                                RentalDate = rsl.RentalDate,
                                DueDate = rsl.DueDate,
                                Quantity = rsd.Quantity,
                                RentalFee = rsd.RentalFee,
                                bookName = b.Name,
                                bookImage = b.Image.ToArray(),
                            }).Take(20);

                var RecentBorrowBooks = query.ToList();
                if (RecentBorrowBooks.Any())
                {
                    rs.Data = RecentBorrowBooks;
                    rs.ErrCode = EnumErrCode.Success;
                    rs.ErrDesc = "Lấy dữ liệu thành công.";
                }
                else
                {
                    rs.Data = null;
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "Không tìm thấy dữ liệu.";
                }
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong quá trình lấy dữ liệu. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }
            return rs;
        }
    }
}
