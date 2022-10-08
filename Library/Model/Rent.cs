using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Rent
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public DateTime DateTime { get; set; }
    }
}
