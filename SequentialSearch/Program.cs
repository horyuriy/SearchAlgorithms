namespace SequentialSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 2, 4, 9, 0, 1, 3, 7, 8 };
            var index = arr.LinearSearch(22);
            if(index == -1)
            {
                Console.WriteLine("Element not found");
            }
            Console.WriteLine($"The index of an element with a value of 4 is {arr.LinearSearch(4)}");
            Console.WriteLine($"Minimum array element: index{arr.IndexOfMin()}; value {arr.MinValue()};");
            Console.WriteLine($"Maximum array element: index {arr.IndexOfMax()}; value {arr.MaxValue()};");

            Console.ReadLine();
        }
    }
}