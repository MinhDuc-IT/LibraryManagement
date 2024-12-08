using LibraryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Controller
{
    internal class rentalSlipController
    {
        private DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<RentalSlip> UpdateTotalFee(int rentalSlipId, decimal totalFee)
        {
            FunctionResult<RentalSlip> rs = new FunctionResult<RentalSlip>();
            try
            {
                var rentalSlip = db.RentalSlips.FirstOrDefault(x => x.RentalSlipID == rentalSlipId);
                if (rentalSlip != null)
                {
                    rentalSlip.TotalFee += totalFee;
                    db.SubmitChanges();
                    rs.ErrCode = EnumErrCode.Success;
                    rs.Data = rentalSlip;
                    rs.ErrDesc = "Cập nhật tổng tiền thuê của phiếu thuê thành công";
                }
                else
                {
                    rs.ErrCode = EnumErrCode.Success;
                    rs.Data = null;
                    rs.ErrDesc = "Không thể tìm thấy phiếu thuê với id " + rentalSlipId;
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
