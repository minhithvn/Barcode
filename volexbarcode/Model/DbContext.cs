namespace volexbarcode.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=db")
        {
        }

        public virtual DbSet<CanonPart> CanonParts { get; set; }
        public virtual DbSet<FujiPart> FujiParts { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
