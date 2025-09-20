using System;
class StringAlgorithmTests : Test
{
    public override void RunTest()
    {
        string textStr = "Ibrahim Mohamed Talaat Mohamed Basiouny";
        string singleWordStr = "software";

        // Reverse String
        Console.WriteLine("Reversed: " + Strings.Reverse(singleWordStr));

        // Count number of Vowels in s String
        Console.WriteLine("This Text has " + Strings.NumOfVowels(textStr) + " Vowles");

        // capitalize first letter
        Console.WriteLine("Capitalized first letter: " +Strings.CapitalizeFirst(singleWordStr));

        // check if a word is palindrome
        bool palindrome = Strings.CheckPalindrome(singleWordStr);
        if (palindrome == true)
        {
            Console.WriteLine($"{singleWordStr} is Palindrome");
        }
        else
        {
            Console.WriteLine($"{singleWordStr} is Not Palindrome");
        }


        // Count Number of Character in a String
        Console.WriteLine("This String has " + Strings.NumberofChars("ibrahim mohamed talaat mohamed basiouny") + " Characters");


        // Check anagram
        bool isAnagram = Strings.CheckAnagram("silent", "listen");
        if (isAnagram == false)
        {
            Console.WriteLine("These Stringrs are not anagram");
        }
        else
        {
            Console.WriteLine("These Words are anagram");
        }

    }
}

