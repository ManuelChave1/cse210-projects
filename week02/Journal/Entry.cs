using System.IO;
public class Entry
{
   public string _data;
   public string _promptText;
   public string _entryText;

   DateTime Date = DateTime.Now;
   PromptGenerator prompt = new PromptGenerator();
   List<string> _entry = new List<string>();

   //string path = @"C:\Users\Manuel Chave\Documents\doc\";




   public void AddEntry()
   {
      _data = Date.ToString("dd/MM/yy HH:mm");
      PromptGenerator prompt = new PromptGenerator();
      _promptText = prompt.GetRandomPrompt();
      Console.WriteLine(_promptText);
      Console.Write("> ");
      string answer = Console.ReadLine();
      _entryText = answer;

      string  entries = "Date:" + _data + "- Prompt: " + _promptText + "\n" + _entryText;
      _entry.Add(entries);
   }

   public void Display()
   {
      foreach (var UserEntry in _entry)
      {
         Console.WriteLine(UserEntry);
      }

   }

   public void LoadFromAFile(string file)
   {
      if (File.Exists(file))
      {

         string file_entries = File.ReadAllText(file);
         Console.WriteLine(file_entries);
         //using (StreamReader sr = new StreamReader(path + file))
        // {
         //   string lines;
         //   while ((lines = sr.ReadLine()) != null)
         //   {
         //      Console.WriteLine(lines);
        //    }
        // }
      }
      else
      {
         Console.WriteLine($"Sorry, the file {file} not existe");
      }
   }
   public void SaveToAFile(string file)
   {
      string entries = string.Join(Environment.NewLine, _entry);
      File.WriteAllText(file,entries);
      //using (StreamWriter sw = File.AppendText(path + file))
     // {
      // foreach (var item in _entry)
      // {
      //    sw.WriteLine(item);
      // }
     // }
   }

}