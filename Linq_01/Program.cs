using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.Find all products that are out of stock.

            //var prdoucts = ListGenerator.ProductsList
            //    .Where(p => p.UnitsInStock == 0);

            //foreach (var product in prdoucts)
            //    Console.WriteLine(product);
            #endregion

            #region Q2
            //2.Find all products that are in stock and cost more than 3.00 per unit.

            //var products = ListGenerator.ProductsList
            //    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            //foreach (var product in products)
            //    Console.WriteLine(product);
            #endregion

            #region Q3
            //3.Returns digits whose name is shorter than their value.

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((d, i) => d.Length < i);

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Extension Method Example
            //int x = 64534;
            //Console.WriteLine(x.Reverse());
            #endregion
        }
    }
}
