using System;

namespace EFCoreDemo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new LibraryContext();
            Console.WriteLine("Welcome to library management system");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("To enter student information press: 1");
            Console.WriteLine("To enter book information press: 2");
            Console.WriteLine("To issue book  press: 3");
            Console.WriteLine("To return book press: 4");
            Console.WriteLine("To check fine press: 5");
            Console.WriteLine("To update fine press: 6");

            Console.Write("Please enter your choice: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {

                
                case 1:
                    var std = new EnterStudentInfo();
                    std.StudentInfo(context);
                    break;

                case 2:
                    var bk = new EnterBookInfo();
                    bk.BookInfo(context);
                    break;

                case 3:
                    var issue = new IssueBookOp();
                    issue.IssueBook(context);
                    break;

                case 4:
                    var ret = new ReturnBookOp();
                    ret.ReturnBook(context);
                    break;

                case 5:
                    var cfine = new ChecFine();
                    cfine.checkFineAmount(context);
                    break;


                case 6:
                    var ufine = new UpdateFine();
                    ufine.updateFineAmount(context);
                    break;

                default:
                    Console.WriteLine("Enter valid key. Please Try Again");
                    break;
            }

        }
    }
}
