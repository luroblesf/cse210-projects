using System;

public class Journal 
{
    public List <Entry> _entries;
    public PromptGenerator promptGenerator;

        public Journal() 
        {
            _entries = new List<Entry>();
       
            promptGenerator = new PromptGenerator();
        }

        public void AddEntry() 
        {
            string prompt = promptGenerator.GenerateRandomPrompt();
            Console.Write("Please enter the date(mm/dd/yyyy): ");
            string dateInput = Console.ReadLine();
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write(">>>> ");
            string content = Console.ReadLine();
        }

        public void DisplayAll() 
        {
            foreach (Entry entry in _entries) 
            {
                entry.DisplayAll();
            }
        }

        public void SaveToFile() 
        {
            Console.Write("Please enter the filename you would like to save to: ");
            string filename = Console.ReadLine();
            try 
            {
                using (StreamWriter writer = new StreamWriter(filename)) 
                {
                    foreach (Entry entry in _entries) 
                    {
                        writer.WriteLine($"{entry._date},{entry._prompText}");
                    }
                }
            Console.WriteLine($"Journal entries saved to {filename}");
            } catch (Exception e){
            Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
            }
        }

        public void LoadFromFile() 
        {
            Console.Write("Please enter the filename you would like to load from: ");
            string filename = Console.ReadLine();

            try 
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream) 
                    {
                        string _date = reader.ReadLine();
                        string _prompText = reader.ReadLine();
                        Entry entry = new Entry(_date, _prompText);
                        _entries.Add(entry);
                }
            } 
        } catch (Exception e) {
          Console.WriteLine($"Error loading entries from filename: {e.Message}");
        }
    }
}