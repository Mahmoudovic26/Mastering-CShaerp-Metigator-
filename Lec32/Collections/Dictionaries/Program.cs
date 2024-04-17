using System;
using System.Collections.Generic;

namespace CADictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            var article =
            "According to Microsoft " +
            "Pot NET is a free cross-platform and open source developer platform " +
            "for building many different types of applications " +
            "With Dot NET you can use multiple languages and libraries " +
            "to build for web and IoT ";

            // Key : d , value "Dot" "Dev"...etc

            Dictionary<char, List<string>> letterDictionary = new Dictionary<char, List<string>>();
            foreach (var word in article.Split())
            {
                foreach (var ch in word)
                {
                    char c = Char.ToLower(ch);
                    if (!letterDictionary.ContainsKey(c))
                    {

                        letterDictionary.Add(c, new List<string> { word.ToLower() });
                    }
                    else
                    {
                        letterDictionary[c].Add(word);
                    }

                }
            }
            /*
            foreach (var entry in letterDictionary)
            {
                System.Console.Write($"'{entry.Key}':");
                foreach (var word in entry.Value)
                {
                    System.Console.WriteLine($"\t\t \"{word}\"");
                }
            }
            */
            var dic = new Dic();
            dic.func();
        }
    }
}