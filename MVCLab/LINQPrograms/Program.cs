using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPrograms
{
    class Program
    {
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            Seed();
            Console.WriteLine("All users\n");
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }

            Console.WriteLine("All users from Pune city\n");

            //var UsersFromPune = users.Where(u => u.City == "Pune").Select(user => new { UserName = user.Name, UserCity = user.City });

            var UsersFromPune = from user in users
                                where user.City == "Pune"
                                select new { UserName = user.Name, UserCity = user.City };
            foreach (var user in UsersFromPune)
            {
                Console.WriteLine("City=" + user.UserCity + ". Name=" + user.UserName);
            }

            Console.WriteLine("Aggregate functions\n");

            var minAge = users.Min(u => u.Age);
            var maxAge = users.Max(u => u.Age);
            var totalAge = users.Sum(u => u.Age);
            var totalUserCount = UsersFromPune.Count();


            Console.WriteLine(minAge);
            Console.WriteLine(maxAge);
            Console.WriteLine(totalAge);
            Console.WriteLine(totalUserCount);


            Console.WriteLine("Sorting functions\n");

            users = users.OrderBy(u => u.Name).ThenBy(x => x.Age).ToList<User>();
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }

            Console.WriteLine("\nPartitioning functions\n");

            users = users.Skip(2).Take(5).ToList();
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }

            Console.WriteLine("\n Element functions\n");

            var fuser = users.Last();
            if (fuser != null)
            {
                Console.WriteLine(fuser.ToString());
            }


            Console.ReadLine();

        }


        static void Seed()
        {
            users = new Data().Get();
            //users.Add(new User { ID = 1, Name = "Philip", Age = 20, City = "Mumbai" });
            //users.Add(new User { ID = 2, Name = "Jon", Age = 21, City = "Pune" });
            //users.Add(new User { ID = 3, Name = "Kabir", Age = 30, City = "Banglore" });
            //users.Add(new User { ID = 4, Name = "Doe", Age = 50, City = "Pune" });
            //users.Add(new User { ID = 5, Name = "Ram", Age = 26, City = "NY" });
            //users.Add(new User { ID = 6, Name = "Shyam", Age = 29, City = "NY" });
            //users.Add(new User { ID = 7, Name = "Pooja", Age = 50, City = "Pune" });
            //users.Add(new User { ID = 8, Name = "Saurabh", Age = 26, City = "Delhi" });
            //users.Add(new User { ID = 9, Name = "Pawan", Age = 39, City = "Delhi" });
        }
    }
}
