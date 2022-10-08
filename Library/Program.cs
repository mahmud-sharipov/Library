using Library.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rent> rents = new List<Rent>(ReadAllFiles.GetRent());
            List<Book> books = new List<Book>(ReadAllFiles.GetBook());

           
            foreach (var item in rents)
            {
                Console.WriteLine($"Worker: {item.Worker.FillName}");
                Console.WriteLine($"Cusromer: {item.Customer.FillName}");
                Console.WriteLine($"Book: {item.Book.Name}, Muallif: {item.Book.Categoriy.Name}");
                Console.WriteLine($"DataTime: {item.DateTime}");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Ok!");
            Console.ReadLine();
        }

        public static void Book()
        {
            List<Muallif> muallifs = new List<Muallif>(ReadAllFiles.GetMuallif());
            List<Categoriy> categoriys = new List<Categoriy>(ReadAllFiles.GetCategory());
            List<Book> list = new List<Book>();
            var s = 0;

            while (s < 5)
            {
                Console.WriteLine("Id");
                int _id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name");
                string _name = Console.ReadLine();
                Console.WriteLine("CategoriyId");
                int _CategoriyId = int.Parse(Console.ReadLine());
                Console.WriteLine("MuallifId");
                int _MuallifId = int.Parse(Console.ReadLine());
                Console.WriteLine("NamberOfPage");
                int _namber = int.Parse(Console.ReadLine());

                Book book = new Book() { };
                book.Id = _id;
                book.Name = _name;
                book.CategoriyId = _CategoriyId;

                foreach (var item in categoriys)
                {
                    if (item.Id == _CategoriyId)
                        book.Categoriy = item;
                }
                book.MuallifId = _MuallifId;
                foreach (var item in muallifs)
                {
                    if (item.Id == _MuallifId)
                        book.Muallif = item;
                }
                book.NamberOfPage = _namber;
                list.Add(book);
                s++;
            }
            WriteToFile.SaveBook(list);
        }

        public static void ChenchMuallif()
        {
            List<Muallif> muallifs = new List<Muallif>(ReadAllFiles.GetMuallif());
            foreach (var item in muallifs)
            {
                if (item.Id == 2)
                    item.Name = "Shabon";
            }
            WriteToFile.SaveMuallif(muallifs);
        }
    }
}