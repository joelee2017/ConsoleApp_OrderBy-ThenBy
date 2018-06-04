using System;
using System.Linq;

namespace ConsoleApp_OrderBy_ThenBy
{
    class Program
    {
        static void Main(string[] args)
        {
            //order list.
            var nameValues = new[]
            {
                new { name = "allen", value = 65, group= "a" },
              new { name = "abbey", value = 120, group= "a" },
              new { name = "slong", value = 330, group= "b" },
              new { name = "george", value = 213, group= "c" },
              new { name = "meller", value = 329, group= "c" },
              new { name = "mary", value = 192, group= "b" },
              new { name = "sue", value = 200, group= "c" }
            };

            //single sort
            var sortedNames = nameValues.OrderBy(c => c.name);
            var sortedValues = nameValues.OrderBy(c => c.value);

            Console.WriteLine("== OrderBy() demo: sortedName ==");
            foreach(var q in sortedNames)
            {
                Console.WriteLine($"name: {q.name}  value:{q.value}");
            }

            Console.WriteLine("== OrderBy() demo: sortedValues =="); ;
            foreach(var q in sortedValues)
            {
                Console.WriteLine($"name: {q.name}  value:{q.value}");
            }

            //multiple sort conditions.
            var sortedByNameValues = nameValues.OrderBy(c => c.name).ThenBy(c => c.value);
            var sortedByValueNames = nameValues.OrderBy(c => c.value).ThenBy(c => c.name);

            Console.WriteLine("== OrderBy() + ThenBy() demo: sortedByNameValues ==");
            foreach(var q in sortedByNameValues)
            {
                Console.WriteLine($"name: {q.name} value: {q.value}");
            }

            Console.WriteLine("== OrderBy() + ThenBy() demo: sortedByValueNames ==");
            foreach(var q in sortedByValueNames)
            {
                Console.WriteLine($"name: {q.name} value: {q.value}");
            }

            Console.Read();
        }
    }
}
