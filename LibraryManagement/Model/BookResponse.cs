using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    public class BookResponse
    {
        public int BookID { get; set; } // ID của sách
        public string Name { get; set; } // Tên sách
        public string Author { get; set; } // Tác giả
        public string Publisher { get; set; } // Nhà xuất bản
        public DateTime? DateOfRelease { get; set; } // Ngày xuất bản
        public int Quantity { get; set; } // Số lượng sách
        public decimal Price { get; set; } // Giá sách
    }
}

