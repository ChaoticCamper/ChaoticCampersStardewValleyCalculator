using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaoticCampersStardewValleyCalculator
{
    class UserInventory
    {
        // These should be private, but I'm too lazy to change this right now, will change later
        // Or maybe I just change this to a struc and call it a day? PromptForItem() is private...sooooo...
        public int Gold, Wood, Stone;

        public UserInventory()
        {
            Console.WriteLine("How much of each of the following do you have?");
            Gold = PromptForItem("Gold");
            Wood = PromptForItem("Wood");
            Stone = PromptForItem("Stone");            
        }

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
                MessageBox.Show("Invalid characters in \"Gold/Wood/Stone\" fields.\r\nValues defaulted to 0.");
            }
        }

        private static int PromptForItem(string Item)
        {
            string UserInput;
            int Output;

            Item = HelperFunctions.CapitalizeWord(Item);
            Console.Write(Item + ": ");
            UserInput = Console.ReadLine();

            while (!Int32.TryParse(UserInput, out Output) || UserInput.StartsWith("-"))
            {
                Console.WriteLine("Not a valid number, try again.");
                Console.Write(Item + ": ");
                UserInput = Console.ReadLine();
            }
            return Output;
        }
    }
}
