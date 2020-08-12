using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace JeffBartonArraysEX6A
{
    class Arrays
    {
        static void Main(string[] args)

        {
            int[][] Arrays =
            {
                new int[] {0, 2, 4, 6, 8, 10},
                new int[] {1,3,5,7,9},
                new int[] {3,1,4,1,5,9,2,6,5,3,5,9}
            };
            //iterate through arrays giving the # of arrays, then the length of a specified array
            Console.WriteLine(Arrays.Length);
            Console.WriteLine(Arrays[2].Length);
            //iterates through the arrays listing them out
            for (int i = 0; i < Arrays.Length; i++)
            {
                for (int k = 0; k < Arrays[i].Length; k++)
                {
                    Console.Write(Arrays[i][k] + " ");
                }
                Console.WriteLine();
            }
            int[] array0 = { 0, 2, 4, 6, 8, 10 };
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            int sum0 = array0.Sum();
            int sum1 = array1.Sum();
            int sum2 = array2.Sum();

            double avg0, avg1, avg2 = 0;
            double[] num0 = { 0, 2, 4, 6, 8, 10 };
            //rotated 2 places left: 4, 6, 8, 10, 0, 2
            double[] num1 = { 1, 3, 5, 7, 9 };
            //rotate 2 to the right 7, 9, 1, 3, 5
            double[] num2 = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            //rotate 4 to the left 5, 9, 2, 6, 5, 3, 5, 9, 3, 1, 4, 1
            for(int l=0; l < num0.Length; l++)
            {
               // sum0 += num0[i];
            }
            avg0 = sum0 / num0.Length;
            avg1 = sum1 / num1.Length;
            avg2 = sum2 / num2.Length;
            Console.WriteLine($"The average of the arrays are {avg0}, {avg1}, and {avg2}");
            //return (Arrays / Arrays.Length); this commented out line of code didn't work
            Console.WriteLine($"The sum of the 3 arrays are {sum0}, {sum1}, and {sum2}");

            Array.Reverse(array0);
            Array.Reverse(array1);
            Array.Reverse(array2);

            Console.WriteLine($"The array0 in reverse: " + string.Join(", ", array0));
            Console.WriteLine($"The array1 in reverse: " + string.Join(", ", array1));
            Console.WriteLine($"The array2 in reverse: " + string.Join(", ", array2));
            //Rotating arrays return red squiggly...not sure. intellisense suggestion cleared it, but would not run.
            if(num0.Length== 0 || num0.Length ==1)
            {
                return num0;
            }
            int lastElement;
            int[] newArray = new int[array0.Length];

            List<int> listOfNumbers = new List<int>();

            for (int i = 1; i < 4; i++)
            {
                lastElement = array0[array0.Length - 1];
                newArray = array0.Take(array0.Length - 1).ToArray();
                listOfNumbers = newArray.ToList<int>();
                listOfNumbers.Insert(0, lastElement);

                array0 = listOfNumbers.ToArray();
                newArray = array0;
            }
            return newArray;
            
            //didn't work for rotating
            //Console.WriteLine($"num0: [{0}]", string.Join(", ", num0));
           //var shift0 = num0[0];
           //for (var i = 0; i < num0.Length - 1; i++)
           //{
           //    num0[i] = num0[i + 1];
           //}
           //num0[num0.Length - 1] = shift0;
           //Console.WriteLine($"Rotating array0 2 places left: [{0}]", string.Join(", ", num0));

            //List<int> list = 

            //for (int i = 0; i < array0.Length / 2; i++)
            //{
            //    int rev0 = array0[i];
            //    array0[i] = array0[array0.Length - i - 1];
            //    array0[array0.Length - i - 1] = rev0;
            //Console.WriteLine($"array0 {array0} in reverse is {rev0} ");
            //}
            
            //Console.WriteLine($"The average of the 3 arrays in order listed are {sum0 / array0.Length} , {sum1 / array1.Length}, and {sum2 / array2.Length}");


            //reverse array

            
           
           // int j = array0.Length - 1;
           // while (m < j)
           // {
           //     var rev0 = array0[m];
           //     array0[m] = array0[j];
           //     array0[j] = rev0;
           //     m++;
           //     j--;
           //nope. not it.
           // }
        }
    }
}