using System;

namespace ValueObjectsCS9
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new FullNameVo("John", "Doe");
            var user2 = new FullNameVo("John", "Doe");
            var user3 = new FullNameVo("Jane", "Doe");

            Console.WriteLine(user1 == user2);
            Console.WriteLine(user1 == user3);
        }
    }
}