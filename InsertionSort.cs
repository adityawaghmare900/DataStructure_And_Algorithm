using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorthms_Problems
{
    internal class InsertionSort
    {
        public static void insertionsort(string[] input)
        {
            int n=input.Length;
            for(int i=1;i<n; i++)
            {
                string temp = input[i];
                int j=i-1;

                while (j>=0 && string.Compare(input[j], temp)>0  )
                {
                    input[j+1] = input[j];
                    j = j - 1;
                }
                input[j+1]=temp;
            }
        }

        public static void sort()
        {
            Console.WriteLine("enter the string: ");
            string inputString = Console.ReadLine();

            string[] words = inputString.Split(new[] { ' ' });
            
           insertionsort(words);
            Console.WriteLine("sorted list: ");
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
