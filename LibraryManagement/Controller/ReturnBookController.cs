using LibraryManagement.DTO;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class ReturnBookController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<List<RentalSlipOfCustomer>> GetAllRentalSlipOfCustomer(string cccd)
        {
            FunctionResult<List<RentalSlipOfCustomer>> rs = new FunctionResult<List<RentalSlipOfCustomer>>();
            try
            {
                var customer = db.Customers.FirstOrDefault(x => x.CitizenIdentification == cccd);
                if (customer == null)
                {
                    rs.Data = null;
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "Không tìm thấy thông tin khách hàng.";
                    return rs;
                }

                int customerId = customer.CustomerID;

                var query = from rsl in db.RentalSlips
                            join rsd in db.RentalSlipDetails on rsl.RentalSlipID equals rsd.RentalSlipID
                            join b in db.Books on rsd.BookID equals b.BookID
                            where rsl.CustomerID == customerId && rsd.ReturnStatus == false
                            select new RentalSlipOfCustomer
                            {
                                rentalSlipDetailId = rsd.RentalSlipDetailID,
                                retalSlipId = rsd.RentalSlipID,
                                bookId = b.BookID,
                                customerName = customer.Name,
                                RentalDate = rsl.RentalDate,
                                DueDate = rsl.DueDate,
                                Quantity = rsd.Quantity,
                                RentalFee = rsd.RentalFee,
                                bookName = b.Name,
                                bookImage = b.Image.ToArray(),
                            };

                var rentalSlipList = query.ToList();
                if (rentalSlipList.Any())
                {
                    rs.Data = rentalSlipList;
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
