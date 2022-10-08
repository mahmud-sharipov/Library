using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Muallif
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string GetDataMuallif()
        {
            return $"Id:{Id}  Name:{Name}\n";
        }
    }
}
