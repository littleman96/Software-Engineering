using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IfTwoWordsWithALengthGreaterThanTheWrapAreSeperatedOnToTwoDifferentLines()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "abc", "abc" }));
            Page page = pageIn.Compose();
            String actual = page.ToString();
            Assert.AreEqual("abc\nabc\n", actual);
        }

        [TestMethod]
        public void CheckIfWordsGreaterThanThreeHaveTwoVowels1()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "abcd", "abcd", "abc" }));
            Page page = pageIn.Compose();
            string actual = page.ToString();
            Assert.AreEqual("abc\n", actual);
        }

        [TestMethod]
        public void CheckIfWordsGreaterThanThreeHaveTwoVowels2()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "abcde", "abcde" }));
            Page page = pageIn.Compose();
            string actual = page.ToString();
            Assert.AreEqual("abcde\nabcde\n", actual);
        }

        [TestMethod]
        public void CheckWordsGreaterThanTheWrapAreStillEnteredOnTheLine()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "abcdef", "abcdef" }));
            Page page = pageIn.Compose();
            string actual = page.ToString();
            Assert.AreEqual("abcdef\nabcdef\n", actual);
        }

        [TestMethod]
        public void CheckToSeeWhenVowelsAreenteredInTheIncorrectOrder()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "eab", "eab", "abc" }));
            Page page = pageIn.Compose();
            string actual = page.ToString();
            Assert.AreEqual("abc\n", actual);
        }

        [TestMethod]
        public void WhenCaptialLettersAreEntered()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "ABC", "abc" }));
            Page page = pageIn.Compose();
            string actual = page.ToString();
            Assert.AreEqual("abc\n", actual);
        }

        [TestMethod]
        public void WhenOnlyOneLetterInAWordIsCapitalised()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "Abc", "abc" }));
            Page page = pageIn.Compose();
            string actual = page.ToString();
            Assert.AreEqual("abc\n", actual);
        }

        [TestMethod]
        public void WhenAMixtureOfcharactersAreUsed()
        {
            PageInput pageIn = new PageInput(Format.Fill, 5, 0, 0, new List<String>(new String[] { "!£$%^&*()1234567890", "abc" }));
            Page page = pageIn.Compose();
            string actual = page.ToString();
            Assert.AreEqual("abc\n", actual);
        }
    }
}
