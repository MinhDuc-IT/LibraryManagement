using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class AuthController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<User> SignUp(string userName, string Email, string password, string cfPassword)
        {
            FunctionResult<User> rs = new FunctionResult<User>();
            try
            {
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cfPassword) || string.IsNullOrEmpty(Email))
                {
                    rs.Data = null;
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.ErrDesc = "Vui lòng nhập đầy đủ thông tin";
                    return rs;
                }

                if (password != cfPassword)
                {
                    rs.Data = null;
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.ErrDesc = "Mật khẩu xác thực không chính xác";
                    return rs;
                }
                User obj = new User();
                obj.Name = userName;
                obj.Password = password;
                obj.Role = "User";
                obj.Email = Email;

                db.Users.InsertOnSubmit(obj);
                db.SubmitChanges();

                rs.Data = obj;
                rs.ErrCode = EnumErrCode.Success;
                rs.ErrDesc = "Đăng ký thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs;
        }
        public FunctionResult<User> Login(string Email, string password)
        {
            FunctionResult<User> rs = new FunctionResult<User>();
            try
            {
                //if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(Email))
                //{
                //    rs.Data = null;
                //    rs.ErrCode = EnumErrCode.IsValidInput;
                //    rs.ErrDesc = "Vui lòng nhập đầy đủ thông tin";
                //    return rs;
                //}

                var user = db.Users.FirstOrDefault(x => x.Email == Email && x.Password == password);

                if (user == null)
                {
                    rs.Data = null;
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "Người dùng không tồn tại";
                }
                else
                {
                    rs.Data = user;
                    rs.ErrCode = EnumErrCode.Success;
                    rs.ErrDesc = "Đăng nhập thành công.";
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
