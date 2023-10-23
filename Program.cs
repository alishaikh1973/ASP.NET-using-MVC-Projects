﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssessment
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mouse",Price=799,CompanyName="Dell"},
                new Product{Id=2,Name="Mouse",Price=699,CompanyName="Lenovo"},
                new Product{Id=3,Name="Laptop",Price=34799,CompanyName="Dell"},
                new Product{Id=4,Name="Laptop",Price=45799,CompanyName="Sony"},
                new Product{Id=5,Name="Laptop",Price=38799,CompanyName="Lenovo"},
                new Product{Id=6,Name="Keyboard",Price=599,CompanyName="Dell"},
                new Product{Id=7,Name="Keyboard",Price=999,CompanyName="Microsoft"},
                new Product{Id=8,Name="RAM 4GB",Price=2799,CompanyName="Corsair"},
                new Product{Id=9,Name="Speaker",Price=5799,CompanyName="Sony"},
                new Product{Id=10,Name="USB Mouse",Price=1299,CompanyName="Microsoft"},
            };


             // Using LINQ Query:-

              // 1. Display all products using LINQ query
                 var result1 = from p in products select p;
                 /* foreach (Product item in result1)
                  {
                 Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
                  }*/


            //2.Display products whose price is greater than 1500
            var result2 =  from p in products where p.Price>1500 select p;
            foreach (Product item in result2)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }


            //3.Display products whose price is in between 10000 to 40000
            var result3 = from p in products where p.Price >= 10000 && p.Price<=40000 select p;
            foreach (Product item in result3)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }

            //4.Display products of Dell company
            var result4 = from p in products where p.CompanyName == "Dell" select p;
            foreach (Product item in result4)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }

            //5.Display all company laptops
            var result5 = from p in products where p.Name == "laptop" select p;
            foreach (Product item in result5)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }

            //6.Display products whose company name start with ‘M’
            var result6 = from p in products where p.CompanyName.StartsWith("M") select p;
            foreach (Product item in result6)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }

            //7.Display all company mouse whose price is less than 1000
           var result7 = from p in products
            where (p.Name == "Mouse" &&
                  (p.CompanyName == "Microsoft" ||
                   p.CompanyName == "Lenovo") &&
                   p.Price < 1000)
            select p;
            foreach (Product item in result7)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }



            //8.Display all products descending order by their price
            var result8 = from p in products orderby p.Price descending select p;
            foreach (Product item in result8)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }


            //9.Display all products accessing order by their company name
            var result9 = from p in products orderby p.CompanyName ascending select p;
            foreach (Product item in result9)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }

            //10.Display all keyboards accessing order by their price
            var result10 = from p in products where p.Name=="Keyboard" orderby p.Price ascending select p;
            foreach (Product item in result10)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }


            // Using Lambda Expression:-

            //1.Display all products descending order by their price
            var result11 = products.OrderByDescending(product => product.Price);
            foreach (Product item in result11)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }


            //2.Display product whose Id is 5
            var result12 = products.Where(product => product.Id == 5);
            foreach (Product item in result12)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }
            //3.Display all products whose price less than 5000
            var result13 = products.Where(product => product.Price <= 5000);
            foreach (Product item in result13)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }

            //4.Display 3 products which have maximum price
            var result14 = products.OrderByDescending(product=> product.Price).Take(3);
            foreach (Product item in result14)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }


            //5.Display 5 products which have minimum price
            var result15 = products.OrderBy(product => product.Price).Take(5);
            foreach (Product item in result15)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.Price},{item.CompanyName}");
            }





        }
    }
}
