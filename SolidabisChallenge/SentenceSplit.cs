using System.Collections.Generic;

namespace SolidabisChallenge
{
    internal class SentenceSplit
    {
        public SentenceSplit(IEnumerable<string> nonSense, IEnumerable<string> finnish)
        {
            NonSense = nonSense;
            Finnish = finnish;
        }

        public IEnumerable<string> NonSense { get; }
        public IEnumerable<string> Finnish { get; }
    }
}