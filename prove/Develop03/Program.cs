using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordHider
{
   class Program
   {
       static void Main(string[] args)
       {
           var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        
           while (true)
           {
               Console.Clear();
               Console.WriteLine(scripture.GetFullScripture());
               Console.WriteLine("Press enter to hide a word, or type 'quit' to end.");

               var input = Console.ReadLine();

               if (input == "quit")
               {
                   break;
               }

               scripture.HideRandomWord();
           }
       }
   }

   public class Scripture
   {
       private List<ScriptureWord> words;

       public Scripture(string reference, string text)
       {
           Reference = new ScriptureReference(reference);
           words = text.Split(' ').Select(w => new ScriptureWord(w)).ToList();
       }

       public ScriptureReference Reference { get; }

       public string GetFullScripture()
       {
           return $"{Reference}: {string.Join(" ", words.Select(w => w.IsHidden ? "_" : w.Text))}";
       }

       public void HideRandomWord()
       {
           var random = new Random();
           var index = random.Next(words.Count);

           if (!words[index].IsHidden)
           {
               words[index].IsHidden = true;
           }
       }
   }

   public class ScriptureReference
   {
     public ScriptureReference(string reference)
{
    // Handle the case of a single verse and a verse range.
    // For simplicity, this implementation assumes a single verse reference.
    var parts = reference.Split(' '); // Change the delimiter to a space
    Book = parts[0];
    Chapter = int.Parse(parts[1].Split(':')[0]); // Adjust the index to access the chapter number
    Verse = int.Parse(parts[1].Split(':')[1]); // Adjust the index to access the verse number
}

       public string Book { get; }
       public int Chapter { get; }
       public int Verse { get; }

       public override string ToString()
       {
           return $"{Book} {Chapter}:{Verse}";
       }
   }

   public class ScriptureWord
   {
       public ScriptureWord(string text)
       {
           Text = text;
       }

       public string Text { get; }
       public bool IsHidden { get; set; }
   }
}