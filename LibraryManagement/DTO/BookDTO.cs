using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class BookDTO
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public int? ShelfID { get; set; }
        public string Publisher { get; set; }
        public DateTime? DateOfRelease { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Byte[] Image { get; set; }
        public string Description { get; set; }
    }

}
