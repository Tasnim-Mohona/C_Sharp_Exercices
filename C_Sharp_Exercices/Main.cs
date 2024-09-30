using System;

namespace C_Sharp_Exercices
{
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SwapNumbers swapNumbers = new SwapNumbers();
            swapNumbers.Swap();

            // Initializing string arrays with different sets of strings
            LongestCommonPrefixFromArrayofStrings common = new LongestCommonPrefixFromArrayofStrings();

            string[] arr_strings1 = { "Pandas", "Panther" };
            Console.Out.WriteLine("Original Strings: " + $"{ string.Join(", ", arr_strings1)}");
            Console.WriteLine("Longest common prefix from the said array of strings: " + common.test(arr_strings1));

        }
    }
}
