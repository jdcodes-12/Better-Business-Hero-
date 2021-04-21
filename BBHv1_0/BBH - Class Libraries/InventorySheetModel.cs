using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public class InventorySheetModel
    {
        //Fields
        List<InventoryItemModel> inventorySheet;

        //Properties
        public string DocId { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime LastUpdated { get; set; }   
        
        //Constructor
        public InventorySheetModel()
        {
            inventorySheet = new List<InventoryItemModel>();
            DocId = "";
        }

        
        //Methods
        public InventoryItemModel serachInventory(InventoryItemModel item)
        {
            return null;
        }

        public void addToInventorySheet(InventoryItemModel item)
        {

        }

        public void removeFromInventorySheet(InventoryItemModel item)
        {
          
        }

        public InventoryItemModel removeAndGetFromInventorySheet(InventoryItemModel item)
        {
            return null;
        }

        public void viewCurrentInventorySheet()
        {

        }

        //Utility Methods
        private void toString()
        {

        }

        private bool inventorySheetExists()
        {
            return false;
        }

        private bool itemIsInList(List<InventoryItemModel> inventorySheet)
        {
            return false;
        }

    }
}
