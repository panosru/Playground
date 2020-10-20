namespace Core.Entities
{
    using System;

    public class FooEntity
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public int Views { get; set; }

        public string Notes { get; set; }
    }
}