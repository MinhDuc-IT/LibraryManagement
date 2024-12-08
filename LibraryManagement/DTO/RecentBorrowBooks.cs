using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    internal class RecentBorrowBooks
    {
        public int retalSlipId { get; set; }
        public int rentalSlipDetailId { get; set; }
        public int bookId { get; set; }
        public string customerName { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public decimal RentalFee { get; set; }
        public string bookName { get; set; }
        public byte[] bookImage { get; set; }
    }
}
