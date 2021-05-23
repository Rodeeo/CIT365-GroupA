using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace MegaDesk_Yaona
{
    class FileManager
    {
        private const string JSON_FILE = @"quotes.json";
        public static List<DeskQuote> quotesList = new List<DeskQuote>();

        public FileManager() 
        {
        }

        public void ReadFile()
        {
            if (File.Exists(JSON_FILE))
            {
                try
                {
                    StreamReader r = new StreamReader(JSON_FILE);
                    
                    // Read json string from file
                    string json = r.ReadToEnd();
                    // DEBUG: log json string 
                    System.Diagnostics.Debug.WriteLine(json);

                    if (json.Length > 0)
                    {
                        // if not empty, initialize quotes list
                        quotesList = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                    } else
                    {
                        // if empty, initialize list
                        quotesList = new List<DeskQuote>();
                    }
                    
                }
                catch (Exception e)
                {
                    // If file reading failed, initialize an empty list
                    Console.WriteLine(e);
                }
            } else
            {
                MessageBox.Show(@"There was an error! Cannot find data file!");
            }
        }

        public static void AddQuote(DeskQuote quote)
        {
            quotesList.Add(quote);
        }

        public void SaveToJson()
        {
            if (File.Exists(JSON_FILE))
            {
                try
                {
                    // Serialize the list
                    string quotesJson = JsonConvert.SerializeObject(quotesList, Formatting.Indented);
                    
                    //  Save it to the file
                    File.WriteAllText(JSON_FILE, quotesJson);
                }
                catch
                {
                    MessageBox.Show(@"Failed to save to file");
                }
            } else
            {
                MessageBox.Show(@"ERROR: Can't find JSON file!");
            }
        }
    }
}
