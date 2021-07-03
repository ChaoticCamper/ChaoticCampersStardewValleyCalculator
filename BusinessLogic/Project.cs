using System;
using System.Collections.Generic;
using System.Text;

namespace StardewValleyConstructionCalculator.BusinessLogic
{
    class Project
    {
        private List<Building> buildings;
        private List<Item> items;
        private int totalCost;

        public Project()
        {
            buildings = new List<Building>();
            items = new List<Item>();
            totalCost = 0;
        }

        public void AddBuilding(Building BuildingToAdd)
        {
            buildings.Add(BuildingToAdd);
        }

        public void AddItem(Item ItemToAdd)
        {
            items.Add(ItemToAdd);
        }


    }
}
