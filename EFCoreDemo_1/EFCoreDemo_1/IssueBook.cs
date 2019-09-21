using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreDemo_1
{
    public class IssueBook
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int bookId { get; set; }
        public Book book { get; set; }
        public string BookBarCode { get; set; }
       
        public DateTime IssueDate { get; set; }
    }
}
