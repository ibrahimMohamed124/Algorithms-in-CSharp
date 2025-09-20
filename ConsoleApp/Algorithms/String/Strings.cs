using System.Diagnostics.Metrics;

public class Strings
{

    // Reverse string
    public static string Reverse(string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }
        return reversed;
    }

    
    // Vowels counter
    public static int NumOfVowels(string str)
    {
        int count = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        str = str.ToLower();

        for (int i = 0; i < str.Length; i++)
        {
            if (vowels.Contains(str[i]))
            {
                count++;
            }
        }

        return count;
    }

    // Capitalize first letter
    public static string CapitalizeFirst(string str)
    {
        if (string.IsNullOrEmpty(str)) 
            return str;

        string firstLetter = str.Substring(0, 1);
        string remainLetters = str.Substring(1);
        string capitalizedFirst = firstLetter.ToUpper();
        return capitalizedFirst + remainLetters;
    }

    // check if a word is palindroome or not
    public static bool CheckPalindrome(string text)
    {

        for (int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    // Count Number of Characters in a String
    public static int NumberofChars(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (char.IsWhiteSpace(c))
            {
                continue;
            }
            else
            {
                count++;
            }
        }
        return count;
    }


    /// Check if two word are Anagram
    public static bool CheckAnagram(string str1, string str2)
    {
        string chars = "abcdefghijklmnopqrstuvwxyz";
        // string1 list of indexes
        List<int> indexesOfStr1 = new List<int>();
        // string2 list of indexes
        List<int> indexesOfStr2 = new List<int>();
        // Lowercase all letter to avoid any logical errors
        string str1Lower = str1.ToLower();
        string str2Lower = str1.ToLower();

        // string1 exract indexes ing list 
        for (int i = 0; i < str1.Length; i++)
        {
            int index = chars.IndexOf(str1Lower[i]);
            indexesOfStr1.Add(index);
        }

        // strin2 extract indexes in list
        for (int i = 0; i < str2.Length; i++)
        {
            int index = chars.IndexOf(str2Lower[i]);
            indexesOfStr2.Add(index);
        }

        // covert list to array
        int[] indexesOfStr1Array = indexesOfStr1.ToArray();
        int[] indexesOfStr2Array = indexesOfStr2.ToArray();

        // now we going to sort the two of arrays 
        int[] indexesOfStr1ArraySorted = ArrayAlgorithms.Sort(indexesOfStr1Array);
        int[] indexesOfStr2ArraySorted = ArrayAlgorithms.Sort(indexesOfStr2Array);

        // get the sum of two arrays
        int SumOfIndexesOfStr1ArraySorted = ArrayAlgorithms.SumOfElementsInArray(indexesOfStr1ArraySorted);
        int SumOfIndexesOfStr2ArraySorted = ArrayAlgorithms.SumOfElementsInArray(indexesOfStr2ArraySorted);

        // check anagram
        if (SumOfIndexesOfStr1ArraySorted != SumOfIndexesOfStr2ArraySorted)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
