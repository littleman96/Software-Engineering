using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    class WordFormat
    {
        private const String vowels = "aeiou";

        /// <summary>
        /// this runs all the tests to check and see if the word is formatted correctly. if it passes these tests we can use the word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool IsWordAllowed(string word)
        {
            if(AreCharactersAcceptable(word) == false)
            {
                return false;
            }
            else if(IsNumberOfVowelsCorrect(word) == false)
            {
                return false;
            }
            else if (AreVowelsInAlphabeticalOrder(word) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// this method checks to see if all the characters in a word are all lower case and only letters are allowed
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private static bool AreCharactersAcceptable(string word)
        {
            if (!(Regex.IsMatch(word, @"[a-z]+")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// this checks to see if the number of vowels are correct. One for words with three characters or less and two for wordds with more than three characters
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private static bool IsNumberOfVowelsCorrect(string word)
        {
            int counter = 0;

            if(word.Length > 3)
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if(vowels.Contains(word[i]))
                    {
                        counter++;
                    }
                }
                if(counter>1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (vowels.Contains(word[i]))
                    {
                        counter++;
                    }
                }
                if (counter > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// this checks to see if the vowels are in alphabetical order
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private static bool AreVowelsInAlphabeticalOrder(string word)
        {
            char previousvowel = '\0';

            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    if (!(word[i]=='\0') && (word[i] < previousvowel))
                    {
                        return false;
                    }
                    else
                    {
                        previousvowel = word[i];
                    }
                }
            }

            return true;
        }
    }
}
