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
        
    public class Codenames
    {
        private TeamTurn teamTurn;

        public Codenames(int turn)
        {
            teamTurn = (TeamTurn)turn;
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

        public static void changeTeam(Codenames gamestate)
        {
            if (gamestate.teamTurn == 0)
            {
                gamestate.teamTurn = (TeamTurn)1;
            }
            else
            {
                gamestate.teamTurn = (TeamTurn)0;
            }
        }

        public static bool CheckWordList(List<string> wordList, string potentialClue)
        {

            for (int i = 0; i < wordList.Count; i++)
            {
                if (potentialClue.ToLower() == wordList.ElementAt(i))
                {
                    return true;
                }
            }
            return false;
        }
        public static void EndTurn(Codenames gameState, Player currentPlayer)
        {
            if (currentPlayer.Role == Role.fieldAgent)
            {
                currentPlayer.Role = Role.spymaster;
                if (gameState.TeamTurn == TeamTurn.blue)
                {
                    gameState.TeamTurn = TeamTurn.red;
                }
                else
                {
                    gameState.TeamTurn = TeamTurn.blue;
                }
            }
            else if(currentPlayer.Role == Role.spymaster)
            {
                if (gameState.TeamTurn == TeamTurn.blue)
                {
                    gameState.TeamTurn = TeamTurn.red;
                }
                else
                {
                    gameState.TeamTurn = TeamTurn.blue;
                }
            }
        }

        public static void endGame(bool assassingPicked, Team winningTeam)
        {
            

        }

    }
}
