using System.Collections;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Ahmed","Ali","Mona","Sara","Omar","Samir","Salma","Mostafa"
            };

            List<int> numbers = new List<int> { 10, 3, 7, 15, 22, 5, 8, 30 };

            #region Q1
            //var result = names.Where(n => n.StartsWith('S'));

            //foreach (var n in result)
            //    Console.WriteLine(n);
            #endregion

            #region Q2
            //var result = numbers.Where(x => x > 10);

            //foreach (var x in result)
            //    Console.WriteLine(x);
            #endregion

            #region Q3
            //var result = names.FirstOrDefault();
            //Console.WriteLine(result);
            #endregion

            #region Q4
            //var result = numbers.LastOrDefault();
            //Console.WriteLine(result);
            #endregion

            #region Q5
            //var result = numbers.FirstOrDefault(x => x > 20, -1);
            //Console.WriteLine(result);
            #endregion

            #region Q6
            //ArrayList mixedNumbers = new ArrayList() { 1, 2.5, 3, 4.75, 5 };

            //var result = mixedNumbers.OfType<double>();
            //foreach (var number in result)
            //    Console.WriteLine(number);
            #endregion

            #region Q7
            //var evenNumbers = Enumerable.Range(0, 5)
            //    .Select(x => x * 2);

            //foreach (var item in evenNumbers)
            //    Console.WriteLine(item);
            #endregion

            #region Q8
            //var result = names.OrderBy(n => n);

            //foreach (var name in names)
            //    Console.WriteLine(name);
            #endregion

            #region Q9
            //var result = numbers.OrderByDescending(x => x);

            //foreach (var number in result)
            //    Console.WriteLine(number);
            #endregion
        }
    }
}
