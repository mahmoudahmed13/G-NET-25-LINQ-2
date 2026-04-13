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
            int pageSize = 5, pageNumber = 2;
            var result = ProductList.Skip((pageNumber -1 ) * pageSize).Take(pageSize);
            #endregion

            //foreach (var item in result)
            //    Console.WriteLine(item);
        }
    }
}
