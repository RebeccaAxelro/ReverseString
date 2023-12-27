using System;

class Program
{

// Time Complexity: O(n) - Linear time complexity, where n is the length of the input string. The loop iterates through each character of the string exactly once.
//Space Complexity: O(n) - Linear space complexity, where n is the length of the input string. An array of characters is used to store the reversed string.
    static string ReverseString(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length < 2)
            return str;

        char[] backwards = new char[str.Length];
        int totalItems = str.Length - 1;
        for (int i = totalItems, j = 0; i >= 0; i--, j++)
        {
            backwards[j] = str[i];
        }
        return new string(backwards);
    }
//Time Complexity: O(n) - Linear time complexity, where n is the length of the input string. The Array.Reverse method operates in linear time.
//Space Complexity: O(n) - Linear space complexity, where n is the length of the input string. An array of characters is used to store the reversed string.
    static string ReverseString2(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length < 2)
            return str;

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }


    static void Main()
    {
        string reversed1 = ReverseString("Timbits Hi");
        Console.WriteLine(reversed1);

        string reversed2 = ReverseString("Timbits Hi");
        Console.WriteLine(reversed2);

        string reversed3 = ReverseString("Timbits Hi");
        Console.WriteLine(reversed3);

        string reversed4 = ReverseString2("Timbits Hi");
        Console.WriteLine(reversed1);

        string reversed5 = ReverseString2("Timbits Hi");
        Console.WriteLine(reversed2);

        string reversed6 = ReverseString2("Timbits Hi");
        Console.WriteLine(reversed3);
    }
}
