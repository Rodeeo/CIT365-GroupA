using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace MegaDesk_Yaona
{
    public class DeskQuote
    {
        public string customerName { get; set; }
        public Desk desk;
        public bool is_rush;
        public int rushDays;
        public int totalCost;
        public string date;
        private static List<DeskQuote> quotesList = new List<DeskQuote>();
        // private const string JSON_QUOTES_FILE = File.ReadAllText(@"quotes.json");

        public const int BASE_PRICE = 200;

    
        public DeskQuote(string name, Desk desk, bool rush, int rushDays)
        {
            this.customerName = name;
            this.desk = desk;
            this.is_rush = rush;
            this.rushDays = rushDays;
            this.date = DateTime.Now.ToString("MMMM dd, yyyy");
            this.totalCost = getTotalCost();
        }

        public Desk getDesk() { return desk; }

        public int getTotalCost()
        {
            totalCost = BASE_PRICE + getSurfaceAreaCost() + getDrawerCost() + getSurfaceMaterialCost(desk.material.ToString());
            if (is_rush)
            {
                totalCost += getRushOrderCost(this.rushDays);
            }

            return totalCost;
        }

        public int getSurfaceAreaCost()
        {
            if (this.desk.getSurfaceArea() > 1000)
            {
                return (this.desk.getSurfaceArea()-1000) * 1;
            } else
            {
                return 0;
            }
        }

        public int getDrawerCost()
        {
            return this.desk.drawers * 50;
        }

        public int getSurfaceMaterialCost(string material)
        {
            switch (material)
            {
                case ("Laminate"):
                    return 200;
                case ("Oak"):
                    return 100;
                case ("Pine"):
                    return 50;
                case ("Rosewood"):
                    return 300;
                case ("Veneer"):
                    return 125;
            }
            return 0;
        }

        public int getRushOrderCost(int days)
        {
            int size = this.desk.getSurfaceArea();
            switch (days)
            {
                case 3:
                    if (size < 1000)
                    {
                        return 60;
                    } else if (size >= 1000 && size <= 2000)
                    {
                        return 70;
                    } else if (size > 2000)
                    {
                        return 80;
                    }
                    break;
                case 5:
                    if (size < 1000)
                    {
                        return 40;
                    }
                    else if (size >= 1000 && size <= 2000)
                    {
                        return 50;
                    }
                    else if (size > 2000)
                    {
                        return 60;
                    }
                    break;
                case 7:
                    if (size < 1000)
                    {
                        return 30;
                    }
                    else if (size >= 1000 && size <= 2000)
                    {
                        return 35;
                    }
                    else if (size > 2000)
                    {
                        return 40;
                    }
                    break;
                default:
                    return 0;

            }
            return 0;

        }

        public static void saveQuote(DeskQuote quote)
        {
            // System.Diagnostics.Debug.WriteLine("JSON FILE: " + JSON_QUOTES_FILE);
            StreamReader r = new StreamReader("C:\\Users\\Olea\\source\\repos\\CIT365-GroupA\\MegaDesk-Yaona\\quotes.json");
            string json = r.ReadToEnd();
            System.Diagnostics.Debug.WriteLine(json);
            // Load quotes from quotes.json file
            List<DeskQuote> quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            // Add new quote
            quotes.Add(quote);
            // Serialize the list
            string quotesJson = JsonConvert.SerializeObject(quotes, Formatting.Indented);
            System.Diagnostics.Debug.WriteLine(quotesJson);
            //  Save it to the file
            File.WriteAllText("quotes.json", quotesJson);

        }





    }
}
