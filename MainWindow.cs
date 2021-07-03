using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StardewValleyConstructionCalculator.BusinessLogic;

namespace StardewValleyConstructionCalculator
{
    public partial class MainWindow : Form
    {
        private Project CurrentProject;
        private BuildingCatalog buildingCatalog;

        public MainWindow()
        {
            InitializeComponent();
            CurrentProject = new Project();
            buildingCatalog = new BuildingCatalog();
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            UserInventory Inventory = new UserInventory(InventoryGoldTextBox, InventoryWoodTextBox, InventoryStoneTextBox);
            //List<Building> BuildingList = BuildingCatalog.AsList();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BuildingsButton_Click(object sender, EventArgs e)
        {
            // Create a switch statement that adds the correct building from the combo box
            // and adds a copy for each building added to the project.
            if (BuildingsComboBox.Text == "Barn lvl 1")
            {
                for (int i = 0; i < BuildingsNumberBox.Value; i++)
                {
                    CurrentProject.AddBuilding(buildingCatalog.Barn1);
                }
            }
                CurrentProject.AddBuilding(buildingCatalog.Barn1);
        }
    }
}
