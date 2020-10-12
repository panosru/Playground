using System;

namespace ValueObjectsCS9
{
    class Program
    {
        static void Main(string[] args)
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

            var user3 = new FullNameVo
            {
                Name    = "Jane",
                Surname = "Doe"
            };

            Console.WriteLine(user1 == user2);
            Console.WriteLine(user1 == user3);
        }
    }
}