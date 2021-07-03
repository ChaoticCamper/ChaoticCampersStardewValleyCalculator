using System;
using System.Collections.Generic;
using System.Text;

namespace StardewValleyConstructionCalculator.BusinessLogic
{
    struct MaterialCatalog
    {
        public Material Wood;
        public Material Hardwood;
        public Material Stone;

        public MaterialCatalog(bool foo)
        {
            this.Wood = new Material("Wood", 2, 10, 50, true, 0);
            this.Hardwood = new Material("Hardwood", 15, 0, 0, false, 0);
            this.Stone = new Material("Stone", 2, 20, 100, true, 0);
        }

        public void SetWoodAndStone(int WoodCount, int StoneCount)
        {
            this.Wood.Count = WoodCount;
            this.Stone.Count = StoneCount;
        }
    }
}
