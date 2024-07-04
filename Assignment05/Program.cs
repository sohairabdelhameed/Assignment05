using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Assignment05
{
    #region Question02--class
    class MyClass
    {
        public int Value { get; set; }
    } 

    #endregion
    internal class Program
    {
        #region Question01--Function
        // Pass by value
        //static void IncrementByValue(int x)
        //{
        //    x++;
        //}

        //// Pass by reference
        //static void IncrementByRef(ref int x)
        //{
        //    x++;
        //} 
        #endregion

        #region Question02--Function
        // Pass by value
        //static void ModifyObjectByValue(MyClass obj)
        //{
        //    obj.Value = 20;
        //}

        //// Pass by reference
        //static void ModifyObjectByRef(ref MyClass obj)
        //{
        //    obj = new MyClass { Value = 30 };
        //} 
        #endregion

        #region Question03--Function
        //static (int, int) SumAndSubtract(int a, int b, int c, int d)
        //{
        //    int sum = a + b + c + d;
        //    int subtract = a - b - c - d;
        //    return (sum, subtract);
        //} 
        #endregion

        #region Question04--Function
        //static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        #endregion

        #region Question05--Function
        //static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;
        //}
        #endregion

        #region Question06--Function
        //static void MinMaxArray(int[] array, out int min, out int max)
        //{
        //    min = array[0];
        //    max = array[0];
        //    foreach (int num in array)
        //    {
        //        if (num < min) min = num;
        //        if (num > max) max = num;
        //    }
        //}
        #endregion

        #region Question07--Function
        //static int Factorial(int number)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        #endregion

        #region Question08--Function
        static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }
            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }
        #endregion

        static void Main(string[] args)
        {
            #region Question01
            //Explain the difference between passing (Value type parameters)
            //by value and by reference then write a suitable c# example.
            // Passing by Value:
            // A copy of the variable is passed to the method. Changes made to the parameter do not affect the original variable.
            //Passing by Refrence:
            //A reference to the actual variable is passed. Changes made to the parameter affect the original variable.

            //Example:
            // int a = 5;
            //IncrementByValue(a);
            //Console.WriteLine($"After IncrementByValue: {a}"); // Output: 5

            //IncrementByRef(ref a);
            //Console.WriteLine($"After IncrementByRef: {a}"); // Output: 6
            #endregion

            #region Question02
            //Explain the difference between passing(Reference type parameters)
            // by value and by reference then write a suitable c# example
            //Passing by Value: 
            //A copy of the reference is passed.
            //Changes to the object's data will affect the original object, but reassigning the reference does not.
            //Passing by Refrence: A reference to the reference is passed.
            //Changes to the object and reassigning the reference both affect the original reference.

            //Example: 
            //MyClass myObj = new MyClass { Value = 10 };
            //ModifyObjectByValue(myObj);
            //Console.WriteLine($"After ModifyObjectByValue: {myObj.Value}"); // Output: 20

            //ModifyObjectByRef(ref myObj);
            //Console.WriteLine($"After ModifyObjectByRef: {myObj.Value}"); // Output: 30


            #endregion

            #region Question03
            //Function to Accept 4 Parameters and Return Summation and Subtraction
            //Console.WriteLine("Enter four numbers:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());

            //var result = SumAndSubtract(a, b, c, d);
            //Console.WriteLine($"Sum: {result.Item1}, Subtract: {result.Item2}");
            #endregion

            #region Question04
            //Write a program in C# Sharp to create a function to calculate the sum of
            //the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int result = SumOfDigits(number);
            //Console.WriteLine($"The sum of the digits of the number {number} is: {result}");

            #endregion

            #region Question05
            //Create a function named "IsPrime", which receives an integer number and
            //retuns true if it is prime, or false if it is not
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //bool result = IsPrime(number);
            //Console.WriteLine(result ? "The number is prime." : "The number is not prime.");


            #endregion

            #region Question06
            //Create a function named MinMaxArray, to return the minimum and
            //maximum values stored in an array, using reference parameters
            //int[] array = { 5, 1, 8, 3, 9, 2 };
            //MinMaxArray(array, out int min, out int max);
            //Console.WriteLine($"Minimum: {min}, Maximum: {max}");

            #endregion

            #region Question07
            //Create an iterative(non - recursive) function to calculate the factorial
            //of the number specified as parameter
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int result = Factorial(number);
            //Console.WriteLine($"Factorial of {number} is: {result}");

            #endregion

            #region Question08
           // create a function named "ChangeChar" to modify a letter in a certain
           //position(0 based) of a string, replacing it with a different letter
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //Console.Write("Enter the position to change (0-based): ");
            //int position = int.Parse(Console.ReadLine());
            //Console.Write("Enter the new character: ");
            //char newChar = Console.ReadKey().KeyChar;

            //string result = ChangeChar(input, position, newChar);
            //Console.WriteLine($"\nModified string: {result}");
            #endregion
        }
    }
}
