using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Reference
{
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndVerse.HasValue)
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        else
            return $"{Book} {Chapter}:{StartVerse}";
    }
}

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Text;
    }
}

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = rand.Next(Words.Count);
            if (!Words[index].IsHidden)
            {
                Words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(" ", Words)}";
    }
}

public class Program
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
