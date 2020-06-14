using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookShopWebAPI.Models
{
    public partial class BookShopDBContext : DbContext
    {
        public BookShopDBContext()
        {
        }

        public BookShopDBContext(DbContextOptions<BookShopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
