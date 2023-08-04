namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary search (recursive implementation)");
            Console.WriteLine("Enter the elements of array");
            var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                array[i] = Convert.ToInt32(s[i]);
            }
            Array.Sort(array);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", array));
            while(true)
            {
                Console.WriteLine("Enter the desired value or -1 for the output");
                var k = Convert.ToInt32(Console.ReadLine());
                if (k == -1)
                {
                    break;
                }
                var searchResult = BinarySearch.SearchBinary(array, k, 0, array.Length - 1);
                if(searchResult < 0)
                {
                    Console.WriteLine("Element with value {0} not found", k);
                }
                else
                {
                    Console.WriteLine("The element is found. The index of an element with the value {0} is equal to {1}", k, searchResult);
                }
            }

        }
    }
}