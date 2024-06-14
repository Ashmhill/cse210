using System;

namespace MindfulnessProgram
{
    class ReflectionActivity : Activity
    {
        private static readonly string[] Prompts = 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static readonly string[] Questions = 
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public override void Start()
        {
            base.Start();
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.Write("Enter duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());
            int elapsed = 0;

            Random rand = new Random();
            string prompt = Prompts[rand.Next(Prompts.Length)];
            Console.WriteLine(prompt);
            PauseWithSpinner(5);
            elapsed += 5;

            while (elapsed < duration)
            {
                string question = Questions[rand.Next(Questions.Length)];
                Console.WriteLine(question);
                PauseWithSpinner(5);
                elapsed += 5;
            }

            End("Reflection", duration);
        }

        private void PauseWithSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(1000); // Pause for 1 second
            }
            Console.WriteLine();
        }
    }
}
