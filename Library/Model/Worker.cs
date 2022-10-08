using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Worker
    {
        public int Id { get; set; }
        public string FillName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string GetDataWorker()
        {
            return $"Id:{Id}  FillName:{FillName}  ADdress:{Address}  Phone:{Phone}\n";
        }
    }
}
