using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Exercices
{
    class LongestCommonPrefixFromArrayofStrings
    {



        public string test(string[] arr_strings)
        {
            // Checking for edge cases :  empty array or an array containing an empty string
            if (arr_strings.Length == 0 || Array.IndexOf(arr_strings, "") != -1)
                return "";


            // Initilizing "result" to the first string in the array
            string result = arr_strings[0];
            int i = result.Length;

            // Looping through each work in the array to find the longest common prefix
            foreach (string word in arr_strings)
            {
                int j = 0;

                // Comparing characters at each position in the words
                foreach (char c in word)
                {
                    // Breaking if characters do nor match or index 'j' exceeds the length of the result
                    if (j >= i || result[j] != c)
                        break;
                    j += 1;
                }

                // Updating 'i' with the minimum value between 'i' and 'j'
                i = Math.Min(i, j);
            }

            // Returning the longest common prefix based on 'i'
            return result.Substring(0, i);
        }

    }
}