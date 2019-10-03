using System.Collections.Generic;
using System;

namespace FindAndReplace.Models
{
    public class Replace
    {
        public string UserString {get; set;}
        public string UserWord { get; set; }
        public string ReplacementWord { get; set; }
        public string NewPhrase { get; set; }

        public Replace (string userString, string userWord, string replacementWord)
        {
            UserString = userString;
            UserWord = userWord;
            ReplacementWord = replacementWord;
            NewPhrase = "";
        }

        public void FindReplace()
        {
            string[] wordArray = UserString.Split(" ");

            for (int i = 0; i<wordArray.Length; i++)
            {
                if(wordArray[i] == UserWord)
                {
                    wordArray[i] = ReplacementWord;
                }
            }
            NewPhrase = string.Join(" ", wordArray);
        }
    }
}