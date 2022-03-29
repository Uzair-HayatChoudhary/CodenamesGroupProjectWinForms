using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodenamesGroupProjectWinForms.Model;

//LINE 296, ONE THING TO DO FOR SURE!!
namespace CodenamesGroupProjectWinForms
{
    public partial class BoardGame : Form
    {
        BoardGameWords boardGameWords = new BoardGameWords();
        List<Button> btn_list;
        List<string> btn_words_list;
        Card[] roleTypes;
        Codenames gameState;
        Player currentPlayer;

        public BoardGame()
        {
            InitializeComponent();
        }

        void pickCard(Object sender, EventArgs e)
        {

        }

        private void BoardGame_Load(object sender, EventArgs e)
        {
            //GAMESTATE variable that tracks whose current team turn it is
            //current player variable tracks which type of players turn it is, spymaster or field agent.
            gameState = new Codenames(1);
            currentPlayer = new Player();
            lblTeamTurn.Text = gameState.TeamTurn == 0 ? "Blue team" : "Red team";
            llbRoleTurn.Text = currentPlayer.Role == 0 ? "Spymaster" : "Field Agents";

            //team class tracks the points for each team, we create them on load so that they can update whenever pick card is activated they can update.
            //One tracker for each teams points is created
            Team blueTeamPoints = new Team();
            Team redTeamPoints = new Team();

            btn_words_list = Codenames.GenerateBoard(boardGameWords);

            btn_list = new List<Button>
            {
                btnCard1,btnCard2,btnCard3,btnCard4,btnCard5,btnCard6,btnCard7,btnCard8,btnCard9,btnCard10,btnCard11,btnCard12,btnCard13,btnCard14,btnCard15,btnCard16,btnCard17,btnCard18,btnCard19,btnCard20,btnCard21,btnCard22,btnCard23,btnCard24,btnCard25
            };

            try
            {
                for (int i = 0; i < btn_list.Count; i++)
                {
                    btn_list[i].Text = btn_words_list.ElementAt(i);
                }
            }
            catch
            {
                MessageBox.Show("There are not enough words in the list");
            }

            roleTypes = new Card[25];
            Random rnd = rnd = new Random();
            int tempNumber;
            int counterRed = 0;
            int counterBlue = 0;
            int counterAssassin = 0;
            int counterBystander = 0;
            for (int i = 0; i < 25; i++)
            {
                do
                {
                    tempNumber = rnd.Next(0, 4);
                } while ((counterRed == 9 && tempNumber == 0) || (counterBlue == 8 && tempNumber == 1) || (counterAssassin == 1 && tempNumber == 2) || (counterBystander == 7 && tempNumber == 3));

                switch (tempNumber)
                {
                    case 0:
                        counterRed++;
                        Card card = new Card(btn_list[i].Text.ToString(), 0);
                        roleTypes[i] = card;
                        break;
                    case 1:
                        counterBlue++;
                        Card card1 = new Card(btn_list[i].Text.ToString(), 1);
                        roleTypes[i] = card1;
                        break;
                    case 2:
                        counterAssassin++;
                        Card card2 = new Card(btn_list[i].Text.ToString(), 2);
                        roleTypes[i] = card2;
                        break;
                    default:
                        counterBystander++;
                        Card card3 = new Card(btn_list[i].Text.ToString(), 3);
                        roleTypes[i] = card3;
                        break;
                }
            }
            boardState(true);
        }

        private void btnSubmitClue_Click(object sender, EventArgs e)
        {
            //Flag to check if the clue passes validations
            bool checker = false;
            string guessNumber;
            guessNumber = txtGuessAmount.Text.Trim();
            int guessAmount = Convert.ToInt32(guessNumber);
            string guess = txtClue.Text.Trim();
            List<string> currentWords = boardGameWords.GetBoardWords;
            string validationMessage = "";

            //Clue validation, if it is empty or invalid

            validationMessage = Clue.checkValidity(guess, guessAmount);

            if (validationMessage != "" )
            {
                checker = true;
                MessageBox.Show(validationMessage, "Invalid Clue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            for (int i = 0; i < currentWords.Count; i++)
            {
                if (guess == currentWords.ElementAt(i))
                {
                    checker = true;
                }
            }

            if (checker)
            {
                MessageBox.Show("Clue cannot be part of the words on the board currently visible, please try again", "Invalid clue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Creating the clue if submitted guess and hint number pass all validations
                txtClue.Text = "";
                txtGuessAmount.Text = "";
                Clue clue = Codenames.giveClue(guess, guessAmount);
                Player.changeRole(currentPlayer);
                boardState(false);
                ChangeTurnMessage();
            }
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            Codenames.EndTurn(gameState, currentPlayer);
            if(currentPlayer.Role == Role.spymaster)
            {
                boardState(true);
            }
            else
            {
                boardState(false);
            }
            ChangeTurnMessage();
        }

        public void boardState(bool isSpymasterTurn)
        {
            //if isSpymasterTurn is true, then show all the colors. if it is false show just plain colors
            //NEED TO IMPLEMENT TO SHOW PICKED CARDS AND REMOVE WORDS WHEN THE CARD HAS BEEN PICKED!!
            //implemented not flipping already picked cards
            if (isSpymasterTurn)
            {
                for (int i = 0; i < 25; i++)
                {
                    switch (roleTypes[i].CardType)
                    {
                        case CardTypes.red:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.Red;
                                btn_list[i].ForeColor = Color.White;
                            }
                            break;
                        case CardTypes.blue:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.Blue;
                                btn_list[i].ForeColor = Color.White;
                            }
                            break;
                        case CardTypes.assassin:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.Gray;
                                btn_list[i].ForeColor = Color.White;
                            }
                            break;
                        case CardTypes.bystander:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.LightGoldenrodYellow;
                                btn_list[i].ForeColor = Color.Black;
                            }
                            break;
                    }
                }
            }
        }

        public void ChangeTurnMessage()
        {
            lblTeamTurn.Text = gameState.TeamTurn == 0 ? "Blue team" : "Red team";
            llbRoleTurn.Text = currentPlayer.Role == 0 ? "Spymaster" : "Field Agents";
            MessageBox.Show("It is now " + (gameState.TeamTurn == 0 ? "Blue team" : "Red team") + " " + (currentPlayer.Role == 0 ? "spymaster" : "field Agent"), "Turn Change", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}


