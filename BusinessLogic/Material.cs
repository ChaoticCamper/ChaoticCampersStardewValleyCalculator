using System;
using System.Collections.Generic;
using System.Text;

namespace StardewValleyConstructionCalculator.BusinessLogic
{
    struct Material
    {
        public readonly string Name;
        public readonly int SellPrice, Year1BuyPrice, Year2BuyPrice;
        public readonly bool IsBuyable;
        public int Count
        { get; set; }

        public Material(string Name, int SellPrice, int Year1BuyPrice, int NormalBuyPrice, bool IsBuyable, int Count)
        {
            this.Name = Name;
            this.SellPrice = SellPrice;
            this.Year1BuyPrice = Year1BuyPrice;
            this.Year2BuyPrice = NormalBuyPrice;
            this.IsBuyable = IsBuyable;
            this.Count = Count;
        }
    }
}
