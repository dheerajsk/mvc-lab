using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQPrograms
{
    class JoinOperation
    {
        public static void Do()
        {
            List<Product> products = new List<Product>(){
                new Product() { ID=1, Name="Shirt", CategoryID=1 },
                new Product() { ID=2, Name="T-Shirt", CategoryID=1 },
                new Product() { ID=3, Name="Laptop", CategoryID=2 },
                new Product() { ID=4, Name="Headphones", CategoryID=2 },
                new Product() { ID=5, Name="Rice", CategoryID=3 },
                new Product() { ID=6, Name="Wheat", CategoryID=3 }
            };

            List<Category> categories = new List<Category>()
            {
                new Category() { ID=1, CategoryName="Clothing" },
                new Category() { ID=2, CategoryName="Electronics" },
                new Category() { ID=3, CategoryName="FoodItems" },
            };

            var result = from product in products
                         join category in categories
                         on product.CategoryID equals category.ID
                         select new { product.ID, product.Name, category.CategoryName };

            foreach (var product in result)
            {
                Console.WriteLine($"{product.ID} | {product.Name} | {product.CategoryName}");
            }

        }
    }

    class Product
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public long CategoryID { get; set; }
    }

    class Category
    {
        public long ID { get; set; }

        public string CategoryName { get; set; }
    }
}
