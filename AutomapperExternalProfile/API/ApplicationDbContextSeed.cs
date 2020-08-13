namespace API
{
    using System;
    using System.Threading.Tasks;
    using Application.Entities;

    public class ApplicationDbContextSeed
    {
        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            context.Foo.Add(
                new FooEntity
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    Title = "Some demo title",
                    Category = "Test category",
                    Views = 50,
                    Notes = "sample notes here"
                });

            await context.SaveChangesAsync();
        }
    }
}