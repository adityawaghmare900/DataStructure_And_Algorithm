using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorthms_Problems
{
    internal class BubbleSort
    {
        public static void bubblesort()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter the number wants to sort: ");
            int count = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("============================");
            Console.WriteLine("Enter {count} elements: ");
            for (int i = 0; i < count; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                list.Add(input);
            }

            //bubble sort
            int cnt = 1;
            while (cnt < list.Count)
            {
                for(int i=0;i<list.Count-cnt;i++) 
                {
                    if (list[i] > list[i+1])
                    {
                        int temp = list[i];
                        list[i] = list[i+1];
                        list[i+1] = temp;
                    }
                }
                cnt++;
            }
            Console.WriteLine("=======================");
            Console.WriteLine("Sorted list using bubble sort is: ");
            foreach (int i in list)
            { 
                Console.WriteLine(i);
            }
            
        }
        
    }
}
