using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    

    public Journal()
    {

    }

    public void AddEntry(Entry newEntry)
    {

        _entries.Add(newEntry);
        
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                List<String> myData = entry.getData();
                outputFile.WriteLine($"{myData[0]},{myData[1]},{myData[2]}");
            }
        }
        Console.WriteLine("The Journal has successfully been saved!");
    }

    public void LoadFromFile(string filename)
    {
        try
                {
                    
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    _entries.Clear();
                    foreach (String line in lines)
                    {
                        Entry newEntry = new Entry();
                        string[] parts = line.Split(",");
                        newEntry._date = parts[0];
                        newEntry._promptText = parts[1];
                        newEntry._entryText = parts[2];
                        _entries.Add(newEntry);
                    }
                    Console.WriteLine("Journal loaded successfully!");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("\nThe requested file does not exist\n");
                }
    }
}