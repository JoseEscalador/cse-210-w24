using System.ComponentModel;

public class Journal {
    public List<Entry> _entries;
    
    public void AddEntry (Entry newEntry) 
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries) {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date}**{entry._promptText}**{entry._entryText}");                
            } 
        }
    }

    public void LoadFromFile (string file)
    {   
        string[] lines = System.IO.File.ReadAllLines(file);
        

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split("**");
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);
        }
        
    }

}