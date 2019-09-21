using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo_1
{
    public class EnterStudentInfo
    {
        public void StudentInfo(LibraryContext context)
        {
            Student student = new Student();

            Console.WriteLine("Enter Student Information:");

            Console.Write("Please enter student Id: ");
            student.Id = int.Parse(Console.ReadLine());

            Console.Write("Please enter student Name: ");
            student.Name = Console.ReadLine();

            student.FineAmount = 0;


            context.Students.Add(new Student()
            {
                Id = student.Id,
                Name = student.Name,
                FineAmount = 0
            });
            context.SaveChanges();
            Console.WriteLine("Student Information Inserted!");
        }



       
    }
}
