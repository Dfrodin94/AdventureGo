using Labb3_AdventureGo.data;
using Labb3_AdventureGo.items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb3_AdventureGo
{
    class Shop
    {
        public void BuyItems(Player player)
        {
            ItemData shopData = new ItemData();
            List<BaseItem> shopList = shopData.GetItems();

            ShowItems(shopList);

            Console.WriteLine($"\nYou have this amount: {player.Gold} of gold:");
            Console.WriteLine("\nWhich item do you want to buy?");
            Console.Write("> ");

            string input;
            input = Console.ReadLine();

            int inputInt = Int32.Parse(input);
            inputInt -= 1;

            if (ItemExist(inputInt, shopList))
            {
                if (player.Gold >= shopList[inputInt].Cost)
                {
                    Console.WriteLine($"You brought the item {shopList[inputInt].Name}!");

                    player.Gold -= shopList[inputInt].Cost;
                    player.WearItem(shopList[inputInt]);
                }
                else
                {
                    Console.WriteLine("Brush, you dont have enough $$$$");
                }
            }

            Console.WriteLine("[Press enter to continue]");
            Console.ReadLine();
        }

        public void ShowItems(List<BaseItem> items)
        {
            Console.WriteLine("\nHello! These items are available for sale:");

            for (int i = 0; i < items.Count(); i++)
            {
                int indexShop = i + 1;

                Console.Write(indexShop + ". ");
                Console.Write(items[i].ToString());
                Console.WriteLine();
            }
        }

        public bool ItemExist(int indexItem, List<BaseItem> itemList)
        {
            if (indexItem >= itemList.Count())
            {
                Console.WriteLine("This item does not exist, please try again \n");
                return false;
            }
            else if (indexItem < 0)
            {
                Console.WriteLine("This item does not exist, please try again \n");
                return false;
            }
            else
                return true;
        }
    }
}