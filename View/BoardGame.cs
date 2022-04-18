using CodenamesGroupProjectWinForms.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CodenamesGroupProjectWinForms
{
    public partial class BoardGame : Form
    {
        public static string winningTeam;
        public static int winningTeamPoints;
        BoardGameWords boardGameWords = new BoardGameWords();
        List<Button> btn_list;
        List<string> btn_words_list;
        Card[] roleTypes;
        Codenames gameState;
        Player currentPlayer;
        Clue clue;
        int cardsPicked;
        Team redTeam = new Team(), blueTeam = new Team();

        const int TimeToAct = 5;
        int timeLeft = TimeToAct;

        public BoardGame()
        {
            InitializeComponent();

            lblCountDown.Text = timeLeft.ToString();
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
            
            if(currentPlayer.Role == Role.spymaster)
            {
                //Flag to check if the clue passes validations
                bool checker = false;
                int guessNumber = 0;
                string guess = txtClue.Text.Trim();
                List<string> currentWords = boardGameWords.GetBoardWords;
                string validationMessage = "";

                if (!string.IsNullOrEmpty(txtGuessAmount.Text))
                {
                    guessNumber = Convert.ToInt32(txtGuessAmount.Text.Trim());
                }

                //Clue validation, if it is empty or invalid

                validationMessage = Clue.checkValidity(guess, guessNumber);

                if (validationMessage != "")
                {
                    checker = true;
                    MessageBox.Show(validationMessage, "Invalid Clue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                checker = Codenames.CheckWordList(currentWords, guess);

                if (checker)
                {
                    MessageBox.Show("Clue cannot be part of the words on the board currently visible, please try again", "Invalid clue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Creating the clue if submitted guess and hint number pass all validations
                    txtClue.Text = "";
                    txtGuessAmount.Text = "";
                    clue = Codenames.giveClue(guess, guessNumber + 1);
                    Player.changeRole(currentPlayer);
                    btnSubmitClue.Enabled = false;
                    boardState(false);
                    ChangeTurnMessage();
                    cardsPicked = 1;
                }
            }
        }

        void pickCard(Object sender, EventArgs e)
        {
            Button pickedButton = sender as Button;
            int pickedButtonIndex = 0;
            int counter = 0;

            foreach (Button btn in btn_list)
            {
                if (btn == pickedButton)
                {
                    pickedButtonIndex = counter;
                }
                counter++;
            }
            
            //if red team selects proper card
            if(gameState.TeamTurn == TeamTurn.red && roleTypes[pickedButtonIndex].CardType == CardTypes.red && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
               roleTypes[pickedButtonIndex].IsFlipped = true;
               boardGameWords.RemoveWord(pickedButton.Text);
               redTeam.addPoint();
               lblRedTeamPoints.Text = redTeam.Points.ToString();
               cardsPicked++;
               boardState(false);
               if (redTeam.Points == 9)
               {
                    endGame();
               }
               if (cardsPicked == clue.PotentialCardNumber + 1)
               {
                  btnSubmitClue.Enabled = true;
                  Codenames.changeTeam(gameState);
                  Player.changeRole(currentPlayer);
                  boardState(true);
                  ChangeTurnMessage();
               }
            }
            //If red team select blue team card
            if(gameState.TeamTurn == TeamTurn.red && roleTypes[pickedButtonIndex].CardType == CardTypes.blue && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                roleTypes[pickedButtonIndex].IsFlipped = true;
                boardGameWords.RemoveWord(pickedButton.Text);
                blueTeam.addPoint();
                lblBlueTeamPoints.Text = blueTeam.Points.ToString();
                cardsPicked++;
                boardState(false);
                if (blueTeam.Points == 8)
                {
                    endGame();
                }
                btnSubmitClue.Enabled = true;
                timer.Stop();
                timeLeft = TimeToAct;
                lblCountDown.Text = timeLeft.ToString();
                Codenames.EndTurn(gameState, currentPlayer);
                boardState(true);
                ChangeTurnMessage();
            }
            //If blue team select proper card
            else if(gameState.TeamTurn == TeamTurn.blue && roleTypes[pickedButtonIndex].CardType ==  CardTypes.blue && roleTypes[pickedButtonIndex].IsFlipped == false){
              roleTypes[pickedButtonIndex].IsFlipped = true;
              boardGameWords.RemoveWord(pickedButton.Text);
              blueTeam.addPoint();
              lblBlueTeamPoints.Text = blueTeam.Points.ToString();
              cardsPicked++;
                boardState(false);
                if (blueTeam.Points == 8)
                {
                    endGame();
                }
                if (cardsPicked == clue.PotentialCardNumber + 1)
                {
                    btnSubmitClue.Enabled = true;
                    Codenames.changeTeam(gameState);
                    Player.changeRole(currentPlayer);
                    boardState(true);
                    ChangeTurnMessage();
                }
            }
            //If blue team selects red card
            else if (gameState.TeamTurn == TeamTurn.blue && roleTypes[pickedButtonIndex].CardType == CardTypes.red && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                roleTypes[pickedButtonIndex].IsFlipped = true;
                boardGameWords.RemoveWord(pickedButton.Text);
                redTeam.addPoint();
                lblRedTeamPoints.Text = redTeam.Points.ToString();
                cardsPicked++;
                boardState(false);
                if (redTeam.Points == 9)
                {
                    endGame();
                }
                btnSubmitClue.Enabled = true;
                timer.Stop();
                timeLeft = TimeToAct;
                lblCountDown.Text = timeLeft.ToString();
                Codenames.EndTurn(gameState, currentPlayer);
                boardState(true);
                ChangeTurnMessage();
            }
            //if any team selects the bystander card
            else  if(roleTypes[pickedButtonIndex].CardType == CardTypes.bystander && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
               roleTypes[pickedButtonIndex].IsFlipped = true;
               boardGameWords.RemoveWord(pickedButton.Text);
               btnSubmitClue.Enabled = true;
               Codenames.changeTeam(gameState);
               Player.changeRole(currentPlayer);
               boardState(true);
               ChangeTurnMessage();
            }
            // if any team select the assassing card
            else if(roleTypes[pickedButtonIndex].CardType == CardTypes.assassin && roleTypes[pickedButtonIndex].IsFlipped == false)
            {
                endGame(true);
            }
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            if (!btnSubmitClue.Enabled)
            {
                btnSubmitClue.Enabled = true;
            }
            timer.Stop();
            timeLeft = TimeToAct;
            lblCountDown.Text = timeLeft.ToString();

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

        private void boardState(bool isSpymasterTurn)
        {
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
                            else
                            {
                                btn_list[i].BackColor = Color.Red;
                                btn_list[i].ForeColor = Color.Red;
                            }
                            break;
                        case CardTypes.blue:
                            if (roleTypes[i].IsFlipped == false)
                            {
                                btn_list[i].BackColor = Color.Blue;
                                btn_list[i].ForeColor = Color.White;
                            }
                            else
                            {
                                btn_list[i].BackColor = Color.Blue;
                                btn_list[i].ForeColor = Color.Blue;
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
                            else
                            {
                                btn_list[i].BackColor = Color.LightGoldenrodYellow;
                                btn_list[i].ForeColor = Color.LightGoldenrodYellow;
                            }
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 25; i++)
                {
                    if(roleTypes[i].IsFlipped == false)
                    {
                        btn_list[i].BackColor = Color.LightGoldenrodYellow;
                        btn_list[i].ForeColor = Color.Black;
                    }
                    else
                    {
                        if(roleTypes[i].CardType == CardTypes.red)
                        {
                            btn_list[i].BackColor= Color.Red;
                            btn_list[i].ForeColor= Color.Red;
                        }
                        else if (roleTypes[i].CardType == CardTypes.blue)
                        {
                            btn_list[i].BackColor = Color.Blue;
                            btn_list[i].ForeColor = Color.Blue;
                        }
                        if (roleTypes[i].CardType == CardTypes.bystander)
                        {
                            btn_list[i].BackColor = Color.LightGoldenrodYellow;
                            btn_list[i].ForeColor = Color.LightGoldenrodYellow;
                        }
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

        

        private void btnStartTimer_Click(object sender, EventArgs e)
        {

            if(!timer.Enabled)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to start the timer?", "Start Timer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    timer.Start();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

           
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft -= 1;
                lblCountDown.Text = timeLeft.ToString();

            }

            else
            {
                timeLeft = TimeToAct;
                lblCountDown.Text = timeLeft.ToString();
                timer.Stop();

                Codenames.EndTurn(gameState, currentPlayer);
                if (currentPlayer.Role == Role.spymaster)
                {
                    boardState(true);
                }
                else
                {
                    boardState(false);
                }
                ChangeTurnMessage();;


            }
            
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            endGame();
        }

        public void endGame(bool assassinPicked = false)
        {
            if (assassinPicked)
            {
                if(gameState.TeamTurn == TeamTurn.red)
                {
                    winningTeam = "blue team";
                    winningTeamPoints = blueTeam.Points;
                }
                else
                {
                    winningTeam = "red team";
                    winningTeamPoints = redTeam.Points;
                }
            }
            else
            {
                if (blueTeam.Points == redTeam.Points)
                {
                    winningTeam = "draw";
                }
                else if (blueTeam.Points > redTeam.Points)
                {
                    winningTeam = "blue team";
                    winningTeamPoints = blueTeam.Points;
                }
                else
                {
                    winningTeam = "red team";
                    winningTeamPoints = redTeam.Points;
                }
            }
            this.Hide();
            View.EndGame newForm = new View.EndGame();
            newForm.Show();

        }
    }
}


