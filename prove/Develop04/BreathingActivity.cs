using System;

    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            SetName("Breathing Activity");
            SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        }

        public void PromptBreathing()
        {
            DateTime futureTime = GetFutureTime(GetDuration());
            DateTime currentTime = GetCurrentTime();
        
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(2);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(3);

            while (currentTime <= futureTime)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Breathe in...");
                ShowCountDown(4);
                Console.WriteLine();
                Console.Write("Now breathe out...");
                ShowCountDown(6);
                currentTime = DateTime.Now;
            }
        }

    }
