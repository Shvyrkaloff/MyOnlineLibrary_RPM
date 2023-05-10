using DummyLib.Entities;
using Microsoft.EntityFrameworkCore;

namespace DummyLib
{
    public partial class MyOnlineLibraryContext : DbContext
    {
        public MyOnlineLibraryContext()
        {
        }

        public MyOnlineLibraryContext(DbContextOptions<MyOnlineLibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase(databaseName: "MyOnlineLibrary");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}