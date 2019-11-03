using System;
using System.Linq;

namespace SolidabisChallenge
{
    internal class WordLengthAnalyzer : ISentenceAnalyzer
    {
        public bool CanBeFinnish(Sentence sentence)
        {
            return sentence.DecipheredWords.All(w => w.Length > 1);
        }

        public bool RunOnlyOnOriginalSentence => true;
    }
}