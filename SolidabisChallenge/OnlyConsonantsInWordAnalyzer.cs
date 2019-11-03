using System.Linq;

namespace SolidabisChallenge
{
    class OnlyConsonantsInWordAnalyzer : ISentenceAnalyzer
    {
        public bool CanBeFinnish(Sentence sentence)
        {
            return sentence.DecipheredWords.All(word => !word.All(c => Alphabet.Consonants.Contains(c)));
        }

        public bool RunOnlyOnOriginalSentence => false;
    }
}
