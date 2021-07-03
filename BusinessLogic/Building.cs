using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewValleyConstructionCalculator.BusinessLogic
{
    class Building
    {
        public readonly string Name;
        public readonly List<Material> RequiredMaterials;
        public readonly bool NeedsNonBuyableMaterials;


        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="RequiredGold"></param>
        /// <param name="RequiredWood"></param>
        /// <param name="RequiredStone"></param>
        /// <param name="CostOfMiscMaterials"></param>
        /// <param name="NeedNonBuyableMaterials"></param>
        public Building(string Name, int RequiredGold, List<Material> RequiredMaterials)
        {
            this.RequiredMaterials = RequiredMaterials;

            foreach (Material mat in RequiredMaterials)
            {
                if (mat.IsBuyable == false)
                    this.NeedsNonBuyableMaterials = false;
            }
        }

        /// <summary>
        /// Prints the name and cost on a console line, seperated by a line of '.' 
        /// Sized to fit the width of the table given.
        /// </summary>
        /// <param name="InventoryToTest">The Inventory object to be tested against.</param>
        /// <param name="TableWidth">The width of the table the line is going into</param>
        ///// <param name="IsFirstYear"></param>
        //private string _getNameAndCostLine(UserInventory InventoryToTest, int TableWidth, bool IsFirstYear)
        //{
        //    const int COSTOFWOOD1STYEAR = 10;
        //    const int COSTOFSTONE1STYEAR = 20;
        //    const int COSTOFWOOD2NDYEAR = 50;
        //    const int COSTOFSTONE2NDYEAR = 100;

        //    foreach (Material material in RequiredMaterials)
        //    {
        //        switch (material.Name) {
        //            case "Wood" :

        //                break;
        //        }
        //    }

        //    // Calculates the remaining wood and stone needed
        //    if (WoodRequired <= InventoryToTest.Wood)
        //        WoodRequired = 0;
        //    else
        //        WoodRequired -= InventoryToTest.Wood;
        //    if (StoneRequired <= InventoryToTest.Stone)
        //        StoneRequired = 0;
        //    else
        //        StoneRequired -= InventoryToTest.Stone;

        //    // Calculates the total remaining cost
        //    if (IsFirstYear)
        //        MaterialCost = (StoneRequired * COSTOFSTONE1STYEAR) + (WoodRequired * COSTOFWOOD1STYEAR) + costOfMiscMaterials;
        //    else
        //        MaterialCost = (StoneRequired * COSTOFSTONE2NDYEAR) + (WoodRequired * COSTOFWOOD2NDYEAR) + costOfMiscMaterials;
 
        //    TotalCost = MaterialCost + costOfMiscMaterials + requiredGold;
        //    TotalCost -= InventoryToTest.Gold;
        //    if (TotalCost < 0)
        //        TotalCost = 0;

        //    // Generates the output string based on the remaining cost
        //    string OutPut;
        //    if (NeedsNonBuyableMaterials)
        //        OutPut = Name.PadRight(TableWidth - TotalCost.ToString().Length - 2, '.') + TotalCost.ToString() + " !";
        //    else
        //        OutPut = Name.PadRight(TableWidth - TotalCost.ToString().Length, '.') + TotalCost.ToString();

        //    return OutPut;
        //}
        /// <summary>
        /// Prints out a cost table based on the year and inventory given
        /// </summary>
        /// <param name="TableWidth"></param>
        /// <param name="BuildingList"></param>
        /// <param name="InventoryToTestAgainst"></param>
        /// <param name="IsFirstYear"></param>
        public static string GetCostTableAsString(List<Building> BuildingList, UserInventory InventoryToTestAgainst, int TableWidth, bool IsFirstYear)
        {
            string CostTable = "";
            for (int i = 0; i < BuildingList.Count; i++)
            {
                //CostTable += BuildingList[i]._getNameAndCostLine(InventoryToTestAgainst, TableWidth, IsFirstYear);
                CostTable += "\r\n";
            }
            return CostTable;
        }
    }
}