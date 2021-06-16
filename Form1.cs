using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaoticCampersStardewValleyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoldTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            UserInventory Inventory = new UserInventory(GoldTextBox, WoodTextBox, StoneTextBox);
            List<Building> BuildingList = Building.BuildingListFromCSV("Building List.csv");

            YearOneTable.Text = Building.GetCostTableAsString(BuildingList, Inventory, 34, true);
            YearTwoTable.Text = Building.GetCostTableAsString(BuildingList, Inventory, 34, false);

        }
    }
}
