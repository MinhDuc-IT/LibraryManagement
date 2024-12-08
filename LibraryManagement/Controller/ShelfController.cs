using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class ShelfController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<List<Shelf>> GetAll()
        {
            FunctionResult<List<Shelf>> shelf = new FunctionResult<List<Shelf>>();
            try
            {
                var qr = db.Shelfs.Where(s => s.IsDeleted == false).ToList();

                if (qr.Any())
                {
                    shelf.Data = qr;
                    shelf.ErrCode = EnumErrCode.Success;
                    shelf.ErrDesc = "Lấy dữ liệu kệ sách thành công";
                }
                else
                {
                    shelf.Data = null;
                    shelf.ErrCode = EnumErrCode.Empty;
                    shelf.ErrDesc = "kh có dữ liệu";
                }
            }
            catch (Exception ex)
            {
                shelf.ErrCode = EnumErrCode.Error;
                shelf.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                shelf.Data = null;
            }
            return shelf;
        }

        public FunctionResult<Shelf> Create(string nameShelf)
        {
            FunctionResult<Shelf> shelf = new FunctionResult<Shelf>();
            try
            {
                if (string.IsNullOrEmpty(nameShelf))
                {
                    shelf.Data = null;
                    shelf.ErrCode = EnumErrCode.IsValidInput;
                    shelf.ErrDesc = "Vui lòng nhập tên kệ";
                    return shelf;
                }

                Shelf obj = new Shelf();
                obj.ShelfName = nameShelf;
                obj.IsDeleted = false;

                db.Shelfs.InsertOnSubmit(obj);
                db.SubmitChanges();

                shelf.Data = obj;
                shelf.ErrCode = EnumErrCode.Success;
                shelf.ErrDesc = "Thêm mới kệ sách thành công.";
            }
            catch (Exception ex)
            {
                shelf.ErrCode = EnumErrCode.Error;
                shelf.ErrDesc = "Có lỗi xảy ra trong quá trình thêm mới kệ sách. Chi tiết lỗi: " + ex.Message;
                shelf.Data = null;
            }
            return shelf;
        }

        public FunctionResult<Shelf> Edit(int id, string nameShelf)
        {
            FunctionResult<Shelf> shelf = new FunctionResult<Shelf>();
            try
            {
                if (string.IsNullOrEmpty(nameShelf))
                {
                    shelf.Data = null;
                    shelf.ErrCode = EnumErrCode.IsValidInput;
                    shelf.ErrDesc = "Vui lòng nhập tên kệ sách";
                    return shelf;
                }
                var obj = db.Shelfs.FirstOrDefault(o => o.ShelfID == id);
                obj.ShelfName = nameShelf;

                db.SubmitChanges();

                shelf.Data = obj;
                shelf.ErrCode = EnumErrCode.Success;
                shelf.ErrDesc = "Sửa khách kệ sách thành công.";
            }
            catch (Exception ex)
            {
                shelf.ErrCode = EnumErrCode.Error;
                shelf.ErrDesc = "Có lỗi xảy ra trong quá trình lấy dữ liệu kệ sách. Chi tiết lỗi: " + ex.Message;
                shelf.Data = null;
            }
            return shelf;
        }

        public FunctionResult<Shelf> Delete(int id)
        {
            FunctionResult<Shelf> shelf = new FunctionResult<Shelf>();
            var obj = db.Shelfs.FirstOrDefault(x => x.ShelfID == id);
            obj.IsDeleted = true;
            db.SubmitChanges();
            shelf.Data = obj;
            shelf.ErrCode = EnumErrCode.Success;
            shelf.ErrDesc = "Xóa khách hàng thành công.";
            return shelf;
        }
    }
}
