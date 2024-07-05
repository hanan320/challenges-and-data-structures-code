using System;

public class Program
{
    
    public static void Main()
    {
        string Revesrs = " ";
        Revesrs = ReverseWords("csharp is programming language");
        Console.WriteLine(Revesrs);
        Revesrs = ReverseWords("Reverse the words in this sentence");
        Console.WriteLine(Revesrs);
        Revesrs = ReverseWords("challenges and data structures"); 
        Console.WriteLine(Revesrs);
    }

    public static string ReverseWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        int end = input.Length;
        string result = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] == ' ' || i == 0)
            {
                int start = (i == 0) ? i : i + 1;
                for (int j = start; j < end; j++)
                {
                    result += input[j];
                }
                if (i > 0)
                {
                    result += " ";
                }
                end = i;
            }
        }
        return result;
    }
}
