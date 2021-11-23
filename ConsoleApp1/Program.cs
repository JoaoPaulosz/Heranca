﻿using System;
using ConsoleApp1.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char verify = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(verify=='i') {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, fee));
                    }
                else if(verify=='u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manudate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manudate));
                    }
                else {
                    products.Add(new Product(name, price));
                    }
                }
            foreach(Product prod in products) {
                Console.WriteLine(prod.PriceTag());
                }
            }
        }
    }
