using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SolidabisChallenge;

namespace Tests
{
    public class WordLengthAnalyzerTests
    {
        private WordLengthAnalyzer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new WordLengthAnalyzer();
        }

        [Test]
        public void FinnishHasNoOneLetterWords()
        {
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("Dttxp dttvvztyl djvtdlwbltapvat xccbbcyppb xtpwpyzaztbcvapb dltvcbbtdlb wlclybltyl åjtdjwwj ölcsztbbcyppy.")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("Vwqtggp måugnåp owmccp coocvvkmqwnwkuuc i mgumwwfguuc pwwumccokpgp qp ångkuvåpåv rckmqkp lqrc talajfåuoakuguvk.")));
        }
    }
}
