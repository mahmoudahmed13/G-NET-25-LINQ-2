using ConsoleApp1.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using static ConsoleApp1.DataSources.Source;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            ////1.Get top 3 most expensive products

            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            #endregion

            #region Question 02
            //2.show page 2 of products, with page size = 5
            //int pageSize = 5, pageNumber = 2;
            //var result = ProductList.Skip((pageNumber -1 ) * pageSize).Take(pageSize);
            #endregion

            #region Question 03
            //3. Take products from the list as long as
            //Their UnitPrice is less than $25 (list is ordered by price).

            //var result = ProductList.OrderBy(p=> p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

            #endregion

            #region Question 04
            ////4. Check if ALL products in the "Seafood" category are in stock

            //bool productsInStock = ProductList.Where(p => p.Category == "Seafood")
            //                            .All(p => p.UnitsInStock > 0);
            //Console.WriteLine($"{productsInStock}");
            #endregion

            #region Question 05
            ////5.Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };

            //Console.WriteLine(ids.Contains(9)); // true;
            #endregion

            #region Question 06
            ////6.Group all products by Category and print each group with its product count.
            //var result = ProductList.GroupBy(p => p.Category);
            //foreach (var group in result)
            //    Console.WriteLine($"{group.Key} - {group.Count()}");
            #endregion

            #region Question 07
            ////7.Group products by Category and project only product names per group

            //var result = ProductList.GroupBy(p => p.Category, p => p.ProductName);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key} - {group.Count()} ");
            //    foreach (var item in group)
            //        Console.WriteLine(item);
            //}
            #endregion

            #region Question 08
            ////8.Find all categories that have MORE THAN 3 products

            //var result = ProductList.GroupBy(p => p.Category)
            //    .Where(p => p.Count() > 3)
            //    .Select(p => new
            //    {
            //        p.Key,
            //        Count = p.Count()
            //    });
            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key + " - "+group.Count);

            //} 

            #endregion

            #region Question 09
            ////10.Calculate the total number of units in stock across all products
            //Console.WriteLine(ProductList.Sum(p => p.UnitsInStock));
            #endregion

            #region Question 10
            ////Find the CHEAPEST and MOST EXPENSIVE product prices
            //Console.WriteLine($"Cheapest Produce: {ProductList.Min(p=>p.UnitPrice)} - Exepnive Produce: {ProductList.Max(p=>p.UnitPrice)}");
            #endregion

            #region Question 11
            ////12.Get a distinct list of all product categories
            //var result = ProductList.Select(p => p.Category).Distinct();
            #endregion

            #region Question 12 in the sheat is number 9
            ////9.Using QUERY SYNTAX, group customers by Country,
            ////and for each group select { Country, Count, TotalOrderValue }.
            //var result = from c in CustomerList
            //             group c by c.Country;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} - Count : {item.Count()} " +
            //        $"-  {item.Sum(c => c.Orders.Sum(o => o.Total))}");
            //}
            //Console.WriteLine("-------------------------");
            //var result01 = from c in CustomerList
            //         group c by c.Country
            //             into groups
            //         select new
            //         {
            //             groups.Key,
            //             Count = groups.Count(),
            //             TotalOrderValue = groups.Sum(c => c.Orders != null
            //                                  ? c.Orders.Sum(o => o.Total)
            //                                  : 0)
            //         };

            //foreach (var item in result01)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Count} - {item.TotalOrderValue}");
            //}
            #endregion

            #region Question 13
            ////13.find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //foreach (var ids in setA.Except(setB))
            //    Console.WriteLine(ids);
            #endregion
            //foreach (var item in result)
            //    Console.WriteLine(item);
        }
    }
}
