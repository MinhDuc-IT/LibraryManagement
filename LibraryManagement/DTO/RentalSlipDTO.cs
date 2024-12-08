using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class RentalSlipDTO
    {
        public int RentalSlipID { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal? TotalFee { get; set; }
        public List<RentalSlipDetailDTO> RentalSlipDetails { get; set; } // Thêm chi tiết phiếu thuê
    }

    public class RentalSlipDetailDTO
    {
        public int RentalSlipDetailID { get; set; }
        public bool? ReturnStatus { get; set; }
    }

}
