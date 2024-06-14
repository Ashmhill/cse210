using System;

namespace MindfulnessProgram
{
    class BreathingActivity : Activity
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.Write("Enter duration in seconds: ");
            int duration = int.Parse(Console.ReadLine());
            int elapsed = 0;

            while (elapsed < duration)
            {
                Console.WriteLine("Breathe in...");
                PauseWithCountdown(3);
                elapsed += 3;

                Console.WriteLine("Breathe out...");
                PauseWithCountdown(3);
                elapsed += 3;
            }

            End("Breathing", duration);
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
