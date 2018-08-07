using System;

namespace FindDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 1, 3, 5, 3, 2 };

            var numbers = new IsDuplicate();
            var result = numbers.containsDuplicates(a);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
