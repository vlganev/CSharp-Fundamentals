﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var allPeople = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var allProducts = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try {
                foreach (var pair in allPeople)
                {
                    var personInfo = pair.Split('=');
                    var person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    people.Add(person);
                }
                foreach (var pair in allProducts)
                {
                    var productInfo = pair.Split('=');
                    var product = new Product(productInfo[0], decimal.Parse(productInfo[1]));
                    products.Add(product);
                }

                string purchase;
                while ((purchase = Console.ReadLine()) != "END")
                {
                    var purchaseInfo = purchase.Split(' ');
                    var buyerName = purchaseInfo[0];
                    var productName = purchaseInfo[1];

                    var buyer = people.FirstOrDefault(b => b.Name == buyerName);
                    var productToBuy = products.FirstOrDefault(bp => bp.Name == productName);

                    try { 
                    buyer.BuyProduct(productToBuy);
                    Console.WriteLine($"{buyerName} bought {productName}");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                foreach (var person in people)
                {
                    var boughtProducts = person.GetProducts();
                    var result = boughtProducts.Any() ? string.Join(", ", boughtProducts.Select(pr => pr.Name).ToList()) : "Nothing bought";
                    Console.WriteLine($"{person.Name} - {result}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
