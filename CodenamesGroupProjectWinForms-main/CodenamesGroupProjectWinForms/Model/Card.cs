using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamesGroupProjectWinForms.Model
{
     public class Card
    {
        public enum CardTypes
        {
            red,
            blue,
            assassin,
            bystander
        }
        private string word;
        private CardTypes cardType;
        private bool isFlipped;

        public string Word
        {
            get { return this.word; }
            set { this.word = value; }
        }

        public bool IsFlipped
        {
            get { return this.isFlipped; }
            set { this.isFlipped = value; }
        }
        public CardTypes CardType
        {
            get { return this.cardType; }
            set { this.cardType = value; }
        }
    }
}
