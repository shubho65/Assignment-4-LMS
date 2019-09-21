using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo_1
{
    public class EnterBookInfo
    {
       
        public void BookInfo(LibraryContext context)
        {
            Book book = new Book();

            Console.WriteLine("Enter Book Information");

            Console.Write("Please enter Book Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Please enter Book Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Please enter Book Edition: ");
            book.Edition = Console.ReadLine();

            Console.Write("Please enter Barcode of the book: ");
            book.BarCode = Console.ReadLine();

            Console.Write("Please enter Copy Count of the book: ");
            book.CopyCount = int.Parse(Console.ReadLine());


            context.Books.Add(new Book()
            {
                Author = book.Author,
                Edition = book.Edition,
                Title = book.Title,
                BarCode = book.BarCode,
                CopyCount = book.CopyCount
            });
            context.SaveChanges();
            Console.WriteLine("Books Information Inserted!");
        }

    }
}
