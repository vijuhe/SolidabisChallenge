using System.Linq;

namespace SolidabisChallenge
{
    class IllegalCharactersAnalyzer : ISentenceAnalyzer
    {
        public bool CanBeFinnish(Sentence sentence)
        {
            string[] illegalCharacters = { "x", "å" };
            return !illegalCharacters.Any(c => sentence.DecipheredSentence.ToLower().Contains(c));
        }

        public bool RunOnlyOnOriginalSentence => false;
    }
}
