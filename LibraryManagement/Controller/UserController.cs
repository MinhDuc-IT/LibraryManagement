using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class UserController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<User> AddUser(string Email, string password, string role, string address,
            string gender, string userName, string phone, DateTime? dateOfBirth, string cccd)
        {
            FunctionResult<User> rs = new FunctionResult<User>();
            try
            {
                if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(gender)
                    || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(cccd))
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Vui lòng điền đầy đủ thông tin cho Người dùng";
                    return rs;
                }

                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (string.IsNullOrEmpty(Email) || !Regex.IsMatch(Email, emailPattern))
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Vui lòng nhập một email hợp lệ.";
                    return rs;
                }

                string phonePattern = @"^84\d{9}$";
                if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, phonePattern))
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Vui lòng nhập số điện thoại hợp lệ (bắt đầu bằng 84 và có tổn 11 số).";
                    return rs;
                }

                var user = db.Users.FirstOrDefault(x => x.Email == Email);
                if (user != null)
                {
                    rs.ErrCode = EnumErrCode.Error;
                    rs.Data = null;
                    rs.ErrDesc = "Email đã tồn tại";
                    return rs;
                }

                User newUser = new User
                {
                    Email = Email,
                    Password = password,
                    Role = role,
                    Address = address,
                    Gender = gender,
                    Name = userName,
                    PhoneNumber = phone,
                    CitizenIdentification = cccd,
                    DateOfBirth = dateOfBirth.Value,
                    IsDeleted = false,
                };

                db.Users.InsertOnSubmit(newUser);
                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = newUser;
                rs.ErrDesc = "Thêm người dùng thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = null;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<List<User>> GetAll()
        {
            FunctionResult<List<User>> rs = new FunctionResult<List<User>>();
            try
            {
                var listUsers = db.Users.ToList();
                if (listUsers == null)
                {
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "Không thể load dữ liệu";
                    rs.Data = null;
                    return rs;
                }
                rs.ErrCode = EnumErrCode.Success;
                rs.ErrDesc = "Lấy dữ liệu thành công";
                rs.Data = listUsers;
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                rs.Data = null;
            }

            return rs;
        }
        public FunctionResult<User> EditUser(int id, string role, string address,
            string gender, string userName, string phone, DateTime? dateOfBirth, string cccd)
        {
            FunctionResult<User> rs = new FunctionResult<User>();
            try
            {
                if (string.IsNullOrEmpty(role) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(gender)
                    || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(cccd))
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Vui lòng điền đầy đủ thông tin cho Người dùng";
                    return rs;
                }

                string phonePattern = @"^84\d{9}$";
                if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, phonePattern))
                {
                    rs.ErrCode = EnumErrCode.IsValidInput;
                    rs.Data = null;
                    rs.ErrDesc = "Vui lòng nhập số điện thoại hợp lệ (bắt đầu bằng 84 và có tổn 11 số).";
                    return rs;
                }

                var user = db.Users.FirstOrDefault(x => x.UserID == id);
                if (user == null)
                {
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.Data = null;
                    rs.ErrDesc = "không tìm thấy người dùng có id " + id;
                    return rs;
                }

                user.Role = role;
                user.Address = address;
                user.Gender = gender;
                user.Name = userName;
                user.PhoneNumber = phone;
                user.CitizenIdentification = cccd;
                user.DateOfBirth = dateOfBirth.Value;

                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = user;
                rs.ErrDesc = "Chỉnh sửa người dùng thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = null;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<User> DeleteUser(int id)
        {
            FunctionResult<User> rs = new FunctionResult<User>();
            try
            {
                var user = db.Users.FirstOrDefault(x => x.UserID == id);
                if (user == null)
                {
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.Data = null;
                    rs.ErrDesc = "không tìm thấy người dùng có id " + id;
                    return rs;
                }
                user.IsDeleted = true;

                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = user;
                rs.ErrDesc = "Xóa người dùng thành công.";
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
