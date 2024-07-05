using System;

public class Program
{
    public static void Main()
    {
        ReverseWords("csharp is programming language"); 
        ReverseWords("Reverse the words in this sentence");
        ReverseWords("challenges and data structures"); 
    }

    public static void ReverseWords(string input)
    {
        int end = input.Length;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] == ' ' || i == 0)
            {
                int start = (i == 0) ? i : i + 1;
                for (int j = start; j < end; j++)
                {
                    Console.Write(input[j]);
                }
                if (i > 0)
                {
                    Console.Write(" ");
                }
                end = i;
            }
        }
        Console.WriteLine();
    }
}
