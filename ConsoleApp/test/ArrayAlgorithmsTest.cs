using System;

class ArrayAlgorithmsTest : Test
{
    public override void RunTest()
    {
        int[] testarr = { 1, 2, 7, 3, 14, 10 };
        int[] arrMin1 = { 1, 2, 4, 5, 6 };

        // largest number
        Console.WriteLine("The Largest Number is " + ArrayAlgorithms.LargestNumber(1, 2, 3, 4, 5));

        // second largest number
        Console.WriteLine("The Second Largest Number is " + ArrayAlgorithms.SecondLargestNumber(1, 2, 3, 4, 5));

        // smallest number
        Console.WriteLine("The Smallest Number is " + ArrayAlgorithms.SmallestNumber(1, 2, 3, 4, 5));

        // bubble sort
        int[] sorted = ArrayAlgorithms.Sort(testarr);
        Console.WriteLine("Sorted: " + string.Join(", ", sorted));

        // Find Missing Number
        Console.WriteLine("The Missing Number is " + ArrayAlgorithms.FindMissingNumber(arrMin1));

        // sum of element in an array 
        Console.WriteLine(ArrayAlgorithms.SumOfElementsInArray(arrMin1));
        
    }
}