using System.Collections.Generic;
using System.Linq;

namespace SolidabisChallenge
{
    internal class SentenceFinder
    {
        private readonly IEnumerable<ISentenceAnalyzer> _analyzers;

        public SentenceFinder(IEnumerable<ISentenceAnalyzer> analyzers)
        {
            _analyzers = analyzers;
        }

        public SentenceSplit FindFinnishSentences(IEnumerable<string> sentences)
        {
            List<string> undecidedSentences = sentences.ToList();
            var nonsense = new List<string>();
            FindNonsenseFromOriginalSentences(nonsense, undecidedSentences);
            FindNonsenseFromDecipheredSentences(nonsense, undecidedSentences);
            return new SentenceSplit(nonsense, undecidedSentences);
        }

        private void FindNonsenseFromDecipheredSentences(List<string> nonsense, List<string> undecidedSentences)
        {
            IReadOnlyCollection<ISentenceAnalyzer> analyzers = _analyzers.Where(a => !a.RunOnlyOnOriginalSentence).ToList();
            if (!analyzers.Any())
            {
                return;
            }

            List<Sentence> finnishSentences = new List<Sentence>();
            foreach (Sentence undecidedSentence in undecidedSentences.Select(s => new Sentence(s)))
            {
                do
                {
                    if (analyzers.All(a => a.CanBeFinnish(undecidedSentence)))
                    {
                        finnishSentences.Add(undecidedSentence);
                        break;
                    }
                } while (undecidedSentence.TryCreatingNextDecipheredSentence());
            }

            IReadOnlyCollection<string> cipheredFinnishSentences =
                finnishSentences.Select(s => s.OriginalSentence).ToList();
            nonsense.AddRange(undecidedSentences.Where(s => !cipheredFinnishSentences.Contains(s)));
            undecidedSentences.Clear();
            undecidedSentences.AddRange(finnishSentences.Select(s => s.DecipheredSentence));
        }

        private void FindNonsenseFromOriginalSentences(List<string> nonsense, List<string> undecidedSentences)
        {
            foreach (ISentenceAnalyzer analyzer in _analyzers.Where(a => a.RunOnlyOnOriginalSentence))
            {
                IReadOnlyCollection<string> analyzedNonsense =
                    undecidedSentences.Where(s => !analyzer.CanBeFinnish(new Sentence(s))).ToList();
                nonsense.AddRange(analyzedNonsense);
                foreach (string text in analyzedNonsense)
                {
                    undecidedSentences.Remove(text);
                }
            }
        }
    }
}