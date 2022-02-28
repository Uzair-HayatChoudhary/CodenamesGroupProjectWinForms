using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamesGroupProjectWinForms.Model
{
    public enum TeamTurn
    {
        blue,
        red
    }
    public enum TeamRole
    {
        spymaster, 
        fieldAgent
    }
    public class Codenames
    {
        private TeamRole teamRole;
        private TeamTurn teamTurn;

        public Codenames(int role, int turn)
        {
            teamRole = (TeamRole)role;
            teamTurn = (TeamTurn)turn;
        }

        public  TeamRole TeamRole
        {
            get { return teamRole; }
            set { teamRole = value; }
        }
        
        public TeamTurn TeamTurn
        {
            get { return teamTurn; }
            set { teamTurn = value; }
        }

        public void generateBoard()
        {
        }

        public bool pickCard()
        {
            return true;
        }

        public bool giveClue(Clue clue)
        {
            return true;
        }

        public void EndTurn()
        {

        }


    }
}
