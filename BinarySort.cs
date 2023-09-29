using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorthms_Problems
{
    public  class BinarySort
    {
        public static bool binarysearch(string[] words, string search)
        {
            int left = 0;
            int right = words.Length-1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2; 
                int result = string.Compare(words[middle], search);

                if(result == 0)
                {
                    return true;
                }
                if(result< 0)
                {
                    left = middle + 1 ;
                }
                else
                {
                    right = middle - 1 ;
                }
            }
            return false;
        }
        public static void ReadTextFile(string textfile)
        {
            string[] words = File.ReadAllText("F:\\localRepository\\DataStructure & algorithm\\Algorthms Problems\\textfile.txt").Split(' ');
            Array.Sort(words);
            Console.WriteLine("Enter the word which want to find");
            string search=Console.ReadLine();
            
            bool found=binarysearch(words, search);
            if (found)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The word is found in the list");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("The word is not found in the list");
                Console.ResetColor();
            }
        }
    }
}
