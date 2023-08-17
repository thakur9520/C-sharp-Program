//1. Write a C# program to find the sum of all elements in an integer array using a loop.

using System;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}



// 2. Create a C# program that calculates the average of values in a floating-point array using a loop
using System;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = (sum * 1.0) / arr.Length;
            Console.WriteLine(avg);
        }
    }
}



// 3. Develop a C# program that finds the largest element in an integer array using a loop and if-else statements.

using System;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}



// 4.  Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements.

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int max = arr[0];
            int even = 0, odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] & 1) == 1)
                {
                    odd++;
                }
                else { even++; }
            }
            Console.WriteLine("Number of odd numbers = " + odd + " and even numbers = " + even);
        }
    }
}

// 5. Implement a C# program that reverses the elements of an integer array using a loop.


using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int l = 0, r = arr.Length - 1;
            while (l < r)
            {
                int temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}


// 6. Create a C# program that multiplies each element in an integer array by a specified factor using a loop.



using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int mult = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * mult;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}


// 7. Write a C# program that searches for a specific value in an integer array using a loop and returns its index if found.



using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 90 };
            int search = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    index = i; break;
                }

            }
            Console.WriteLine(index);
        }
    }
}



// 8. Develop a C# program that finds the second smallest element in an integer array using loops and sorting techniques.


using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Inputoutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 44, 67, 12, 7 };
            int min = arr[0], min1 = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != min)
                {
                    if (arr[j] < min1)
                    {
                        min1 = arr[j];
                    }
                }
            }
            Console.WriteLine(min1);
        }
    }
}