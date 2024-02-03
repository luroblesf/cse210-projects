using System;

    public class PhysicalActivity : Activity
    {
        public PhysicalActivity()
        {
            SetName("Physical Activity");
            SetDescription("This activity will help you be aware of each posture, the movement you make and the physical sensations that arise during the exercises.");
        }

        public void PromptMovements()
        {
       
            DateTime futureTime = GetFutureTime(GetDuration());
            DateTime currentTime = GetCurrentTime();
        
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Turning the neck and head from left to right...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Deep breaths with arms (out-in, in-out)...");
            ShowCountDown(4);
            Console.WriteLine();

            
            while (currentTime <= futureTime)
            {
                Console.Write("Hip twists...");
                ShowCountDown(4);
                Console.WriteLine();
                Console.Write("Trunk and arm stretches (up, side, down)...");
                ShowCountDown(4);
                Console.WriteLine();
                Console.Write("Return to calm (conscious breathing)...");
                ShowCountDown(4);
                currentTime = DateTime.Now;
            }
        }

    }
