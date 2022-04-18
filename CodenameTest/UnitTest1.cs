using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodenamesGroupProjectWinForms.Model;
using System.Collections.Generic;


namespace CodenameTest
{
    [TestClass]
    public class UnitTest1
    {
        List<string> words = new List<string>()
        {
            "potato",
            "pizza",
            "branch",
            "tree",
            "leaf"
        };

        [TestMethod]
        public void CheckValidity_ValidGuessAmount()
        {
            string validClue = "dsad";
            int validAmount = 2;
            string expected = "";
            string result = Clue.checkValidity(validClue, validAmount);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckValidity_InValidGuessAmount()
        {
            string validClue = "dsad";
            int validAmount = -2;
            string expected = "Clue or guess amount cannot be empty";
            string result = Clue.checkValidity(validClue, validAmount);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void CheckValidity_ValidClue()
        {
            string validClue = "dsad";
            int validAmount = 2;
            string expected = "";
            string result = Clue.checkValidity(validClue, validAmount);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void CheckValidity_InValidClue()
        {
            string validClue = "";
            int validAmount = 2;
            string expected = "Clue or guess amount cannot be empty";
            string result = Clue.checkValidity(validClue, validAmount);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void CheckWordList_InvalidWord()
        {
            string potentialClue = "potato";
            bool expected = true;
            bool result;
            result = Codenames.CheckWordList(words, potentialClue);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckWordList_ValidWord()
        {
            string potentialClue = "Human";
            bool expected = false;
            bool result;
            result = Codenames.CheckWordList(words, potentialClue);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckWordList_AllCapsClue()
        {
            string potentialClue = "POTATO";
            bool expected = true;
            bool result;
            result = Codenames.CheckWordList(words, potentialClue);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangeRole_Valid()
        {
            Player player = new Player();
            player.Role = (Role)1;
            Player expected = new Player();
            expected.Role = (Role)0;

            Player.changeRole(player);

            Assert.AreEqual(expected.Role, player.Role);
        }

        [TestMethod]
        public void ChangeRole_InValid()
        {
            Player player = new Player();
            player.Role = (Role)1;
            Player expected = new Player();
            expected.Role = (Role)0;

            Player.changeRole(player);

            Assert.AreEqual(expected.Role, player.Role);
        }

        [TestMethod]
        public void ChangeTeam_Valid()
        {

            Codenames turn = new Codenames(1);
            Codenames expected = new Codenames(0);

            Codenames.changeTeam(turn);

            Assert.AreEqual(expected.TeamTurn, turn.TeamTurn);
        }
    }
}