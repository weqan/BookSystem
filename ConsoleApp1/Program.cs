using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BookSystem.IDAL.IBookTypeService bsvc = new BookSystem.DAL.BookTypeService())
            {
                bsvc.Add(new BookSystem.Models.BookType { Name = "aaaa" });

                foreach (var item in bsvc.GetAll())
                {
                    Console.WriteLine(item.Name);
                }
            }       
            
        }
    }
}
