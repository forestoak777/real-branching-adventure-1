using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class ProfanityFilter
{
    private static HashSet<string> profanityList = new HashSet<string>();

    // Call this at the start of your program
    public static void LoadProfanityList()
    {
        string filePath = "profanity.txt"; // Make sure this file is in your project root
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Warning: profanity.txt not found! Profanity filter disabled.");
            return;
        }

        foreach (var line in File.ReadAllLines(filePath))
        {
            var word = line.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(word))
                profanityList.Add(word);
        }
    }

    // Normalize input for filtering
    private static string Normalize(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "";

        input = input.ToLower();

        // Replace common number/symbol substitutions
        input = input.Replace("1", "i")
                     .Replace("!", "i")
                     .Replace("3", "e")
                     .Replace("0", "o")
                     .Replace("@", "a")
                     .Replace("$", "s");

        // Remove non-letter characters
        input = Regex.Replace(input, @"[^a-z\s]", "");

        // Collapse repeated letters (fuuuuuck → fuck)
        input = Regex.Replace(input, @"(.)\1+", "$1");

        return input;
    }

    // Returns true if input contains profanity
    public static bool ContainsProfanity(string input)
    {
        if (string.IsNullOrWhiteSpace(input) || profanityList.Count == 0)
            return false;

        input = Normalize(input);
        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (profanityList.Contains(word))
                return true;

            if (profanityList.Any(p => word.Contains(p)))
                return true;
        }

        return false;
    }
}