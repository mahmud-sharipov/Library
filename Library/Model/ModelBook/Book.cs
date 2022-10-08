using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MuallifId { get; set; }
        public Muallif Muallif { get; set; }
        public int CategoriyId { get; set; }
        public Categoriy Categoriy { get; set; }
        public int NamberOfPage { get; set; }
    }
}
