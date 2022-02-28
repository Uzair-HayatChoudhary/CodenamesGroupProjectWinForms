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

namespace CodenamesGroupProjectWinForms
{

    public partial class BoardGame : Form
    {
        BoardGameWords boardGameWords = new BoardGameWords();
        public BoardGame()
        {
            //BoardGameWords boardGameWords = new BoardGameWords();

            boardGameWords.GenerateBoardGameWords("wordList.txt");

            InitializeComponent();

            List<string> btn_words_list = boardGameWords.GetBoardWords;
            List<Button> btn_list = new List<Button>
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

            //determining which cards will be what roles
            //random to randomize which cards will have what roles
            //temp number to test if the card was already chosen, and only add it to a team if it isnt chosen already
            //index to go through all the arrays at the same index and making it easier to read
            //roletypes of type card to make an array and give each card a type, the word associated to it, and if its flipped to false
            //already chosen numbers to associate the words with their respective order in the game board with the number 

           Random random = new Random();
           int tempNumber;
           int index = 1;
           Card[] roleTypes = new Card[25];
           int[] alreadyChosenNumbers = new int[25];
           tempNumber = random.Next(1, 26);
           alreadyChosenNumbers[0] = tempNumber;
            bool isduplicate = false;

            //choosing the assassin card
            Card card = new Card(btn_list[0].Text.ToString(), 2);
            roleTypes[0] = card;

            //chosing cards for red team
                for (int i = 0; i < 9; i++)
                {
                    tempNumber = random.Next(1, 26);
                    for (int j = 0; j < index; j++)
                    {
                        if (alreadyChosenNumbers[j] == tempNumber)
                        {
                            isduplicate = true;
                            break;
                        }
                    }
                    if (isduplicate == false)
                    {
                        alreadyChosenNumbers[index] = tempNumber;
                        Card tempCard = new Card(btn_list[index].Text.ToString(), 0);
                        roleTypes[index] = tempCard;
                        index++;
                    }
                }
                isduplicate = false;
            

            //chosing cards for blue team
            for (int i = 0; i < 8; i++)
            {
                tempNumber = random.Next(1, 26);
                for (int j = 0; j < index; j++)
                {
                    if (alreadyChosenNumbers[j] == tempNumber)
                    {
                        isduplicate = true;
                        break;
                    }
                }
                if(isduplicate == false)
                {
                    alreadyChosenNumbers[index] = tempNumber;
                    Card tempCard = new Card(btn_list[index].Text.ToString(), 1);
                    roleTypes[index] = tempCard;
                    index++;
                }
            }

            //chosing cards for bystanders
            try
            {
                for (int i = index; i < 7; i++)
                {
                    tempNumber = random.Next(1, 26);
                    for (int j = 0; j < index; j++)
                    {
                        if (alreadyChosenNumbers[j] == tempNumber)
                        {
                            isduplicate = true;
                            break;
                        }
                    }
                    if (isduplicate == true)
                    {
                        alreadyChosenNumbers[index] = tempNumber;
                        Card tempCard = new Card(btn_list[index].Text.ToString(), 3);
                        roleTypes[index] = tempCard;
                        index++;
                    }
                    isduplicate = false;
                }
            }
            catch
            {
                Console.WriteLine("1");
            }

            //Showing the card colors for the spymaster
            for (int i = 0; i < 25; i++)
            {
                switch (roleTypes[i].CardType)
                {
                    case CardTypes.red:
                        btn_list[i].BackColor = Color.Red;
                        btn_list[i].ForeColor = Color.White;
                        break;
                    case CardTypes.blue:
                        btn_list[i].BackColor = Color.Blue;
                        btn_list[i].ForeColor = Color.White;
                        break;
                    case CardTypes.assassin:
                        btn_list[i].BackColor = Color.Gray;
                        btn_list[i].ForeColor = Color.White;
                        break;
                    case CardTypes.bystander:
                        btn_list[i].BackColor = Color.LightGoldenrodYellow;
                        btn_list[i].ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCard1_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard1.Text);
        }

        private void btnCard2_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard2.Text);
        }

        private void btnCard3_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard3.Text);
        }

        private void btnCard6_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard6.Text);
        }

        private void btnCard4_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard4.Text);
        }

        private void btnCard5_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard5.Text);
        }

        private void btnCard7_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard7.Text);
        }

        private void btnCard8_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard8.Text);
        }

        private void btnCard9_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard9.Text);
        }

        private void btnCard10_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard10.Text);
        }

        private void btnCard11_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard11.Text);
        }

        private void btnCard12_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard12.Text);
        }

        private void btnCard13_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard13.Text);
        }

        private void btnCard14_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard14.Text);
        }

        private void btnCard15_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard15.Text);
        }

        private void btnCard16_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard16.Text);
        }

        private void btnCard17_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard17.Text);
        }

        private void btnCard18_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard18.Text);
        }

        private void btnCard19_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard19.Text);
        }

        private void btnCard20_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard20.Text);
        }

        private void btnCard21_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard21.Text);
        }

        private void btnCard22_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard22.Text);
        }

        private void btnCard23_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard23.Text);
        }

        private void btnCard24_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard24.Text);
        }

        private void btnCard25_Click(object sender, EventArgs e)
        {
            boardGameWords.RemoveWord(btnCard25.Text);
           // MessageBox.Show(boardGameWords.GetBoardWords[1]);
        }

        private void BoardGame_Load(object sender, EventArgs e)
        {
            Codenames gameState = new Codenames(0, 1);
            lblTeamTurn.Text = gameState.TeamTurn == 0 ? "Blue team" : "Red team";
            llbRoleTurn.Text = gameState.TeamRole == 0 ? "Spymaster" : "Field Agents" ;


            
        }
    }
}
