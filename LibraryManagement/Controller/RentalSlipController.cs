using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    class RentalSlipController
    {
        private DatabaseDataContext db = new DatabaseDataContext();

        public FunctionResult<List<RentalSlip>> GetAll()
        {
            FunctionResult<List<RentalSlip>> rs = new FunctionResult<List<RentalSlip>>();
            try
            {
                var qr = db.RentalSlips.ToList();

                if (qr.Any())
                {
                    rs.Data = qr;
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
                // Xử lý ngoại lệ
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs; // Trả về kết quả
        }

        public FunctionResult<List<RentalSlip>> GetRentalSlipsByCustomer(int customerID)
        {
            var result = new FunctionResult<List<RentalSlip>>();

            try
            {
                bool customerExists = db.Customers.Any(rs => rs.CustomerID == customerID);
                if (!customerExists)
                {
                    result.ErrCode = EnumErrCode.InvalidInput;
                    result.ErrDesc = "Không tìm thấy khách hàng này trong hệ thống.";
                    result.Data = null;
                    return result;
                }

                var rentalSlips = from rs in db.RentalSlips
                                  join rsd in db.RentalSlipDetails on rs.RentalSlipID equals rsd.RentalSlipID
                                  where rs.CustomerID == customerID
                                  select rs;

                if (!rentalSlips.Any())
                {
                    result.ErrCode = EnumErrCode.Empty;
                    result.ErrDesc = "Không tìm thấy phiếu thuê cho khách hàng này.";
                    result.Data = null;
                }
                else
                {
                    result.ErrCode = EnumErrCode.Success;
                    result.ErrDesc = "Lấy phiếu thuê thành công.";
                    result.Data = rentalSlips.ToList();
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrCode.Error;
                result.ErrDesc = $"Lỗi hệ thống: {ex.Message}";
                result.Data = null;
            }

            return result;
        }


        public FunctionResult<List<Book>> GetAllBooks()
        {
            FunctionResult<List<Book>> rs = new FunctionResult<List<Book>>();
            try
            {
                var qr = db.Books.ToList();

                if (qr.Any())
                {
                    rs.Data = qr;
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
                // Xử lý ngoại lệ
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs; // Trả về kết quả
        }
        public FunctionResult<List<Book>> SearchBooks(string query)
        {
            FunctionResult<List<Book>> rs = new FunctionResult<List<Book>>();
            try
            {
                var qr = db.Books
                .Where(b =>
                    b.Name.ToLower().Contains(query) ||
                    b.Author.ToLower().Contains(query) ||
                    b.Publisher.ToLower().Contains(query)).ToList();

                if (qr.Any())
                {
                    rs.Data = qr;
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
                // Xử lý ngoại lệ
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs; // Trả về kết quả
        }

        public FunctionResult<int> AddRentalSlip(RentalSlip rentalSlip)
        {
            try
            {
                db.RentalSlips.InsertOnSubmit(rentalSlip);
                db.SubmitChanges();
                return new FunctionResult<int>
                {
                    ErrCode = EnumErrCode.Success,
                    ErrDesc = "Thêm phiếu thuê thành công.",
                    Data = rentalSlip.RentalSlipID
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<int>
                {
                    ErrCode = EnumErrCode.Error,
                    ErrDesc = $"Lỗi khi thêm phiếu thuê: {ex.Message}",
                    Data = -1
                };
            }
        }

        public FunctionResult<bool> AddRentalSlipDetails(List<RentalSlipDetail> rentalSlipDetails)
        {
            try
            {
                db.RentalSlipDetails.InsertAllOnSubmit(rentalSlipDetails);
                db.SubmitChanges();
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrCode.Success,
                    ErrDesc = "Thêm chi tiết phiếu thuê thành công.",
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new FunctionResult<bool>
                {
                    ErrCode = EnumErrCode.Error,
                    ErrDesc = $"Lỗi khi thêm chi tiết phiếu thuê: {ex.Message}",
                    Data = false
                };
            }
        }
    }
}
