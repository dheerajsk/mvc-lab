using System;
using System.Collections.Generic;

namespace LINQPrograms
{
    class Program
    {
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            Seed();
            foreach(User user in users)
            {
                Console.WriteLine(user.ToString());
            }
            Console.ReadLine();
        }


        static void Seed()
        {
            users.Add(new User { ID = 1, Name = "Philip", Age = 20, City = "Mumbai" });
            users.Add(new User { ID = 2, Name = "Jon", Age = 21, City = "Hyderabad" });
            users.Add(new User { ID = 3, Name = "Kabir", Age = 30, City = "Banglore" });
            users.Add(new User { ID = 4, Name = "Doe", Age = 50, City = "Pune" });
            users.Add(new User { ID = 5, Name = "Ram", Age = 26, City = "NY" });
            users.Add(new User { ID = 6, Name = "Shyam", Age = 29, City = "NY" });
            users.Add(new User { ID = 7, Name = "Pooja", Age = 50, City = "Pune" });
            users.Add(new User { ID = 8, Name = "Saurabh", Age = 26, City = "Delhi" });
            users.Add(new User { ID = 9, Name = "Pawan", Age = 39, City = "Delhi" });
        }
    }
}
