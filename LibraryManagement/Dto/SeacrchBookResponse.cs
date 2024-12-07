using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Dto
{
    internal class SeacrchBookResponse
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public string ShelfName { get; set; }
        public string Publisher { get; set; }
        public DateTime? DateOfRelease { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
