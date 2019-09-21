using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EFCoreDemo_1
{
    public class ChecFine
    {
        public void checkFineAmount(LibraryContext context)
        {

            Console.Write("Please Enter Student Id : ");
            var Id = int.Parse(Console.ReadLine());

            var result = context.Students.Where(x => x.Id == Id).SingleOrDefault();
            Console.WriteLine("Fine amount is {0} Tk", result.FineAmount);
        }

       
    }
}
