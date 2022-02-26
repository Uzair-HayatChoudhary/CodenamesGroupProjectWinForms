using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodenamesGroupProjectWinForms.Model
{
    public class Codenames
    {
        public enum TeamTurns{
            red,
            blue
        }
        public enum TeamRoles{
            spymaster,
            fieldOperative
        }

        private TeamTurns teamTurn;
        private TeamRoles teamRole;

        //Getters and setters for attributes
        public TeamTurns TeamTurn
        {
            get { return teamTurn; }
            set { teamTurn = value; }
        }

        public TeamRoles TeamRole
        {
            get { return teamRole; }
            set { teamRole = value; }
        }

        public Codenames(string role, string turn)
        {
            
        }

        public static void GenerateBoard()
        {

        }
        public void pickCards()
        {

        }
        public void GiveClue(/*Clue clue*/)
        {

        }
        public void EndTurn()
        {

        }
        public void CountCards()
        {

        }

    }
}
