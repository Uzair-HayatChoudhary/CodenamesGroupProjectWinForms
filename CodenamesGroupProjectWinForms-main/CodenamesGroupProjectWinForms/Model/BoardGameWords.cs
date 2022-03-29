using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodenamesGroupProjectWinForms.Model
{
    public class BoardGameWords
    {
        private const int numberCards = 25;


        public BoardGameWords()
        {
            boardWords = new List<string>();

            var file = new StreamReader("wordList.txt");
        }


        private List<string> allWords;
        private List<string> boardWords;

        public List<string> GetBoardWords
        {
            get => boardWords;
        }

        public List<string> GetAllWords
        {
            get => allWords;
        }

        public void InitializeWordList(string filePath)
        {
            try
            {
                using (var file = new StreamReader(filePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        System.Console.WriteLine(line);
                    }
                }
                allWords = System.IO.File.ReadLines(filePath).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void GenerateBoardGameWords(string filePath)
        {
            InitializeWordList(filePath);
            var random = new Random();
            string newWord;
            bool equalList = false;
            if (allWords != null)
            {
                for (int i = 0; i < numberCards; i++)
                {

                    newWord = allWords[random.Next(allWords.Count)];
                    while (boardWords.Contains(newWord) == true)
                    {
                        if (boardWords.Count < allWords.Count)
                        {
                            newWord = allWords[random.Next(allWords.Count)];
                        }
                        else
                        {
                            equalList = true;
                            break;
                        }

                    }
                    if (equalList == false)
                    {
                        boardWords.Add(newWord);
                    }

                }
            }
        }

        public void RemoveWord(string button_text)
        {
            foreach (string word in boardWords)
            {  
                if (word == button_text)
                {
                    boardWords.Remove(word);
                    break;
                }
            }
        }
    }
}
