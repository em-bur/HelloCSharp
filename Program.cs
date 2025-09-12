using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine($"Hi, {name}! Nice to meet you.");

        Console.WriteLine("What is your favorite hobby?");
        string hobby = Console.ReadLine().ToLower();

        Console.WriteLine($"{hobby} sounds fun! Wait until you hear this!");

        //hobby fun facts
        var funFact = new Dictionary<string, string>()
        {
            { "drawing", "Did you know that the earliest known drawing dates back to 30,000 years ago?" },
            { "music", "Did you know that the first instrument ever made was the Flute?" },
            { "reading", "Did you know that the average American reads 12 books per year?" },
            { "cooking", "Did you know that cooking can help relieve stress?" },
            { "gaming", "Did you know that Minecraft is the most popular game?" },
            { "exercise", "Did you know that exercise improves sleep quality? It's time to get moving!" },
        };

        if (funFact.ContainsKey(hobby))
        {
            Console.WriteLine(funFact[hobby]);

        }
        else
        {
            Console.WriteLine($"Did you know that your name has {name.Length} letters?");
        }
    }

}
