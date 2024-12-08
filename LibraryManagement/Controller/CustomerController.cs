using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class CustomerController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<List<Customer>> GetAll()
        {
            FunctionResult<List<Customer>> cus = new FunctionResult<List<Customer>>();
            try
            {
                var qr = db.Customers.Where(x => x.IsDeleted == false).ToList();

                if (qr.Any())
                {
                    cus.Data = qr;
                    cus.ErrCode = EnumErrCode.Success;
                    cus.ErrDesc = "Lấy dữ liệu người dùng thành công";
                }
                else
                {
                    cus.Data = null;
                    cus.ErrCode = EnumErrCode.Empty;
                    cus.ErrDesc = "kh có dữ liệu";
                }
            }
            catch (Exception ex)
            {
                cus.ErrCode = EnumErrCode.Error;
                cus.ErrDesc = "Có lỗi xảy ra trong qúa trình lấy dữ liệu tài khoản. Chi tiết lỗi: " + ex.Message;
                cus.Data = null;
            }
            return cus;
        }

        public FunctionResult<Customer> Create(string name, string gender, DateTime dateofbirth, string address, string phone, string cccd, DateTime startdate)
        {
            FunctionResult<Customer> cus = new FunctionResult<Customer>();
            try
            {
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(gender) ||
                    dateofbirth == DateTime.MinValue ||
                    string.IsNullOrEmpty(address) ||
                    string.IsNullOrEmpty(phone) ||
                    string.IsNullOrEmpty(cccd) ||
                    startdate == DateTime.MinValue)
                {
                    cus.ErrCode = EnumErrCode.IsValidInput;
                    cus.ErrDesc = "Vui lòng nhập đầy đủ các trường dữ liệu";
                    cus.Data = null;
                    return cus;
                }
                string phonePattern = @"^84\d{9}$";
                if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, phonePattern))
                {
                    cus.ErrCode = EnumErrCode.IsValidInput;
                    cus.Data = null;
                    cus.ErrDesc = "Vui lòng nhập số điện thoại hợp lệ (bắt đầu bằng 84 và có tổn 11 số).";
                    return cus;
                }

                Customer obj = new Customer();
                obj.Name = name;
                obj.Gender = gender;
                obj.Address = address;
                obj.DateOfBirth = dateofbirth;
                obj.PhoneNumber = phone;
                obj.CitizenIdentification = cccd;
                obj.StartDate = startdate;
                obj.IsDeleted = false;

                db.Customers.InsertOnSubmit(obj);
                db.SubmitChanges();

                cus.Data = obj;
                cus.ErrCode = EnumErrCode.Success;
                cus.ErrDesc = "Thêm mới người dùng thành công.";
            }
            catch (Exception ex)
            {
                cus.ErrCode = EnumErrCode.Error;
                cus.ErrDesc = "Có lỗi xảy ra trong quá trình thêm mới khách hàng. Chi tiết lỗi: " + ex.Message;
                cus.Data = null;
            }
            return cus;
        }

        public FunctionResult<Customer> Edit(int id, string name, string gender, DateTime dateofbirth, string address, string phone, string cccd, DateTime startdate)
        {
            FunctionResult<Customer> cus = new FunctionResult<Customer>();
            try
            {
                var obj = db.Customers.FirstOrDefault(x => x.CustomerID == id);
                if (obj == null)
                {
                    cus.Data = obj;
                    cus.ErrCode = EnumErrCode.Empty;
                    cus.ErrDesc = "Không thể tìm thấy khách hàng có id: "+id;
                    return cus;
                }
                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(gender) ||
                    dateofbirth == DateTime.MinValue ||
                    string.IsNullOrEmpty(address) ||
                    string.IsNullOrEmpty(phone) ||
                    string.IsNullOrEmpty(cccd) ||
                    startdate == DateTime.MinValue)
                {
                    cus.ErrCode = EnumErrCode.IsValidInput;
                    cus.ErrDesc = "Vui lòng nhập đầy đủ các trường dữ liệu";
                    cus.Data = null;
                    return cus;
                }
                string phonePattern = @"^84\d{9}$";
                if (string.IsNullOrEmpty(phone) || !Regex.IsMatch(phone, phonePattern))
                {
                    cus.ErrCode = EnumErrCode.IsValidInput;
                    cus.Data = null;
                    cus.ErrDesc = "Vui lòng nhập số điện thoại hợp lệ (bắt đầu bằng 84 và có tổn 11 số).";
                    return cus;
                }
                obj.Name = name;
                obj.Gender = gender;
                obj.Address = address;
                obj.DateOfBirth = dateofbirth;
                obj.PhoneNumber = phone;
                obj.CitizenIdentification = cccd;
                obj.StartDate = startdate;

                db.SubmitChanges();

                cus.Data = obj;
                cus.ErrCode = EnumErrCode.Success;
                cus.ErrDesc = "Sửa khách hàng thành công.";

            }
            catch (Exception ex)
            {
                cus.ErrCode = EnumErrCode.Error;
                cus.ErrDesc = "Có lỗi xảy ra trong quá trình lấy dữ liệu khách hàng. Chi tiết lỗi: " + ex.Message;
                cus.Data = null;
            }
            return cus;
        }

        public FunctionResult<Customer> Delete(int id)
        {
            FunctionResult<Customer> cus = new FunctionResult<Customer>();
            try
            {
                var obj = db.Customers.FirstOrDefault(x => x.CustomerID == id);
                if(obj == null)
                {
                    cus.Data = obj;
                    cus.ErrCode = EnumErrCode.Empty;
                    cus.ErrDesc = "Không thể tìm thấy khách hàng có id: " + id;
                    return cus;
                }
                obj.IsDeleted = true;
                db.SubmitChanges();
                cus.Data = obj;
                cus.ErrCode = EnumErrCode.Success;
                cus.ErrDesc = "Xóa khách hàng thành công.";
            }
            catch (Exception ex)
            {
                cus.ErrCode = EnumErrCode.Error;
                cus.ErrDesc = "Có lỗi xảy ra trong quá trình lấy dữ liệu khách hàng. Chi tiết lỗi: " + ex.Message;
                cus.Data = null;
            }
            return cus;
        }
        public FunctionResult<int> getTotalCustomer()
        {
            FunctionResult<int> rs = new FunctionResult<int>();
            try
            {
                var totalCustomer = db.Customers
                                     .Count();

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = totalCustomer ;
                rs.ErrDesc = "Lấy số khách hàng trong ngày thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = 0;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<int> getCustomerByWeek()
        {
            FunctionResult<int> rs = new FunctionResult<int>();
            try
            {
                var today = DateTime.Now;
                var startOfWeek = today.AddDays(-(int)(today.DayOfWeek == DayOfWeek.Sunday ? 7 : Convert.ToInt32(today.DayOfWeek)) + (int)DayOfWeek.Monday);

                var totalCustomer = db.Customers
                                     .Where(rh => rh.StartDate >= startOfWeek && rh.StartDate <= today)
                                     .Count();

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = totalCustomer;
                rs.ErrDesc = "Lấy số khách hàng trong tuần thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = 0;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
        public FunctionResult<int> getCustomerByMonth()
        {
            FunctionResult<int> rs = new FunctionResult<int>();
            try
            {
                var today = DateTime.Now;
                var startOfMonth = new DateTime(today.Year, today.Month, 1);
                var totalCustomer = db.Customers
                                     .Where(rh => rh.StartDate >= startOfMonth && rh.StartDate <= today)
                                     .Count();

                rs.ErrCode = EnumErrCode.Success;
                rs.Data = totalCustomer;
                rs.ErrDesc = "Lấy doanh thu trong tháng thành công.";
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.Data = 0;
                rs.ErrDesc = ex.Message;
            }
            return rs;
        }
    }
}
