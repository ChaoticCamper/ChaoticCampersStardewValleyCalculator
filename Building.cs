using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaoticCampersStardewValleyCalculator
{
    class Building
    {
        private string _name;
        private int _requiredGold, _requiredWood, _requiredStone, _costOfMiscMaterials;
        private bool _needsNonBuyableMaterials;
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="RequiredGold"></param>
        /// <param name="RequiredWood"></param>
        /// <param name="RequiredStone"></param>
        /// <param name="CostOfMiscMaterials"></param>
        /// <param name="NeedNonBuyableMaterials"></param>
        public Building(string Name, int RequiredGold, int RequiredWood, int RequiredStone, int CostOfMiscMaterials, bool NeedNonBuyableMaterials)
        {
            _name = Name;
            _requiredGold = RequiredGold;
            _requiredWood = RequiredWood;
            _requiredStone = RequiredStone;
            _costOfMiscMaterials = CostOfMiscMaterials;
            _needsNonBuyableMaterials = NeedNonBuyableMaterials;
        }
        /// <summary>
        /// A private constructor so BuildingListFromCSV() doesn't have to convert strings to ints every. single. time.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="RequiredGold"></param>
        /// <param name="RequiredWood"></param>
        /// <param name="RequiredStone"></param>
        /// <param name="CostOfMiscMaterials"></param>
        /// <param name="NeedNonBuyableMaterials"></param>
        private Building(string Name, string RequiredGold, string RequiredWood, string RequiredStone, string CostOfMiscMaterials, string NeedNonBuyableMaterials)
        {
            _name = Name;
            _requiredGold = Convert.ToInt32(RequiredGold);
            _requiredWood = Convert.ToInt32(RequiredWood);
            _requiredStone = Convert.ToInt32(RequiredStone);
            _costOfMiscMaterials = Convert.ToInt32(CostOfMiscMaterials);
            _needsNonBuyableMaterials = Convert.ToBoolean(NeedNonBuyableMaterials);
        }
        /// <summary>
        /// Prints the name and cost on a console line, seperated by a line of '.' 
        /// Sized to fit the width of the table given.
        /// </summary>
        /// <param name="InventoryToTest">The Inventory object to be tested against.</param>
        /// <param name="TableWidth">The width of the table the line is going into</param>
        /// <param name="IsFirstYear"></param>
        private string _getNameAndCostLine(UserInventory InventoryToTest, int TableWidth, bool IsFirstYear)
        {
            // We might be able to break this down to a couple other methods but I'm too lazy for that right now
            int WoodRequired = _requiredWood;
            int StoneRequired = _requiredStone;
            int MaterialCost;
            int TotalCost;

            const int COSTOFWOOD1STYEAR = 10;
            const int COSTOFSTONE1STYEAR = 20;
            const int COSTOFWOOD2NDYEAR = 50;
            const int COSTOFSTONE2NDYEAR = 100;

            // Calculates the remaining wood and stone needed
            if (WoodRequired <= InventoryToTest.Wood)
                WoodRequired = 0;
            else
                WoodRequired -= InventoryToTest.Wood;
            if (StoneRequired <= InventoryToTest.Stone)
                StoneRequired = 0;
            else
                StoneRequired -= InventoryToTest.Stone;

            // Calculates the total remaining cost
            if (IsFirstYear)
                MaterialCost = (StoneRequired * COSTOFSTONE1STYEAR) + (WoodRequired * COSTOFWOOD1STYEAR) + _costOfMiscMaterials;
            else
                MaterialCost = (StoneRequired * COSTOFSTONE2NDYEAR) + (WoodRequired * COSTOFWOOD2NDYEAR) + _costOfMiscMaterials;
 
            TotalCost = MaterialCost + _costOfMiscMaterials + _requiredGold;
            TotalCost -= InventoryToTest.Gold;
            if (TotalCost < 0)
                TotalCost = 0;

            // Generates the output string based on the remaining cost
            string OutPut;
            if (_needsNonBuyableMaterials)
                OutPut = _name.PadRight(TableWidth - TotalCost.ToString().Length - 2, ' ') + TotalCost.ToString() + " !";
            else
                OutPut = _name.PadRight(TableWidth - TotalCost.ToString().Length, ' ') + TotalCost.ToString();

            return OutPut;
        }
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
                CostTable += BuildingList[i]._getNameAndCostLine(InventoryToTestAgainst, TableWidth, IsFirstYear);
                CostTable += "\r\n";
            }
            return CostTable;
        }
        /// <summary>
        /// For making a list of buildings correlating to the given CSV.
        /// </summary>
        /// <param name="FullFilePath"></param>
        /// <returns>A list of building objects.</returns>
        public static List<Building> BuildingListFromCSV(string FullFilePath)
        {
            List<Building> ReturnList = new List<Building>();
            string[] CSVAsStringArray;
            try
            {
                CSVAsStringArray = System.IO.File.ReadAllLines(FullFilePath);
            }
            catch
            {
                MessageBox.Show("!!! Unable to open \"Building List.csv\"." +
                    "\n!!! Please make sure the \"Building List.csv\" file is located in the same folder as the .exe file of this program." +
                    "\n!!! If you have lost the \"Building List.csv\" file, you can re-downlad it from my git-hub." +
                    "\n!!! https://github.com/ChaoticCamper/StardewValleyConstructionCalculator" +
                    "\n");
                return ReturnList;
            }

            for (int i = 1; i < CSVAsStringArray.Length; i++)
            {
                string[] currentLine = CSVAsStringArray[i].Split(',');
                Building BuildingToAdd = new Building(
                    currentLine[0],     // Name
                    currentLine[1],     // Required Gold
                    currentLine[2],     // Required Wood
                    currentLine[3],     // Required Stone
                    currentLine[4],     // Cost of misc materials
                    currentLine[5]);    // Does this require non-buyable materials
                ReturnList.Add(BuildingToAdd);
            }
            return ReturnList;
        }
    }
}