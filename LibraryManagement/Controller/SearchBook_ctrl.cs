using LibraryManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class SearchBook_ctrl
    {
        private readonly LibraryManagementDataContext db;

        public SearchBook_ctrl()
        {
            db = new LibraryManagementDataContext("Data Source=LAPTOP-AMORBTV2;Initial Catalog=LibraryManagement;Integrated Security=True");
        }
        public FunctionResult<List<Book>> GetAll()
        {
            FunctionResult<List<Book>> rs = new FunctionResult<List<Book>>();
            try
            {
                var qr = db.Books
                    //.Select(b => new
                    //{
                    //    b.BookID,
                    //    b.Name,
                    //    b.ShelfID,
                    //    b.Publisher,
                    //    b.DateOfRelease,
                    //    b.Author,
                    //    b.Quantity,
                    //    b.Price,
                    //    b.IsDeleted,
                        
                    //})
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
                    b.Publisher.ToLower().Contains(query)) 
                    //b.Shelf.ShelfName.ToLower().Contains(query))
                //.Select(b => new
                //{
                //    b.BookID,
                //    b.Name,
                //    b.ShelfID,
                //    b.Publisher,
                //    b.DateOfRelease,
                //    b.Author,
                //    b.Quantity,
                //    b.Price
                //})
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
                // Xử lý ngoại lệ
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs; // Trả về kết quả
        }


        /// <summary>
        /// Lấy tất cả sách trong cơ sở dữ liệu.
        /// </summary>
        /// <returns>Danh sách sách dạng object.</returns>
        //public List<object> GetAllBooks()
        //{
        //    return db.Books
        //        .Select(b => new
        //        {
        //            b.BookID,
        //            b.Name,
        //            ShelfName = b.Shelf.ShelfName,
        //            b.Publisher,
        //            b.DateOfRelease,
        //            b.Author,
        //            b.Quantity,
        //            b.Price
        //        })
        //        .ToList<object>();
        //}

        /// <summary>
        /// Tìm kiếm sách theo từ khóa.
        /// </summary>
        /// <param name="query">Từ khóa tìm kiếm.</param>
        /// <returns>Danh sách sách dạng object phù hợp với từ khóa.</returns>
        //public List<object> SearchBooks(string query)
        //{
        //    query = query.ToLower().Trim();

        //    return db.Books
        //        .Where(b =>
        //            b.Name.ToLower().Contains(query) ||
        //            b.Author.ToLower().Contains(query) ||
        //            b.Publisher.ToLower().Contains(query) ||
        //            b.Shelf.ShelfName.ToLower().Contains(query))
        //        .Select(b => new
        //        {
        //            b.BookID,
        //            b.Name,
        //            ShelfName = b.Shelf.ShelfName,
        //            b.Publisher,
        //            b.DateOfRelease,
        //            b.Author,
        //            b.Quantity,
        //            b.Price
        //        })
        //        .ToList<object>();
        //}
    }
}
