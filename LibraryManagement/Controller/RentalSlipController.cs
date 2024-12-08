using LibraryManagement.DTO;
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

        public FunctionResult<List<RentalSlipDTO>> GetRentalSlipsByCustomer(int customerID)
        {
            var result = new FunctionResult<List<RentalSlipDTO>>();

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

                //from rs in db.RentalSlips
                //join rsd in db.RentalSlipDetails on rs.RentalSlipID equals rsd.RentalSlipID
                //where rs.CustomerID == customerID

                var rentalSlips = from rs in db.RentalSlips
                                  where rs.CustomerID == customerID
                                  select new RentalSlipDTO
                                  {
                                      RentalSlipID = rs.RentalSlipID,
                                      CustomerID = rs.CustomerID,
                                      RentalDate = rs.RentalDate,
                                      DueDate = rs.DueDate,
                                      TotalFee = rs.TotalFee,
                                      RentalSlipDetails = rs.RentalSlipDetails.Select(rsd => new RentalSlipDetailDTO
                                      {
                                          RentalSlipDetailID = rsd.RentalSlipDetailID,
                                          ReturnStatus = rsd.ReturnStatus
                                      }).ToList()
                                  };


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

        public FunctionResult<List<BookDTO>> GetAllBooks()
        {
            FunctionResult<List<BookDTO>> rs = new FunctionResult<List<BookDTO>>();
            try
            {
                var qr = db.Books
                    .Where(b => b.IsDeleted == false) // Lọc các sách chưa bị xóa
                    .Select(b => new BookDTO
                    {
                        BookID = b.BookID,
                        Name = b.Name,
                        Author = b.Author,
                        Publisher = b.Publisher,
                        Price = b.Price,
                        DateOfRelease = b.DateOfRelease,
                        Image = b.Image != null ? b.Image.ToArray() : null
                    })
                    .ToList();

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
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs;
        }

        //public FunctionResult<List<BookDTO>> GetAllBooks()
        //{
        //    FunctionResult<List<BookDTO>> rs = new FunctionResult<List<BookDTO>>();
        //    try
        //    {
        //        // Truy vấn dữ liệu từ bảng Books, loại bỏ các sách bị xóa
        //        var books = db.Books
        //            .Where(b => b.IsDeleted == false)
        //            .Select(b => new BookDTO
        //            {
        //                BookID = b.BookID,
        //                Name = b.Name,
        //                ShelfID = b.ShelfID,
        //                Publisher = b.Publisher,
        //                DateOfRelease = b.DateOfRelease,
        //                Author = b.Author,
        //                Quantity = b.Quantity,
        //                Price = b.Price,
        //                Description = b.Description
        //            })
        //            .ToList();

        //        if (books.Any())
        //        {
        //            rs.Data = books;
        //            rs.ErrCode = EnumErrCode.Success;
        //            rs.ErrDesc = "Lấy dữ liệu thành công.";
        //        }
        //        else
        //        {
        //            rs.Data = null;
        //            rs.ErrCode = EnumErrCode.Empty;
        //            rs.ErrDesc = "Không tìm thấy dữ liệu.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        rs.ErrCode = EnumErrCode.Error;
        //        rs.ErrDesc = "Có lỗi xảy ra trong quá trình lấy dữ liệu sách. Chi tiết lỗi: " + ex.Message;
        //        rs.Data = null;
        //    }

        //    return rs; // Trả về kết quả
        //}




        //public FunctionResult<List<Book>> SearchBooks(string query)
        //{
        //    FunctionResult<List<Book>> rs = new FunctionResult<List<Book>>();
        //    try
        //    {
        //        var qr = db.Books
        //        .Where(b =>
        //            b.Name.ToLower().Contains(query) ||
        //            b.Author.ToLower().Contains(query) ||
        //            b.Publisher.ToLower().Contains(query)).ToList();

        //        if (qr.Any())
        //        {
        //            rs.Data = qr;
        //            rs.ErrCode = EnumErrCode.Success;
        //            rs.ErrDesc = "Lấy dữ liệu thành công.";
        //        }
        //        else
        //        {
        //            rs.Data = null;
        //            rs.ErrCode = EnumErrCode.Empty;
        //            rs.ErrDesc = "Không tìm thấy dữ liệu.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý ngoại lệ
        //        rs.ErrCode = EnumErrCode.Error;
        //        rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
        //        rs.Data = null;
        //    }

        //    return rs; // Trả về kết quả
        //}

        public FunctionResult<List<BookDTO>> SearchBooks(string query)
        {
            FunctionResult<List<BookDTO>> rs = new FunctionResult<List<BookDTO>>();
            try
            {
                // Truy vấn tìm kiếm theo tên, tác giả và nhà xuất bản
                var books = db.Books
                    .Where(b =>
                        b.IsDeleted == false &&
                        (b.Name.ToLower().Contains(query.ToLower()) ||
                         b.Author.ToLower().Contains(query.ToLower()) ||
                         b.Publisher.ToLower().Contains(query.ToLower())))
                    .Select(b => new BookDTO
                    {
                        BookID = b.BookID,
                        Name = b.Name,
                        ShelfID = b.ShelfID,
                        Publisher = b.Publisher,
                        DateOfRelease = b.DateOfRelease,
                        Author = b.Author,
                        Quantity = b.Quantity,
                        Price = b.Price,
                        Description = b.Description,
                        Image = b.Image != null ? b.Image.ToArray() : null
                    })
                    .ToList();

                if (books.Any())
                {
                    rs.Data = books;
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
                rs.ErrDesc = "Có lỗi xảy ra trong quá trình tìm kiếm dữ liệu sách. Chi tiết lỗi: " + ex.Message;
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

        public byte[] GetBookImageById(int bookID)
        {
            // Truy vấn sách theo BookID và trả về ảnh (nếu có)
            var book = db.Books.FirstOrDefault(b => b.BookID == bookID);
            return book.Image != null ? book.Image.ToArray() : null; // Trả về ảnh dưới dạng byte[] hoặc null nếu không có
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
