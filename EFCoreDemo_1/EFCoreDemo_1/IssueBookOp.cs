using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EFCoreDemo_1
{
    public class IssueBookOp
    {
        public void IssueBook(LibraryContext context)
        {

            Console.WriteLine("Issue a book to a student");
 
            Console.Write("Please Enter Student Id : ");
            var Id = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Book Barcode : ");
            var BarCode = Console.ReadLine();


            try
            {

                var b = context.Books.Where(x => x.BarCode == BarCode).SingleOrDefault();
                //if valid student id and book id and copy count greater than zero

                if (context.Students.Any(s => s.Id == Id) &&
                    context.Books.Any(bk => bk.BarCode == BarCode && bk.CopyCount > 0))
                {

                    context.IssueBook.Add(new IssueBook()
                    {
                        StudentId = Id,
                        BookBarCode = BarCode,
                        bookId = b.Id,
                        IssueDate = DateTime.UtcNow
                    });

                    // update available copy count for the issued book
                    var c = context.Books.Where(x => x.BarCode == BarCode).SingleOrDefault();
                    c.CopyCount -= 1;
                    context.SaveChanges();
                    Console.WriteLine("Book Issued Successfully");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        
    }
}
