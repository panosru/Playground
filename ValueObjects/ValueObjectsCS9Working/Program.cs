namespace ValueObjectsCS9Working
{
    using System;
    
    internal class Program
    {
        private static void Main(string[] args)
        {
            var user1 = new FullNameVo
            {
                Name    = "John",
                Surname = "Doe"
            };

            var user2 = new FullNameVo
            {
                Name    = "John",
                Surname = "Doe"
            };

            var user3 = user1 with { Name = "Jane" };

            Console.WriteLine(user1 == user2);                                    // True
            Console.WriteLine(ReferenceEquals(user1, user2));                     // False
            Console.WriteLine(user1 == user3);                                    // True
            Console.WriteLine(user1.Equals(user3));                               // True
        }
    }
}