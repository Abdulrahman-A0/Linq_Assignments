using Day_01_G03;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Day_01_G03.ListGenerator;
namespace Linq_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dictionary_english = File.ReadAllLines("dictionary_english.txt");

            #region LINQ - Element Operators
            #region Q1
            //1. Get first Product out of Stock 

            //var prod = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(prod);
            #endregion

            #region Q2
            /*2.Return the first product whose Price > 1000, unless there is no
                match, in which case null is returned.*/

            //var prod = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //if (prod != null)
            //    Console.WriteLine(prod);
            //else
            //    Console.WriteLine("Not Found");
            #endregion

            #region Q3
            //3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(x => x > 5)
            //    .ElementAtOrDefault(1);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region Q1
            //1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddCount = Arr.Count(x => x % 2 != 0);

            //Console.WriteLine(oddCount);
            #endregion

            #region Q2
            //2. Return a list of customers and how many orders each has.

            //var result = CustomersList.Select(c => new
            //{
            //    Name = c.CustomerName,
            //    Orders = c.Orders.Count()
            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q3
            //3. Return a list of categories and how many products each has

            //var result = ProductsList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductsCount = g.Count()
            //    });

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q4
            //4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int sum = Arr.Sum();
            //Console.WriteLine(sum);
            #endregion

            #region Q5
            /*5.Get the total number of characters of all words in 
             * dictionary_english.txt (Read dictionary_english.txt into Array
             * of String First).*/

            //var result = dictionary_english.Sum(w => w.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q6
            /*6. Get the length of the shortest word in dictionary_english.txt
             * (Read dictionary_english.txt into Array of String First).*/

            //var result = dictionary_english.Min(w => w.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q7
            /*7. Get the length of the longest word in dictionary_english.txt
             * (Read dictionary_english.txt into Array of String First).*/

            //var result = dictionary_english.Max(w => w.Length);
            //Console.WriteLine(result);
            #endregion

            #region Q8
            /*8. Get the average length of the words in dictionary_english.txt
             * (Read dictionary_english.txt into Array of String First).*/

            //var result = dictionary_english.Average(w => w.Length);
            //Console.WriteLine(result);
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region Q1
            //1. Sort a list of products by name

            //var result = ProductsList.OrderBy(p => p.ProductName);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q2
            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(w => w, new InsensStringComparer());
            //foreach (string str in result)
            //    Console.WriteLine(str);
            #endregion

            #region Q3
            //3. Sort a list of products by units in stock from highest to lowest.

            //var result = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q4
            //4. Sort a list of digits, first by length of their name,
            //and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.OrderBy(w => w.Length)
            //    .ThenBy(w => w);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q5
            //5. Sort first by-word length and then by a case-insensitive sort of
            //the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var ressult = Arr.OrderBy(w => w.Length)
            //    .ThenBy(w => w, new InsensStringComparer());

            //foreach (var item in ressult)
            //    Console.WriteLine(item);
            #endregion

            #region Q6
            /*6. Sort a list of products, first by category, and then by unit price,
             * from highest to lowest.*/

            //var result = ProductsList.OrderByDescending(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q7
            /*7. Sort first by-word length and then by a case-insensitive descending
            sort of the words in an array.*/

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(w => w.Length)
            //    .ThenByDescending(w => w, new InsensStringComparer());

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q8
            /*8. Create a list of all digits in the array whose second letter is 
                 'i' that is reversed from the order in the original array.*/

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(w => w.IndexOf('i') == 1)
            //    .Reverse()
            //    .ToList();

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion
            #endregion

            #region LINQ – Transformation Operators
            #region Q1
            //1. Return a sequence of just the names of a list of products.

            //var result = ProductsList.Select(p => new
            //{
            //    p.ProductName
            //});
            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q2
            /*2. Produce a sequence of the uppercase and lowercase versions of each
                 word in the original array (Anonymous Types).*/

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower(),
            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q3
            /*3. Produce a sequence containing some properties of Products,
                 including UnitPrice which is renamed to Price in the resulting 
                 type.*/

            //var result = ProductsList.Select(p => new
            //{
            //    Id = p.ProductID,
            //    Name = p.ProductName,
            //    Price = p.UnitPrice
            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q4
            /*4. Determine if the value of int in an array matches their position
                 in the array.*/

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((x, i) => new
            //{
            //    x,
            //    IsInPlace = x == i
            //});

            //Console.WriteLine("Number: In-Place?");
            //foreach (var item in result)
            //    Console.WriteLine($"{item.x}: {item.IsInPlace}");
            #endregion

            #region Q5
            /*5. Returns all pairs of numbers from both arrays such that the number
                 from numbersA is less than the number from numbersB.*/

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA
            //    .SelectMany(a => numbersB, (a, b) => new { A = a, B = b })
            //    .Where(x => x.A < x.B);

            //Console.WriteLine("Pairs where a < b");
            //foreach (var item in result)
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            #endregion

            #region Q6
            //6. Select all orders where the order total is less than 500.00.

            //var result = CustomersList.SelectMany(c => c.Orders)
            //    .Where(o => o.Total < 500);

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Q7
            //7. Select all orders where the order was made in 1998 or later.

            //var result = CustomersList.SelectMany(c => c.Orders)
            //    .Where(o => o.OrderDate.Year >= 1998);

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion
            #endregion
        }
    }
}
