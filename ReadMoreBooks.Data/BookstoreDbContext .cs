using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_01_EF_Core.ReadMoreBooks.Data
{
    internal class BookstoreDbContext: DbContext
    {
        public DbSet<Entities.Book> Books { get; set; }
        public DbSet<Entities.Author> Authors { get; set; }
        public DbSet<Entities.Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ReadMoreBooksDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
