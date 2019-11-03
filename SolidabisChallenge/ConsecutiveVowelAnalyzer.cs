using System.Linq;

namespace SolidabisChallenge
{
    class ConsecutiveVowelAnalyzer : ISentenceAnalyzer
    {
        public bool CanBeFinnish(Sentence sentence)
        {
            foreach (string word in sentence.DecipheredWords)
            {
                int consecutiveVowelCount = 0;
                foreach (char character in word)
                {
                    if (Alphabet.Vowels.Contains(character))
                    {
                        consecutiveVowelCount++;
                    }
                    else
                    {
                        consecutiveVowelCount = 0;
                    }

                    if (consecutiveVowelCount > 4)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool RunOnlyOnOriginalSentence => false;
    }
}
