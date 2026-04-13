using ConsoleApp1.Models;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using static ConsoleApp1.DataSources.Source;

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

            //foreach (var item in result)
            //    Console.WriteLine(item);
        }
    }
}
