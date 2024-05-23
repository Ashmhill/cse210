using System;
using System.Collections.Generic;
using System.Linq;

// Class representing a scripture reference
public class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int VerseStart { get; }
    public int VerseEnd { get; }

    public ScriptureReference(string reference)
    {
        // Parse the reference string and extract book, chapter, and verse information
        // You can implement this parsing logic based on your requirements
    }

    // Other constructors to handle different reference formats
}

// Class representing a word in the scripture
public class ScriptureWord
{
    public string Word { get; }
    public bool IsHidden { get; set; }

    public ScriptureWord(string word)
    {
        Word = word;
        IsHidden = false;
    }
}

// Class representing a scripture passage
public class Scripture
{
    public ScriptureReference Reference { get; }
    public List<ScriptureWord> Words { get; }

    public Scripture(string reference, string text)
    {
        Reference = new ScriptureReference(reference);
        // Split the text into words
        Words = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
    }

    public void HideRandomWord()
    {
        // Find a random word that is not already hidden and hide it
        var random = new Random();
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Any())
        {
            var randomIndex = random.Next(0, visibleWords.Count);
            visibleWords[randomIndex].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{Reference.Book} {Reference.Chapter}:{Reference.VerseStart}-{Reference.VerseEnd}");
        foreach (var word in Words)
        {
            if (word.IsHidden)
                Console.Write("___ ");
            else
                Console.Write($"{word.Word} ");
        }
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
    }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Instantiate a Scripture object with the reference and text
        var scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        // Loop until all words are hidden
        while (!scripture.AllWordsHidden())
        {
            // Display the scripture passage
            scripture.Display();

            // Get user input
            string input = Console.ReadLine();

            // Check if user wants to quit
            if (input.ToLower() == "quit")
                break;

            // Hide a random word
            scripture.HideRandomWord();
        }

        Console.WriteLine("All words hidden. Press any key to exit.");
        Console.ReadKey();
    }
}