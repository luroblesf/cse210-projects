using System;


    public class Activity
    {
        protected int _duration;
        private string _name = "";
        private string _description = "";

        public int GetDuration()
            {
                return _duration;
            }

            public void SetDuration(int duration)
            {
                _duration = duration;
            }

            public string GetName()
            {
                return _name;
            }

            public void SetName(string name)
            {
                _name = name;
            }
            public string GetDescription()
            {
                return _description;
            }

            public void SetDescription(string description)
            {
                _description = description;
            }

            public void DisplayStartMessage()
            {
                Console.WriteLine($"Welcome to {_name}");
                Console.WriteLine();
                Console.WriteLine(_description);
            }

            public void AskDuration()
            {
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                string durationString = Console.ReadLine();
                SetDuration(Convert.ToInt32(durationString));
            }

            public void RunActivity()
            {
                Console.Clear();
                DisplayStartMessage();
                AskDuration();
                GetReady();
            }

            public void DisplayEndMessage()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Well done!!");
                ShowSpinner(5);
                Console.WriteLine();
                Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
                ShowSpinner(5);
            }

            public void ShowSpinner(int seconds)
            {
                int spinnerPosition = 25;
                int spinWait = 500;

                spinnerPosition = Console.CursorLeft;

                DateTime futureTime = GetFutureTime(5);

                while(DateTime.Now < futureTime)
                {
                    char[] spinChars = new char[]{'|','/','-','\\'};
                    foreach (char spinChar in spinChars)
                    {
                        Console.CursorLeft = spinnerPosition;
                        Console.Write(spinChar);
                        Thread.Sleep(spinWait);
                    }
                }
                
                    Console.CursorLeft = spinnerPosition;
                    Console.Write(" ");
            }

            public void ShowCountDown(int seconds)
            {
                int timerPosition = 25;
                int timerWait = 1000;

                timerPosition = Console.CursorLeft;

                for (int i = 0; i <= seconds; i++)
                {
                    Console.CursorLeft = timerPosition;
                    Console.Write(seconds - i);
                    Thread.Sleep(timerWait);
                }

                Console.CursorLeft = timerPosition;
                Console.Write(" ");
            }

            public void GetReady()
            {
                Console.Clear();
                Console.WriteLine("Get Ready...");
                ShowSpinner(5);
            }

            public DateTime GetFutureTime(int duration)
            {   
                DateTime futureTime = new DateTime();
                futureTime = DateTime.Now.AddSeconds(duration);

                return futureTime;
            }

            public DateTime GetCurrentTime()
            {
                DateTime currentTime = new DateTime();
                currentTime = DateTime.Now;
                return currentTime;
            }

    }


