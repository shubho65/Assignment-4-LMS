using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EFCoreDemo_1
{
    public class UpdateFine
    {
        public void updateFineAmount(LibraryContext context)
        {


            Console.WriteLine("Please Enter Student Id : ");
            var Id = int.Parse(Console.ReadLine());


            Console.WriteLine("Please Enter Fine amount : ");
            var FineAmount = double.Parse(Console.ReadLine());

            var result = context.Students.Where(x => x.Id == Id).SingleOrDefault();
            var newBalance = result.FineAmount - FineAmount;

            if (newBalance <= 0) result.FineAmount = 0;
            else
            {
                result.FineAmount = newBalance;
                Console.WriteLine("Your updated fine amount is  {0}: ", newBalance);
                context.SaveChanges();
            }


        }
    }
}
