public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        if (newEntry != null)
        {
            _entries = _entries ?? new List<Entry>();
    
            _entries.Add(newEntry);
        }
        else
        {
            Console.WriteLine("Invalid Entry: Entry cannot be null");
        }
    }

    public void DisplayAll()
    {
             if (_entries != null)
            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        else
        {
            Console.WriteLine("Journal is Empty");
        }
    }

    public void SaveToFile(string file)
    {
        if (_entries != null)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"Date: {entry._date}");
                    writer.WriteLine($"Prompt: {entry._promptText}");
                    writer.WriteLine($"Entry: {entry._entryText}");
                    writer.WriteLine(); 
                }
            }
        }
        else
        {
            Console.WriteLine("No entries to save");
        }
    }

    public void LoadFromFile(string file)
    {
       _entries = new List<Entry>();
    
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            int partIndex = 0;
        
            Entry entry = new Entry();

            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (string.IsNullOrWhiteSpace(entry._date) || !string.IsNullOrWhiteSpace(entry._promptText) || !string.IsNullOrWhiteSpace(entry._entryText))
                    {
                        AddEntry(entry);
                    }
                    entry = new Entry();
                    partIndex = 0;
                }
                else
                {
                    string value = line.Substring(line.IndexOf(":") + 2);
                    switch (partIndex)
                    {
                        case 0:
                            entry._date = value;
                            break;
                        case 1:
                            entry._promptText = value;
                            break;
                        case 2:
                            entry._entryText = value;
                            break;
                    }
                    partIndex++;
                }
            }
        
            if (!string.IsNullOrWhiteSpace(entry._date) || !string.IsNullOrWhiteSpace(entry._promptText) || !string.IsNullOrWhiteSpace(entry._entryText))
            {
                AddEntry(entry);
            }
        }
    }
}