using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public class InventoryItemModel
    {
        private int dayLastOrdered;
        private int monthLastOrdered;
        private int yearLastOrdered;

        //Properties
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }
        public int Quantity { get; set; }
        public double UnitCost { get; set; }
        public string LastOrdered { get; set; }
        public bool RecentlyOrdered { get; set; }


        //Getters
        public int getDayLastOrdered()
        {
            return this.dayLastOrdered;
        }

        public int getMonthLastOrdered()
        {
            return this.monthLastOrdered;
        }

        public int getYearLastOrdered()
        {
            return this.yearLastOrdered;
        }


        //Setters
        public void setDayLastOrdered(int dayLastOrdered)
        {
            this.dayLastOrdered = dayLastOrdered;
        }

        public void setMonthLastOrdered(int monthLastOrdered)
        {
            this.monthLastOrdered = monthLastOrdered;
        }

        public void setYearLastOrdered(int yearLastOrdered)
        {
            this.yearLastOrdered = yearLastOrdered;
        }

        //Constructors
        public InventoryItemModel()
        {
            ItemName = "";
            ItemType = "";
            Quantity = 0;
            UnitCost = 0.0;
            LastOrdered = "";
            RecentlyOrdered = false;
        }

        public double totalCostOfGoods()
        {
            return Quantity * UnitCost;
        }

        public string LastOrderedFormatter(int day, int month, int year)
        {
            return "";
        }
    }
    
}
