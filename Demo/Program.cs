namespace Demo
{
    internal class Program
    {
        #region Functions0
        ////no arg
        //public static void Print()
        //{
        //    for(int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("(*_*)");
        //    }

        //}
        //with arg
        //public static void Print(int count , string pattern )
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(pattern);
        //    }

        //}

        #endregion

        #region FunctionParameters0
        //static void Swap(int x , int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #region function02
        //static int SumArray(int[] Arr)
        //{
        //    int sum = 0;
        //    for(int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;     
        //}
        //by ref:
        //static int SumArray(ref int[] Arr)
        //{
        //    int sum = 0;
        //    if(Arr is not null)
        //    {
        //        Arr[0] = 100;
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];
        //        }

        //    }
           
        //    return sum;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Casting[Boxing - Unboxing]

            #region Ex01
            //object o1;
            //o1 = "Ahmed"; //Casting
            //o1 = 1; //Casting[value Type -> Refrence Type] Boxing
            //o1 = 'A'; //Casting[value Type -> Refrence Type] Boxing
            //o1 = new Employee(); //Casting 
            #endregion

            #region Ex02
            //int X = 10;
            //object obj = X; // Boxing - Safe Casting
            //                //obj= new object(10);
            //                // parent => child
            //                // Animal => Dog(Dog is Animal)
            //object obj02 = 10;
            //int Y = (int) obj02; //Casting from ref to value type Unboxing 
            ////if not int it will give me exception [Unsave Casting]



            #endregion



            #endregion

            #region Nullable Type
            //Null As a Value Is Valid Only with Refrence Type

            // int X = null; //Invalid
            // int X => X allow Only int Numbers

            // int? Y = null; //Valid
            // int ? Y => Allow Int Values + Null

            //int? Y = null;
            //int X = 10; //Valid
            ////int? Z = Y; //Valid
            //int? Z = X; //Valid

            //int? Number; //Nullable <int> Number
            //             //Nullable -> Allow Null + Values

            ////decimal Num01 = 1.1M;
            ////decimal? Num02 = Num01;

            //decimal? Num01 = null;

            //int X = 10;
            //int? Y = /*(int?)*/ X; //Valid Implicit Casting
            ////Safe Casting

            //int? Number01 = null;
            //int Number02 = (int) Number01; //Explicit casting 
            ////Unsafe Casting

            //Example
            //int? K = null;
            //int L;
            ////L = (int)K; // Unsafe
            //if (K != null)
            //{
            //    L = (int)K;
            //}
            //else
            //{
            //    L = 0;
            //}

            //if(K.HasValue)
            //{
            //    L = K.Value; //Not Casting
            //}
            //else
            //{
            //    L = 0;

            //}

            //L= K.HasValue ? K.Value : 0;
            //L= K != null ? K.Value : 0;
            //////////////////////////////////////////////////

            //Nullable Refrence Type
            //string Message = "Hi";
            //Message = null;//Valid with warning
            //Message = null!; // ! -> Null forgiveness operator

            //string? Message02 = null; //Valid without Warning

            #region EX01
            // Employee Employee01 = new Employee();

            #endregion

            //string NotNull = "Hello";

            //string? Nullable = default; //Null

            ////NullableString = NotNull; //Valid






            #endregion

            #region Functions
            //Program.Print(); //no need to call program
            //Print(); // no parameter
            // Print(15, ":p");
            // Print( ":p" , 2);//Invalid
            // Print(pattern:"<3",count: 7); //passing param by name

            //notes
            // \n => new line
            // \t => tab


            #endregion

            #region Functions Parameters
            //  int a = 10, b = 20;
            //Swap(a, b);
            //Explaination in my notes

            #endregion

            #region Functions02
           // int[] Arr = { 1, 2, 3 };
            //arr -> reference [address of Array]
          //int result =  SumArray(Arr);//pass by value
           // Console.WriteLine(result);

           // int[] Arr = { 1, 2, 3 };    
           //int result = SumArray(ref Arr); // passing by ref
           // Console.WriteLine(result); //Array itself

            #endregion



        }
    }
}
