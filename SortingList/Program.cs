using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declares the main array
            int[] arr = { 5, 3, 6, 2, 10 };
            //Declares the lower variable and assing the value with a call of a function that find the lower value of the array
            int lower = findLower(arr);
            //Call the function that sort the array and build a new array with number already sorted
            sortArray(arr, lower);
            //Write on screen the array with commas
            Console.WriteLine(string.Join(",", arr));
        }

        //Function that find the lower value of the array
        static int findLower(int[] arr)
        {
            //Variable assing with the first element of the main array
            int lower = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                //if the value of the element in 'arr[i]' position is lower then the value of lower, then assign this value of variable lower
                if (arr[i] < lower)
                {
                    lower = arr[i];
                }
            }
            //retunr only ONE element of the array with lower value.
            return lower;
        }

        static void sortArray(int[] arr, int lower)
        {
            Array.Sort(arr);
            if (arr[0] != lower)
            {
                int index = Array.IndexOf(arr, lower);
                int temp = arr[0];
                arr[0] = arr[index];
                arr[index] = temp;
            }
        }
    }
}
