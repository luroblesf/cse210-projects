using System;

public class Entry {
public string _date {get;}
public string _prompText {get;}

public string _entryText {get;}

public Entry (string dateInput, string content) 
{
    _date = dateInput;
    _prompText = content;
    
}
    public void DisplayAll()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompText}\n");
        Console.WriteLine($"Entry: {_entryText}");
    }
}