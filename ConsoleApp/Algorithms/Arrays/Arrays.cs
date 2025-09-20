public class ArrayAlgorithms
{

    // This Method Prints an Array
    public static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }

    }

    // largest number array
    public static int LargestNumber(params int[] numbers)
    {
        int largest = 0;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        return largest;
    }

    // second largest array
    public static int SecondLargestNumber(params int[] numbers)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num < largest)
            {
                secondLargest = num;
            }
        }

        return secondLargest;
    }

    // smallest number
    public static int SmallestNumber(params int[] numbers)
    {
        int smallest = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num < smallest)
            {
                smallest = num;
            }
        }

        return smallest;
    }

    // Bubble Sort algorithm
    public static int[] Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                int firstElement = arr[j];
                int secondElement = arr[j + 1];
                if (firstElement > secondElement)
                {
                    int temp = firstElement;
                    firstElement = secondElement;
                    secondElement = temp;
                }
            }
        }
        return arr;
    }

    // Remove Duplicates from array
    public static int[] RemoveDuplicate(params int[] numbers)
    {
        List<int> uniqueList = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            bool exists = false;

            for (int j = 0; j < uniqueList.Count; j++)
            {
                if (numbers[i] == uniqueList[j])
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                uniqueList.Add(numbers[i]);
            }
        }

        int[] uniqueNumbers = uniqueList.ToArray();

        return uniqueNumbers;
    }


    // Find Missing Number in Array
    public static int FindMissingNumber(int[] arr)
    {
        int count = 1;
        int Missing = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            count++;
            if ((arr[i + 1] - arr[i]) != 1)
            {
                Missing = count;
                break;
            }
        }
        return Missing;
    }

    // sum of elements in an array
    public static int SumOfElementsInArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
}




