using LibraryManagement.DTO;
using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class SearchBookController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<List<SeacrchBookResponse>> GetAll()
        {
            FunctionResult<List<SeacrchBookResponse>> rs = new FunctionResult<List<SeacrchBookResponse>>();
            try
            {
                var qr = db.Books
                    .Select(b => new SeacrchBookResponse
                    {
                        BookID = b.BookID,
                        Name = b.Name,
                        ShelfName = b.Shelf.ShelfName,
                        Publisher = b.Publisher,
                        DateOfRelease = b.DateOfRelease,
                        Author = b.Author,
                        Quantity = b.Quantity,
                        Price = b.Price,
                        BookImage = b.Image.ToArray(),
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
        public FunctionResult<List<SeacrchBookResponse>> SearchBooks(string query)
        {
            FunctionResult<List<SeacrchBookResponse>> rs = new FunctionResult<List<SeacrchBookResponse>>();
            try
            {
                var qr = db.Books
                .Where(b => string.IsNullOrEmpty(query) ||
                    b.Name.ToLower().Contains(query) ||
                    b.Author.ToLower().Contains(query) ||
                    b.Publisher.ToLower().Contains(query) ||
                    b.Shelf.ShelfName.ToLower().Contains(query))
                    .Select(b => new SeacrchBookResponse
                    {
                        BookID = b.BookID,
                        Name = b.Name,
                        ShelfName = b.Shelf.ShelfName,
                        Publisher = b.Publisher,
                        DateOfRelease = b.DateOfRelease,
                        Author = b.Author,
                        Quantity = b.Quantity,
                        Price = b.Price,
                        BookImage = b.Image.ToArray(),
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
    }
}
