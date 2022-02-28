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

            Card[] roleTypes = new Card[25];
            Random rnd =  rnd = new Random();
            int tempNumber;
            int counterRed = 0;
            int counterBlue = 0;
            int counterAssassin = 0;
            int counterBystander = 0;
            for (int i=0; i < 25;i++)
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
