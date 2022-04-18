using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamesGroupProjectWinForms.Model
{
    public class Clue
    {
        private string hint;
        private int potentialCardNumber;

        public Clue(string hint, int potentialCardNumber)
        {
            this.hint = hint;
            this.potentialCardNumber = potentialCardNumber;
        }

        public string Hint
        {
            get { return hint; }
            set { hint = value; }
        }
        public int PotentialCardNumber 
        {
            get { return potentialCardNumber; }
            set { potentialCardNumber = value; }
        }

        public static string checkValidity(string guess, int guessAmount)
        {
            string returnMessage = "";
            
            if (string.IsNullOrEmpty(guess.ToLower()) || guessAmount < 0)
            {
                returnMessage += "Clue or guess amount cannot be empty";
            }

            return returnMessage;
        }
    }
}
