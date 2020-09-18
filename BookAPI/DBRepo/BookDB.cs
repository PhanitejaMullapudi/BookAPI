namespace BookAPI.DBRepo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BookDB : DbContext
    {
        public BookDB()
            : base("name=BookDB")
        {
        }

        public virtual DbSet<BOOK> BOOKs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BOOK>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<BOOK>()
                .Property(e => e.Author)
                .IsUnicode(false);
        }
    }
}
