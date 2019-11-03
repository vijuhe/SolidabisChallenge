using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidabisChallenge
{
    internal class Sentence
    {
        private string[] _alphabet = 
            { "a", "b", "c", "d", "e", "f", "g", "h",  "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "å", "ä", "ö" };

        public Sentence(string text)
        {
            OriginalSentence = text;
            DecipheredSentence = text;
            SplitDecipheredWords();
        }

        public string OriginalSentence { get; }
        public string DecipheredSentence { get; private set; }
        public IEnumerable<string> DecipheredWords { get; private set; }

        public bool TryCreatingNextDecipheredSentence()
        {
            StringBuilder newSentenceBuilder = new StringBuilder();
            foreach (char c in DecipheredSentence)
            {
                if (c.Equals(' '))
                {
                    newSentenceBuilder.Append(c);
                    continue;
                }
                string character = c.ToString();
                int charIndex = Array.IndexOf(_alphabet, character.ToLower());
                string newChar = _alphabet[(charIndex + 1) % _alphabet.Length];
                newSentenceBuilder.Append(newChar);
            }

            DecipheredSentence = newSentenceBuilder.ToString();
            SplitDecipheredWords();
            return !DecipheredSentence.Equals(OriginalSentence);
        }

        private void SplitDecipheredWords()
        {
            DecipheredWords = DecipheredSentence.ToLower().Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}