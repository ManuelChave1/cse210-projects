class Journal
{
    List<Entry> _entry = new List<Entry>();

    Entry entry = new Entry();
    
  

    void AddEntry(Entry newEntry)
    {
       
        
     _entry.Add(newEntry);
    }

     public void DisplayAll()
    {
        
        // entry.display();
    }
    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {
        
    }
}