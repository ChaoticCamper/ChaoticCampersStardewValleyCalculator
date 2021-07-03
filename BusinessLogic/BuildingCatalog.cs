using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StardewValleyConstructionCalculator.BusinessLogic
{
    class BuildingCatalog
    {
        public readonly Building
            Barn1,
            Barn2,
            Barn3,
            Coop1,
            Coop2,
            Coop3,
            Shed1,
            Shed2,
            HouseUpgrade1,
            HouseUpgrade2,
            HouseUpgrade3,
            CabinStone,
            CabinPlank,
            CabinLog,
            Pond,
            Mill,
            Silo,
            SlimeHutch,
            Stable,
            Well,
            ShippingBin;

        public BuildingCatalog()
        {
            // This was originally done from a CSV, but we're switching to hardcoding.
            // The reasoning is that new buildings are added so infrequently that it
            // shouldn't be that big of a deal to update, and it'll help keep the number
            // of files and complexity down. This also eliminates the possibility of
            // users losing the "Building List.csv" file and causing runtime errors. - JB

            // This still looks like shit - also JB

            MaterialCatalog MatCat = new MaterialCatalog(false);

            List<Material> Barn1RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(350, 100);
            Barn1RequiredMaterials.Add(MatCat.Wood);
            Barn1RequiredMaterials.Add(MatCat.Stone);
            this.Barn1 = new Building("Barn", 6000, Barn1RequiredMaterials);

            List<Material> Barn2RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(450, 200);
            Barn2RequiredMaterials.Add(MatCat.Wood);
            Barn2RequiredMaterials.Add(MatCat.Stone);
            this.Barn2 = new Building("Big Barn", 12000, Barn2RequiredMaterials);

            List<Material> Barn3RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(550, 300);
            Barn3RequiredMaterials.Add(MatCat.Wood);
            Barn3RequiredMaterials.Add(MatCat.Stone);
            this.Barn3 = new Building("Deluxe Barn", 25000, Barn3RequiredMaterials);

            List<Material> Coop1RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(300, 100);
            Coop1RequiredMaterials.Add(MatCat.Wood);
            Coop1RequiredMaterials.Add(MatCat.Stone);
            this.Coop1 = new Building("Coop", 4000, Coop1RequiredMaterials);

            List<Material> Coop2RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(400, 150);
            Coop2RequiredMaterials.Add(MatCat.Wood);
            Coop2RequiredMaterials.Add(MatCat.Stone);
            this.Coop2 = new Building("Big Coop", 10000, Coop2RequiredMaterials);

            List<Material> Coop3RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(500, 200);
            Coop3RequiredMaterials.Add(MatCat.Wood);
            Coop3RequiredMaterials.Add(MatCat.Stone);
            this.Coop3 = new Building("Deluxe Coop", 20000, Coop3RequiredMaterials);

            List<Material> Shed1RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(300, 0);
            Shed1RequiredMaterials.Add(MatCat.Wood);
            this.Shed1 = new Building("Shed", 15000, Shed1RequiredMaterials);

            List<Material> Shed2RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(550, 300);
            Shed2RequiredMaterials.Add(MatCat.Wood);
            Shed2RequiredMaterials.Add(MatCat.Stone);
            this.Shed2 = new Building("Big Shed", 20000, Shed2RequiredMaterials);

            List<Material> HouseUpgrade1RequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(450, 0);
            HouseUpgrade1RequiredMaterials.Add(MatCat.Wood);
            this.HouseUpgrade1 = new Building("House Upgrade 1", 10000, HouseUpgrade1RequiredMaterials);

            List<Material> HouseUpgrade2RequiredMaterials = new List<Material>();
            MatCat.Hardwood.Count = 150;
            HouseUpgrade2RequiredMaterials.Add(MatCat.Hardwood);
            this.HouseUpgrade2 = new Building("House Upgrade 2", 50000, HouseUpgrade2RequiredMaterials);

            List<Material> HouseUpgrade3RequiredMaterials = new List<Material>();
            this.HouseUpgrade3 = new Building("House Upgrade 3", 20000, HouseUpgrade3RequiredMaterials);

            List<Material> ShippingBinRequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(150, 0);
            ShippingBinRequiredMaterials.Add(MatCat.Wood);
            this.ShippingBin = new Building("Shipping Bin", 250, ShippingBinRequiredMaterials);

            List<Material> WellRequiredMaterials = new List<Material>();
            MatCat.SetWoodAndStone(0, 75);
            WellRequiredMaterials.Add(MatCat.Stone);
            this.Well = new Building("Well", 1000, WellRequiredMaterials);
        }

        //public static List<Building> AsList()
        //{
        //    List<Building> returnList = new List<Building>();

        //    returnList.Add(Barn1);
        //    returnList.Add(Barn2);
        //    returnList.Add(Barn3);
        //    returnList.Add(Coop1);
        //    returnList.Add(Coop2);
        //    returnList.Add(Coop3);

        //    return returnList;
        //}
    }
}
