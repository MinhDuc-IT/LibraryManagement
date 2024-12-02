using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class BookController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<List<Shelf>> GetAllShelf()
        {
            FunctionResult<List<Shelf>> rs = new FunctionResult<List<Shelf>>();
            try
            {
                var qr = db.Shelfs.ToList();

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
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu nhóm quyền. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs;
        }
        public FunctionResult<Book> AddBook(string bookName, string description, string shelfID, string quantity, string publisher, string authorName,
            string price, DateTime? dateOfRelease, byte[] image)
        {
            FunctionResult<Book> rs = new FunctionResult<Book>();
            try
            {
                if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity))
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Vui lòng điền đầy đủ thông tin cho sách";
                    return rs;
                }
                if (image == null || image.Length == 0)
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Hình ảnh không được để trống.";
                    return rs;
                }
                if (!int.TryParse(quantity, out int quantityBook) || quantityBook < 0)
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Số lượng sách nhập vào phải là 1 số dương.";
                    return rs;
                }
                if (!decimal.TryParse(price, out decimal parsedPrice) || parsedPrice < 0)
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Vui lòng nhập giá hợp lệ.";
                    return rs;
                }
                Book newBook = new Book
                {
                    Name = bookName,
                    Description = description,
                    ShelfID = Convert.ToInt32(shelfID),
                    Quantity = quantityBook,
                    Publisher = publisher,
                    Author = authorName,
                    Price = parsedPrice,
                    DateOfRelease = dateOfRelease.Value,
                    Image = image
                };

                db.Books.InsertOnSubmit(newBook);
                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = newBook;
                rs.ErrDesc = "Thêm sách thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = null;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<List<Book>> GetAll()
        {
            FunctionResult<List<Book>> rs = new FunctionResult<List<Book>>();
            try
            {
                var listBooks = db.Books.ToList();
                if (listBooks == null)
                {
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "Không thể load dữ liệu";
                    rs.Data = null;
                    return rs;
                }
                rs.ErrCode = EnumErrCode.Success;
                rs.ErrDesc = "Lấy dữ liệu thành công";
                rs.Data = listBooks;
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs;
        }
        public FunctionResult<List<Book>> DeleteBook(int id)
        {
            FunctionResult<List<Book>> rs = new FunctionResult<List<Book>>();
            try
            {
                var bookToDelete = db.Books.SingleOrDefault(b => b.BookID == id);

                if (bookToDelete == null)
                {
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "Không tìm thấy sách với ID: " + id;
                    rs.Data = null;
                    return rs;
                }

                db.Books.DeleteOnSubmit(bookToDelete);
                db.SubmitChanges();

                var remainBooks = db.Books.ToList();

                rs.ErrCode = EnumErrCode.Success;
                rs.ErrDesc = "Xóa sách thành công.";
                rs.Data = remainBooks;
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra khi xóa sách. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs;
        }
        public FunctionResult<Book> EditBook(int id, string bookName, string description, string shelfID, string quantity, string publisher, string authorName,
            string price, DateTime? dateOfRelease, byte[] image)
        {
            FunctionResult<Book> rs = new FunctionResult<Book>();
            try
            {
                Book bookEdit = db.Books.FirstOrDefault(b => b.BookID == id);
                if (bookEdit != null)
                {
                    if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity))
                    {
                        rs.ErrCode = EnumErrCode.IsValidInput;
                        rs.Data = null;
                        rs.ErrDesc = "Vui lòng điền đầy đủ thông tin cho sách";
                        return rs;
                    }
                    if (image == null || image.Length == 0)
                    {
                        rs.ErrCode = EnumErrCode.IsValidInput;
                        rs.Data = null;
                        rs.ErrDesc = "Hình ảnh không được để trống.";
                        return rs;
                    }

                    if (!int.TryParse(quantity, out int quantityBook) || quantityBook < 0)
                    {
                        rs.ErrCode = EnumErrCode.IsValidInput;
                        rs.Data = null;
                        rs.ErrDesc = "Số lượng sách nhập vào phải là 1 số dương.";
                        return rs;
                    }
                    if (!decimal.TryParse(price, out decimal parsedPrice) || parsedPrice < 0)
                    {
                        rs.ErrCode = EnumErrCode.IsValidInput;
                        rs.Data = null;
                        rs.ErrDesc = "Vui lòng nhập giá hợp lệ.";
                        return rs;
                    }
                    bookEdit.Name = bookName;
                    bookEdit.Description = description;
                    bookEdit.ShelfID = Convert.ToInt32(shelfID);
                    bookEdit.Quantity = quantityBook;
                    bookEdit.Publisher = publisher;
                    bookEdit.Author = authorName;
                    bookEdit.Price = parsedPrice;
                    bookEdit.DateOfRelease = dateOfRelease.Value;
                    bookEdit.Image = image;

                    db.SubmitChanges();
                    rs.ErrCode = EnumErrCode.Success;
                    rs.Data = bookEdit;
                    rs.ErrDesc = "Sửa sách thành công.";
                }
                else
                {
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.Data = bookEdit;
                    rs.ErrDesc = "Không tìm thấy sách với ID: " + id;
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
    }
}
