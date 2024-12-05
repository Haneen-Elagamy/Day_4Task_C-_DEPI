using System;
using System.ComponentModel;

namespace Day04Task
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {

            #region Problem_1+Que  
            //// 1. Initializing with new int[size]
            //int[] Arr1=new int[5];
            //Arr1[0]=1;
            //Arr1[1]=2;  
            //Arr1[2]=3;  
            //Arr1[3]=4;
            //Arr1[4]=5;

            //for (int i = 0; i < Arr1.Length; i++)
            //{ 
            //    Console.WriteLine(Arr1[i]);
            //}

            //// 2. Initializing with initializer list
            //int[] Arr2 = {10,20,30,40,50};
            //for(int i=0;  i < Arr2.Length; i++)
            //{
            //    Console.WriteLine(Arr2[i]);
            //}

            //// 3. Initializing with array syntax sugar
            //int[] Arr3 = new[] {100,200,300,400,500};
            //for (int i = 0; i < Arr3.Length; i++)
            //{
            //    Console.WriteLine(Arr3[i]);
            //}

            //o Demonstrates an IndexOutOfRangeException.

            //try
            //{
            //    Console.WriteLine(Arr3[5]);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // Question: What is the default value assigned to array elements in C#?
            /*
             * In C#, the default value assigned to array elements depends on the type of the array:
              For numeric types (e.g., int, double, float), the default value is 0.
              For bool arrays, the default value is false.
              For reference types (e.g., string, custom objects), the default value is null.
              For char arrays, the default value is the null character ('\0').
             */
            #endregion

            #region problem_2+ Que
            //int[] arr1 = new[] { 5, 10, 15, 20, 25, 30 };
            //int[] arr2 = new[] { 3, 6, 9, 12, 15, 18 };
            ////shallow copy

            //arr2 = arr1;
            ////arr2 --> unreachable object --> Garbage collector
            //Console.WriteLine(arr1.GetHashCode());//58225482
            //Console.WriteLine(arr2.GetHashCode());//58225482
            //arr1[0] = 4;
            //Console.WriteLine(arr2[0]);//4

            //arr2 = (int[])arr1.Clone();
            //Console.WriteLine(arr2.GetHashCode());//54267293  

            //arr1[1] = 200;
            //Console.WriteLine(arr2[1]);//10 not affected 

            // Question: What is the difference between Array.Clone() and Array.Copy()?
            /*Array.Clone() creates a shallow copy of the entire array, returning a new instance of the array.
             Array.Copy() allows more flexibility by specifying source and destination arrays, and can also be
             */
            ////Array.clone();
            //int[] originalArray = { 1, 2, 3, 4 };
            //int[] clonedArray = (int[])originalArray.Clone();

            ////Array.copy();
            //int[] sourceArray = { 1, 2, 3, 4 };
            //int[] destinationArray = new int[4];
            //Array.Copy(sourceArray, destinationArray, 4);  // Copy all elements
            #endregion

            #region problem_3+ Que  

            ////o Create a 2D array with student grades (3 students, 3 subjects each).
            //int[,] Grades=new int[3,3];
            ////o Take input from the user to fill the array.
            //for (int i = 0;i< 3;i++)
            //{
            //    Console.WriteLine($"Enter grades for student {i+1}: ");
            //    for(int j = 0;j< 3;j++)
            //    {
            //        bool ValidInput = false;
            //       while(!ValidInput)
            //        {
            //            Console.WriteLine($"Enter grades for subject {j + 1}: ");
            //            string Input = Console.ReadLine();
            //            if (int.TryParse(Input, out Grades[i, j]))
            //            {
            //                ValidInput = true;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid Input,Please Enter a Valid input!  ");
            //            }
            //        }

            //    }
            //    Console.WriteLine();
            //}

            ////o Print the grades for each student using nested loops.

            //Console.WriteLine("Students Grades: /n");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Student {i + 1}: ");
            //    for(int j = 0; j< 3; j++)
            //    {
            //        Console.WriteLine($"Subject {j + 1}: ");
            //        Console.WriteLine(Grades[i,j]);
            //    }
            //    Console.WriteLine() ;
            //}

            //Question: What is the difference between GetLength() and Length for multidimensional
            //arrays ?
            /*
             * GetLength(dimension): Retrieves the size of a specific dimension in a multidimensional array.
               Length: Returns the total number of elements across all dimensions in the array.
             */

            ////GetLength
            //int[,] arr = new int[3, 4]; // 3 rows, 4 columns
            //int rows = arr.GetLength(0); // 3 (size of the first dimension)
            //int columns = arr.GetLength(1); // 4 (size of the second dimension)
            //Console.WriteLine($"Rows: {rows}, Columns: {columns}");

            ////Length
            //int[,] arr1 = new int[3, 4]; // 3 rows, 4 columns
            //int totalLength = arr1.Length; // 12 (3 * 4)
            //Console.WriteLine($"Total elements: {totalLength}"); 
            #endregion

            #region problem_4+Que  

            //int[] Arr01 = { 15, 3, 5, 7, 1, 9, 10, 2, 10 };
            //int[] Arr02 = new int[5];

            //Array.Sort(Arr01);
            //foreach (int i in Arr01)
            //{
            //        Console.WriteLine(i);//1,2,3,5,7,9,10,10,15
            //}
            //Console.WriteLine("===========================");

            //Array.Reverse(Arr01);
            //foreach(int i in Arr01)
            //{
            //    Console.WriteLine(i);//15,10,10,9,7,5,3,2,1
            //}
            //Console.WriteLine("============================");

            //int Index = Array.IndexOf(Arr01, 10);
            //Console.WriteLine(Index);//1
            //Console.WriteLine("===========================");

            //Array.Copy(Arr01, Arr02,3);
            //foreach(int i in Arr02)
            //{
            //    Console.WriteLine(i);//15,10,10,0,0
            //}
            //Console.WriteLine("===========================");

            //Array.Clear(Arr01,3,2);
            //foreach (int i in Arr01)
            //{
            //    Console.WriteLine(i);//15,10,10,0,0,5,3,2,1
            //}

            //Question: What is the difference between Array.Copy() and Array.ConstrainedCopy() ?
            /*
             * Array.Copy():
             -Copies elements from one array to another.
             -If an error occurs during copying, the destination array might be partially updated.
             -It does not handle overlapping regions properly and is faster due to minimal checks.

            Array.ConstrainedCopy():
            -Similar to Array.Copy() but safer.
            -Ensures that either the entire copy operation succeeds or nothing changes (all-or-nothing).
            -Handles overlapping regions correctly but has more overhead, so it’s slightly slower.
             */
            #endregion

            #region problem_5+Que  
            //int[] Array01 = { 1, 2, 3, 4, 5, 6, 7 };
            ////o Uses a for loop to print all elements of a 1D array.
            //for (int i = 0; i < Array01.Length; i++)
            //{
            //    Console.WriteLine(Array01[i]);
            //}
            ////o Uses a foreach loop to print all elements of the same array.
            //foreach (int item in Array01)
            //{
            //    Console.WriteLine(item);
            //}

            ////o Uses a while loop to print all elements in reverse order.
            //int j =Array01.Length-1;
            //while (j>=0)
            //{
            //    Console.WriteLine(Array01[j]);
            //    j--;
            //}

            // Question: Why is foreach preferred for read-only operations on arrays?
            /*
          -Simplicity and Readability:
          foreach makes the code cleaner and easier to understand, especially when iterating over all elements.

          Safety:
          -Prevents accidental modification of elements since it operates on a copy of each element, not the actual array.

          -No Index Management:
          Eliminates the need to manually handle indices or worry about IndexOutOfRangeException.

          -Purpose-Built for Iteration:
          Designed for iterating through collections, making it ideal for read-only scenarios.
             */
            #endregion

            #region problem_6+Que  
            /*Problem: Write a program that:
                o Repeatedly asks the user for a positive odd number.
                 o Uses defensive coding to validate input using int.TryParse and a do-while loop.
                 */
            //int Number;
            //bool IsValid;
            //do
            //{
            //    Console.WriteLine("Enter a positive odd number,Please!");
            //    IsValid=int.TryParse(Console.ReadLine(), out Number);

            //    if(!IsValid||Number<=0||Number%2==0)
            //    {
            //        Console.WriteLine("Invalid Input, Make sure it is a positive odd number");
            //        IsValid = false;
            //    }

            //}
            //while (!IsValid);
            //Console.WriteLine($"You entered a valid number {Number}");

            // Question: Why is input validation important when working with user inputs?
            /*
             * Prevents Errors and Crashes:
              Invalid inputs, such as entering text where numbers are expected, can cause runtime errors or program crashes.

              Enhances Security:
              Input validation protects against malicious inputs, such as SQL injection or script attacks, by ensuring only acceptable data is processed.

              Improves User Experience:
              It provides clear feedback, allowing users to correct their mistakes instead of dealing with vague or confusing errors.

              Ensures Data Integrity:
              Validated inputs maintain consistency and correctness in stored or processed data.

             Reduces Debugging Effort:
             Handling unexpected inputs proactively minimizes issues during program execution.
             */
            #endregion

            #region problem_7+Que  
            //int[,] array=new int[2, 2] { { 1,2 },{ 3,4 } };

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j]+" ");//1 2
            //    }                                  //3 4
            //    Console.WriteLine();
            //}
            //Question: How can you format the output of a 2D array for better readability?
            /* Align Columns Using Padding
            Use String.PadLeft or String.PadRight to align the elements in a grid-like structure.
            This is helpful when numbers have varying lengths.
             ex-->Console.Write(array[i, j].ToString().PadLeft(5) + " "); // Right-align with 5 spaces
             */
            #endregion

            #region problem_8+ Que  
            //Console.WriteLine("Enter a month's number (1-12):");
            //string input = Console.ReadLine();

            //string monthsName = "Invalid month"; // Initialize with a default value
            //if (int.TryParse(input, out int monthsNumber) && monthsNumber > 0 && monthsNumber <= 12)
            //{
            //    if (monthsNumber == 1) monthsName = "January";
            //    else if (monthsNumber == 2) monthsName = "February";
            //    else if (monthsNumber == 3) monthsName = "March";
            //    else if (monthsNumber == 4) monthsName = "April";
            //    else if (monthsNumber == 5) monthsName = "May";
            //    else if (monthsNumber == 6) monthsName = "June";
            //    else if (monthsNumber == 7) monthsName = "July";
            //    else if (monthsNumber == 8) monthsName = "August";
            //    else if (monthsNumber == 9) monthsName = "September";
            //    else if (monthsNumber == 10) monthsName = "October";
            //    else if (monthsNumber == 11) monthsName = "November";
            //    else monthsName = "December";
            //}
            //Console.WriteLine(monthsName);


            ////switch
            //string monthsName2 ; 
            //if (int.TryParse(input, out int monthsNumber2))
            //{
            //    switch (monthsNumber)
            //    {
            //        case 1: monthsName2 = "January"; break;
            //        case 2: monthsName2 = "February"; break;
            //        case 3: monthsName2 = "March"; break;
            //        case 4: monthsName2 = "April"; break;
            //        case 5: monthsName2 = "May"; break;
            //        case 6: monthsName2 = "June"; break;
            //        case 7: monthsName2 = "July"; break;
            //        case 8: monthsName2 = "August"; break;
            //        case 9: monthsName2 = "September"; break;
            //        case 10: monthsName2 = "October"; break;
            //        case 11: monthsName2 = "November"; break;
            //        case 12: monthsName2 = "December"; break;
            //        default:monthsName2 = "invalid month";break;
            //    }
            //}
            //Console.WriteLine(monthsName);

            // Question: When should you prefer a switch statement over if-else?
            /*Multiple Conditions on the Same Variable:
            Use a switch when you are evaluating multiple possible values of a single variableor expression. 
            It is more concise and readable than using many if-else blocks.

            Better Readability:
            For scenarios with many conditions, switch is easier to read
            and maintain compared to nested or chained if-else.

            Performance:
            In some cases, especially with a large number of cases, switch can be optimized by the compiler 
            to use jump tables or other faster structures compared to sequential if-else evaluations.

            Clarity for Simple Values:
            When conditions depend on simple, discrete values (like integers, enums, or strings), 
            switch provides a clean structure.

            Avoid Using switch:
            When conditions involve complex logical comparisons or ranges 
            (e.g., x > 10 or y == 5 && z < 20). In such cases, if-else is more suitable.
             */

            #endregion

            #region problem_9+Que  
            /*Problem: Write a program to:
              o Sort an array of integers using Array.Sort().
              o Search for a specific value using Array.IndexOf() and Array.LastIndexOf().
                */
            // int[] Array01 = { 5, 9, 3, 11, 7, 10, 6, 6 };
            // Array.Sort(Array01);
            // foreach (int i in Array01)
            // {
            //     Console.WriteLine(i);
            // }

            //int Index=Array.IndexOf(Array01, 10);
            //Console.WriteLine(Index);

            // Question: What is the time complexity of Array.Sort()?
            /*Array.Sort() uses a variation of the QuickSort algorithm, specifically Introsort,
             * which is a hybrid of QuickSort, HeapSort, and InsertionSort.
             * 
            Average Case: O(n log n)
            Worst Case: O(n log n) (Due to the fallback to HeapSort for better performance 
            in degenerate cases of QuickSort).
             */
            #endregion

            #region problem_10+Que  
            /* Problem: Write a program that:
               o Creates an array of integers.
               o Uses a for loop to calculate and print the sum of all elements.
               o Uses a foreach loop to calculate the same sum
                 */

            //int[] Array02 = { 55, 60, 45, 99, 150, 22 };
            //int Sum=0;
            //for (int i = 0; i < Array02.Length; i++)
            //{
            //    Sum += Array02[i];
            //}
            //Console.WriteLine(Sum);

            //Sum= 0;
            //foreach (int number in Array02)
            //{
            //    Sum += number;
            //}
            //Console.WriteLine(Sum);

            //Question: Which loop (for or foreach) is more efficient for calculating the sum of an array, and why?

            /*In general, both for and foreach loops are quite efficient for calculating the sum of an array in C#,
             * but there are some subtle differences in performance that might influence your choice depending on the specific scenario.

             Performance Comparison:
             For Loop:
               Efficiency: The for loop is slightly more efficient when you need to use the index to access array elements.
               This is because it directly accesses the array elements by their index, which may result in a minimal performance gain, especially in large arrays.
               Use Case: If you need to manipulate the index or need a more controlled iteration, the for loop is often preferred.

            Foreach Loop:
             Efficiency: The foreach loop, on the other hand, is more concise and easier to read. It avoids manual indexing, which makes the code cleaner. 
             Internally, it uses an enumerator to iterate over the collection, and while this adds a tiny overhead, the difference is negligible for most use cases.
             Use Case: The foreach loop is generally used when you don't need the index, 
             and you want to work directly with the elements of the array.
             */
            #endregion

            #region Enum  
        //    Console.WriteLine("Enter a number between 1 and 7 to get the corresponding day of the week:");
        //    int input = int.Parse(Console.ReadLine());

        //    if (input >= 1 && input <= 7)
        //    {
        //        // Convert integer to enum using Enum.Parse
        //        DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input.ToString());
        //        Console.WriteLine($"The day corresponding to {input} is {day}.");
        //}
        //    else
        //    {
        //        Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
        //    }
            //3- What happens if the user enters a value outside the range of 1 to 7?
            /*
             * If the user enters a value outside the range of 1 to 7 in the program using Enum.Parse,
             * the program will attempt to parse the value as an enum. However, since the value doesn't correspond 
             * to any defined enum member, no exception is thrown (as long as the input is a valid integer).
             * Instead, the parsed value will be treated as a valid enum value with the given numeric representation,
             * even though it doesn't match any explicitly defined enum name.

              Example:
              If the user enters 10:
             The Enum.Parse method converts 10 to an instance of DayOfWeek with the numeric value 10.
              When printed, it will display 10.
              This can lead to unintended behavior since the program might output a numeric value as if it were valid.
             */
            #endregion





        }


    }
}
