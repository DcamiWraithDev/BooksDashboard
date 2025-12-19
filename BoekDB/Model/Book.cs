using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekDB.Model
{
    public class Book
    {
        //public int Id { get; set; }
        public string Title { get; set; }
        public DateTime releaseYear { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }
    }
}
