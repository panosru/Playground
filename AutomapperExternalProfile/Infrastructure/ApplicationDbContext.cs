namespace Infrastructure
{
    using Application;
    using Core.Entities;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FooEntity> Foo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Test");

            base.OnConfiguring(optionsBuilder);
        }
    }
}