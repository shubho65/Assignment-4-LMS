using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EFCoreDemo_1
{
    class ShoppingContext : DbContext
    {
        private string _connectionString;

        public ShoppingContext()
        {
            _connectionString = "Server=DESKTOP-9OM4UHS;Database=learning;User Id=shubho;Password =12345; ";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<StudentBook>()
                .HasKey(pc => new { pc.StudentId, pc.BookId });

            builder.Entity<StudentBook>()
                .HasOne(pc => pc.Student)
                .WithMany(p => p.StudentBooks)
                .HasForeignKey(pc => pc.StudentId);


            base.OnModelCreating(builder);
        }
         
        //public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<StudentBook> StudentBooks { get; set; }
        //public DbSet<ReturnBook> ReturnBooks { get; set; }
    }
}
