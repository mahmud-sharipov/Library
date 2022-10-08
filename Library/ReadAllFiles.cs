using Library.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class ReadAllFiles
    {
        public static List<Categoriy> GetCategory()
        {
            var textData = File.ReadAllText(@"Data/FileCategoriy.json");
            return JsonConvert.DeserializeObject<List<Categoriy>>(textData);
        }

        public static List<Muallif> GetMuallif()
        {
            var textData = File.ReadAllText(@"Data/FileMiallif.json");
            return JsonConvert.DeserializeObject<List<Muallif>>(textData);
        }

        public static List<Book> GetBook()
        {
            var textData = File.ReadAllText(@"Data/FileBooks.json");
            return JsonConvert.DeserializeObject<List<Book>>(textData);
        }

        public static List<Customer> GetCustomer()
        {
            var textData = File.ReadAllText(@"Data/FileCustomer.json");
            return JsonConvert.DeserializeObject<List<Customer>>(textData);
        }

        public static List<Worker> GetWorker()
        {
            var textData = File.ReadAllText(@"Data/FileWorker.json");
            return JsonConvert.DeserializeObject<List<Worker>>(textData);
        }

        public static List<Rent> GetRent()
        {
            var textData = File.ReadAllText(@"Data/FileRents.json");
            return JsonConvert.DeserializeObject<List<Rent>>(textData);
        }
    }
}
