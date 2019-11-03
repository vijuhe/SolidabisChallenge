using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidabisChallenge
{
    class SingleWordVowelAnalyzer : ISentenceAnalyzer
    {
        public bool CanBeFinnish(Sentence sentence)
        {
            foreach (string shortWord in sentence.DecipheredWords.Where(w => w.Length < 5))
            {
                if ((shortWord.Contains('ä') || shortWord.Contains('ö') || shortWord.Contains('y')) &&
                    (shortWord.Contains('a') || shortWord.Contains('o') || shortWord.Contains('u')))
                {
                    return false;
                }
            }
            return true;
        }

        public bool RunOnlyOnOriginalSentence => false;
    }
}
