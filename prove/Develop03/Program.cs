using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    static List<Scripture> scriptures;

    static void Main(string[] args)
    {
        LoadScripturesFromFile("scriptures.txt");
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            var input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            scripture.HideRandomWords(3);
            if (scripture.ToString().IndexOf("_____") == -1)
            {
                Console.Clear();
                Console.WriteLine(scripture);
                break;
            }
        }

        Console.WriteLine("All words are hidden. Program ended.");
    }

    static void LoadScripturesFromFile(string fileName)
    {
        scriptures = new List<Scripture>();
        var lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            var referenceParts = parts[0].Split(' ');
            var book = referenceParts[0];
            var chapterVerseParts = referenceParts[1].Split(':');
            var chapter = int.Parse(chapterVerseParts[0]);
            var verses = chapterVerseParts[1].Split('-');
            var startVerse = int.Parse(verses[0]);
            int endVerse = startVerse;
            if (verses.Length > 1)
            {
                endVerse = int.Parse(verses[1]);
            }
            var reference = new Reference(book, chapter, startVerse, endVerse);
            var text = parts[1];
            scriptures.Add(new Scripture(reference, text));
        }
    }
}
