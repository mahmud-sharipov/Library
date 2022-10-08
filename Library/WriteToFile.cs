using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public static class WriteToFile
    {
        public static void SaveBook(List<Categoriy> categoriys)
        {
            var textData = JsonConvert.SerializeObject(categoriys);
            File.WriteAllText(@"C:\\Users\\shabon\\source\\repos\\ItiRaun\\Library\\Library\\Data\\FileCategoriy.json", textData);
        }

        public static void SaveMuallif(List<Muallif> muallifs)
        {
            var textData = JsonConvert.SerializeObject(muallifs);
            File.WriteAllText(@"C:\\Users\\shabon\\source\\repos\\ItiRaun\\Library\\Library\\Data\\FileMiallif.json", textData);
        }
        public static void SaveBook(List<Book> books)
        {
            var textData = JsonConvert.SerializeObject(books);
            File.WriteAllText(@"C:\\Users\\shabon\\source\\repos\\ItiRaun\\Library\\Library\\Data\\FileBooks.json", textData);
        }

        public static void SaveCustomer(List<Customer> customers)
        {
            var textData = JsonConvert.SerializeObject(customers);
            File.WriteAllText(@"C:\\Users\\shabon\\source\\repos\\ItiRaun\\Library\\Library\\Data\\FileCustomer.json", textData);
        }

        public static void SaveWorker(List<Worker> workers)
        {
            var textData = JsonConvert.SerializeObject(workers);
            File.WriteAllText(@"C:\\Users\\shabon\\source\\repos\\ItiRaun\\Library\\Library\\Data\\FileWorker.json", textData);
        }

        public static void SaveRent(List<Rent> rents)
        {
            var textData = JsonConvert.SerializeObject(rents);
            File.WriteAllText(@"C:\\Users\\shabon\\source\\repos\\ItiRaun\\Library\\Library\\Data\\FileRents.json", textData);
        }
    }
}
