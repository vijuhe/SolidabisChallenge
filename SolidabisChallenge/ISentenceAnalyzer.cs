namespace SolidabisChallenge
{
    interface ISentenceAnalyzer
    {
        bool CanBeFinnish(Sentence sentence);
        bool RunOnlyOnOriginalSentence { get; }
    }
}
