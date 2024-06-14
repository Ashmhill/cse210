using System;

namespace MindfulnessProgram
{
    class ListingActivity : Activity
    {
        private static readonly string[] Prompts = 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public override void Start()
        {
            base.Start();
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.Write("Enter duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());
            int elapsed = 0;

            Random rand = new Random();
            string prompt = Prompts[rand.Next(Prompts.Length)];
            Console.WriteLine(prompt);
            PauseWithCountdown(5);
            elapsed += 5;

            Console.WriteLine("Start listing items:");

            int itemCount = 0;
            while (elapsed < duration)
            {
                string item = Console.ReadLine();
                itemCount++;
                elapsed += 1; // Assuming it takes 1 second to enter an item
            }

            Console.WriteLine($"You listed {itemCount} items.");
            End("Listing", duration);
        }

        private void PauseWithCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i + " ");
                System.Threading.Thread.Sleep(1000); // Pause for 1 second
            }
            Console.WriteLine();
        }
    }
}
