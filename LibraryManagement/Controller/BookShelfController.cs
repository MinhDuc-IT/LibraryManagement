using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Model;

namespace LibraryManagement.Controller
{
    internal class BookShelfController
    {
        private DatabaseDataContext db = new DatabaseDataContext();

        /// <summary>
        /// Lấy danh sách tất cả các kệ sách.
        /// </summary>
        /// <returns>Danh sách kệ sách</returns>
        public FunctionResult<List<Shelf>> GetAll()
        {
            FunctionResult<List<Shelf>> result = new FunctionResult<List<Shelf>>();
            try
            {
                var shelves = db.Shelfs.Where(s => s.IsDeleted == false).ToList();

                if (shelves.Any())
                {
                    result.Data = shelves;
                    result.ErrCode = EnumErrCode.Success;
                    result.ErrDesc = "Lấy danh sách kệ sách thành công.";
                }
                else
                {
                    result.Data = null;
                    result.ErrCode = EnumErrCode.Empty;
                    result.ErrDesc = "Không có kệ sách nào trong hệ thống.";
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrCode.Error;
                result.ErrDesc = $"Có lỗi xảy ra: {ex.Message}";
                result.Data = null;
            }

            return result;
        }

        /// <summary>
        /// Lấy danh sách sách theo kệ.
        /// </summary>
        /// <param name="shelfId">ID của kệ sách</param>
        /// <returns>Danh sách sách</returns>
        public FunctionResult<List<BookResponse>> GetBooksByShelf(int shelfId)
        {
            FunctionResult<List<BookResponse>> result = new FunctionResult<List<BookResponse>>();
            try
            {
                var books = db.Books
                    .Where(b => b.ShelfID == shelfId && b.IsDeleted == false)
                    .Select(b => new BookResponse
                    {
                        BookID = b.BookID,
                        Name = b.Name,
                        Author = b.Author,
                        Publisher = b.Publisher,
                        DateOfRelease = b.DateOfRelease,
                        Quantity = b.Quantity,
                        Price = b.Price
                    })
                    .ToList();

                if (books.Any())
                {
                    result.Data = books;
                    result.ErrCode = EnumErrCode.Success;
                    result.ErrDesc = "Lấy danh sách sách thành công.";
                }
                else
                {
                    result.Data = null;
                    result.ErrCode = EnumErrCode.Empty;
                    result.ErrDesc = "Không có sách nào trong kệ.";
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrCode.Error;
                result.ErrDesc = $"Có lỗi xảy ra: {ex.Message}";
                result.Data = null;
            }

            return result;
        }
    }
}
