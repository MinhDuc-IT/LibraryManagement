using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
   
    class Customer_ctrl
    {
        private LibraryManagementDataContext db = new LibraryManagementDataContext("Data Source=anpt04\\SQLEXPRESS02;Initial Catalog=LibraryManagement;Integrated Security=True");
        public FunctResult<List<Customer>> GetAll()
        {
            FunctResult<List<Customer>> cus = new FunctResult<List<Customer>>();
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

        public FunctResult<Customer> Create(string name, string gender, DateTime dateofbirth, string address, string phone, string cccd, DateTime startdate)
        {
            FunctResult<Customer> cus = new FunctResult<Customer>();
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
                    cus.ErrCode = EnumErrCode.InvalidInput;
                    cus.ErrDesc = "Vui lòng nhập đầy đủ các trường dữ liệu";
                    cus.Data = null;
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
                cus.ErrDesc = "Có lỗi xảy ra trong quá trình lấy dữ liệu người dùng. Chi tiết lỗi: " + ex.Message;
                cus.Data = null;
            }
            return cus;
        }

        public FunctResult<Customer> Edit(int id, string name, string gender, DateTime dateofbirth, string address, string phone, string cccd, DateTime startdate)
        {
            FunctResult<Customer> cus = new FunctResult<Customer>();
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
                    cus.ErrCode = EnumErrCode.InvalidInput;
                    cus.ErrDesc = "Vui lòng nhập đầy đủ các trường dữ liệu";
                    cus.Data = null;
                    return cus;
                }
                var obj = db.Customers.FirstOrDefault(x => x.CustomerID == id);
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
                cus.ErrDesc = "Có lỗi xảy ra trong quá trình lấy dữ liệu người dùng. Chi tiết lỗi: " + ex.Message;
                cus.Data = null;
            }

            return cus;
        }

        public FunctResult<Customer> Delete(int id)
        {
            FunctResult<Customer> cus = new FunctResult<Customer>();
            var obj = db.Customers.FirstOrDefault(x => x.CustomerID == id);
            obj.IsDeleted = true;
            db.SubmitChanges();
            cus.Data = obj;
            cus.ErrCode = EnumErrCode.Success;
            cus.ErrDesc = "Xóa khách hàng thành công.";
            return cus;
        }
    }
}
