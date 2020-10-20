namespace Application
{
    using Core.Entities;
    using Microsoft.EntityFrameworkCore;

    public interface IApplicationDbContext
    {
        DbSet<FooEntity> Foo { get; set; }
    }
}