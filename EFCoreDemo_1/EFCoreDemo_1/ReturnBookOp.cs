using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EFCoreDemo_1
{
    public class ReturnBookOp
    {
        public void ReturnBook(LibraryContext context)
        {
      

            Console.Write("Please Enter Student Id : ");
            var Id = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Book Barcode : ");
            var BarCode = Console.ReadLine();

            // get the issuebook instance with given student id and book barcode
            var b = context.IssueBook.Where(x => x.BookBarCode == BarCode && x.StudentId == Id).FirstOrDefault();
            var c = (DateTime.UtcNow - b.IssueDate).Days;
            var wk = 7;
            // get the student to udate his fine amount
            var sb = context.Students.Where(x => x.Id == Id).SingleOrDefault();
            var diff = c - wk;
            if (diff>0)
            {
                var fineamount = diff * 10;
                sb.FineAmount = fineamount;
                Console.WriteLine("Fine Updated Successfully");
            }
            // get the book to udate remaigning copy count
            var bk = context.Books.Where(x => x.BarCode == BarCode).SingleOrDefault();
            bk.CopyCount += 1;
            context.SaveChanges();
            context.ReturnBook.Add(new ReturnBook()
            {
                StudentId = b.StudentId,
                BookId = b.bookId,
                BookBarCode = b.BookBarCode,
                ReturnDate = DateTime.UtcNow
            });

            context.SaveChanges();
            Console.WriteLine("Book Returned Successfuly");

        }
    }
}
