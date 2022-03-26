using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodenamesGroupProjectWinForms.Model;

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

        public static List<string> GenerateBoard(BoardGameWords boardGameWords)
        {
            boardGameWords.GenerateBoardGameWords("wordList.txt");
            List<string> words_list = boardGameWords.GetBoardWords;
            return words_list;
        }

        public bool pickCard()
        {
            return true;
        }

        public static Clue giveClue(string hint, int guessAmount)
        {
            Clue clue = new Clue(hint, guessAmount);
            return clue;
        }

        public static void changeTurn(Codenames gamestate)
        {
            if (gamestate.teamTurn == 0)
            {
                gamestate.teamTurn = (TeamTurn)1;
            }
            else
            {
                gamestate.teamTurn = (TeamTurn)0;
            }

            if(gamestate.teamRole == 0)
            {
                gamestate.teamRole = (TeamRole)1;
            }
            else
            {
                gamestate.teamRole= (TeamRole)0;
            }
        }
        public void EndTurn()
        {

        }

    }
}
