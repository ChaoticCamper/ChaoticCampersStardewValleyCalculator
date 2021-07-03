using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewValleyConstructionCalculator.BusinessLogic
{
    class UserInventory
    {
        public readonly int Gold, Wood, Hardwood, Stone;

        public UserInventory(TextBox GoldTextBox, TextBox WoodTextBox, TextBox StoneTextBox)
        {
            try
            {
                Gold = Convert.ToInt32(GoldTextBox.Text);
                Wood = Convert.ToInt32(WoodTextBox.Text);
                Stone = Convert.ToInt32(StoneTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid characters in \"Gold/Wood/Stone\" fields.\r\nAll values defaulted to 0.");
            }
        }
    }
}
