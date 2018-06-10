using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Search
{
    class Array_Search
    {
        static void Main(string[] args)
        {
            var missingNumbers = FindMissingNumber();
            StringBuilder builder = new StringBuilder();

            foreach (var num in missingNumbers)
            {
                builder.Append(num).Append(",");
            }

            Console.WriteLine(builder.ToString().TrimEnd(new char[] { ',' }));
        }

        private static IEnumerable<int> FindMissingNumber()
        {
            var list = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToArray();


            var missingNumbers = Enumerable.Range(1, list.Length).Except(list);
            return missingNumbers;
        }
    }
}
