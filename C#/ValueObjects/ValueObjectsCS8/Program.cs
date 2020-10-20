using System;

namespace ValueObjectsCS8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var user1 = new FullNameVo("John", "Doe");
            var user2 = new FullNameVo("John", "Doe");
            var user3 = new FullNameVo("Jane", "Doe");

            Console.WriteLine(user1 == user2); // True
            Console.WriteLine(ReferenceEquals(user1, user2)); // False
            Console.WriteLine(user1 == user3); // True
            Console.WriteLine(user1.Equals(user3)); // True
        }
    }
}