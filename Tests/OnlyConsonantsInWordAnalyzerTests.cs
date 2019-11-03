using NUnit.Framework;
using SolidabisChallenge;

namespace Tests
{
    class OnlyConsonantsInWordAnalyzerTests
    {
        private OnlyConsonantsInWordAnalyzer _sut = new OnlyConsonantsInWordAnalyzer();

        [Test]
        public void FinnishCannotHaveWordsWithOnlyConsonants()
        {
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("Minä olen Pekka.")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("Minä jk Pekka.")));
        }
    }
}
