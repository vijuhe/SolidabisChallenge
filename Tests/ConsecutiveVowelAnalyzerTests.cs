using NUnit.Framework;
using SolidabisChallenge;

namespace Tests
{
    public class ConsecutiveVowelAnalyzerTests
    {
        private ConsecutiveVowelAnalyzer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new ConsecutiveVowelAnalyzer();
        }

        [Test]
        public void FinnishWordsCannotHaveMoreThanFourConsecutiveVowels()
        {
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("yöaika")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("yuöaika")));
        }
    }
}
