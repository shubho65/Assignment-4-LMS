using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo_1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double FineAmount { get; set; }
        public IList<IssueBook> IssueBooks { get; set; }
        public IList<ReturnBook> ReturnBooks { get; set; }
    }
}
