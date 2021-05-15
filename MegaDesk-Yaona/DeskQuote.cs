using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Yaona
{
    public class DeskQuote
    {
        public string customerName { get; set; }
        private Desk desk;
        public bool is_rush;
        public int days;
        public int totalCost;

        public const int BASE_PRICE = 200;

    
        public DeskQuote(string name, Desk desk, bool rush, int days)
        {
            this.customerName = name;
            this.desk = desk;
            this.is_rush = rush;
            this.days = days;
        }

        public Desk getDesk() { return desk; }

        public int getTotalCost()
        {
            totalCost = BASE_PRICE + getSurfaceAreaCost() + getDrawerCost() + getSurfaceMaterialCost(desk.material.ToString());
            if (is_rush)
            {
                totalCost += getRushOrderCost(this.days);
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



    }
}
