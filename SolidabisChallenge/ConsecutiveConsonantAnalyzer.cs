using System.Collections.Generic;
using System.Linq;

namespace SolidabisChallenge
{
    class ConsecutiveConsonantAnalyzer : ISentenceAnalyzer
    {
        public bool CanBeFinnish(Sentence sentence)
        {
            foreach (string word in sentence.DecipheredWords)
            {
                if (AreAllCharactersConsonants(word) || AreTwoFirstCharactersConsonants(word) || AreTwoLastCharactersConsonants(word))
                {
                    return false;
                }

                int consecutiveDifferentConsonantCount = 0;
                char previousCharacter = char.MinValue;
                foreach (char character in word)
                {
                    if (Alphabet.Consonants.Contains(character))
                    {
                        if (previousCharacter == 'j')
                        {
                            return false;
                        }
                        if (character != previousCharacter)
                        {
                            consecutiveDifferentConsonantCount++;
                        }
                    }
                    else
                    {
                        consecutiveDifferentConsonantCount = 0;
                    }
                    if (consecutiveDifferentConsonantCount > 2)
                    {
                        return false;
                    }
                    previousCharacter = character;
                }
            }

            return true;
        }

        private static bool AreTwoLastCharactersConsonants(string word)
        {
            return AreAllCharactersConsonants(word.Skip(word.Length - 2));
        }

        private static bool AreTwoFirstCharactersConsonants(string word)
        {
            return AreAllCharactersConsonants(word.Take(2));
        }

        private static bool AreAllCharactersConsonants(IEnumerable<char> word)
        {
            return word.All(character => Alphabet.Consonants.Contains(character));
        }

        public bool RunOnlyOnOriginalSentence => false;
    }
}
