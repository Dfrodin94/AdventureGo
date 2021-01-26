using Labb3_AdventureGo.items;
using System.Collections.Generic;

namespace Labb3_AdventureGo.data
{
    class ItemData
    {
        public List<BaseItem> GetItems()
        {
            List<BaseItem> listItems = new List<BaseItem>();
            listItems.Add(new Amulet("Eye of god", 10, 100));
            listItems.Add(new Ring("Finger of god", 10, 100));

            return listItems;
        }
    }
}