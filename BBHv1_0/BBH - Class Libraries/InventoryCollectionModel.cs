using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBH___Class_Libraries
{
    public class InventoryCollectionModel
    {
        //Fields
        List<InventorySheetModel> inventoryCollection;

        //Constructor
        public InventoryCollectionModel()
        {
            inventoryCollection = new List<InventorySheetModel>();
        }

        //Methods
        public void addToInventoryCollection(InventorySheetModel inventorySheet)
        {
           
        }

        public void removeFromInventoryCollection(InventorySheetModel inventorySheet)
        {

        }

        public InventorySheetModel removeAndGetFromInventoryCollection(InventorySheetModel inventorySheet)
        {
            return null; //Is this needed?
        }

        //Utility Methods
        private bool exists(List<InventorySheetModel> inventoryCollection)
        {
            return false;
        }

        private bool isEmpty(List<InventorySheetModel> inventoryCollection)
        {
            return false;
        }

        private void toString()
        {
            //Display List
        }

    }
}
