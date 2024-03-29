﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SolidabisChallenge;

namespace Tests
{
    public class SentenceFinderTests
    {
        private SentenceFinder _sut;

        [Test]
        public void FindFinnishWithOneOriginalSentenceAnalyzer()
        {
            _sut = new SentenceFinder(new List<ISentenceAnalyzer> { new WordLengthAnalyzer() });

            SentenceSplit result = _sut.FindFinnishSentences(new List<string>
            {
                "Tämä on suomea.",
                "Tämäkin on suomea.",
                "Jag bor i Åbo."
            });

            Assert.That(result.Finnish.Count(), Is.EqualTo(2));
            Assert.IsTrue(result.Finnish.Contains("Tämä on suomea."));
            Assert.IsTrue(result.Finnish.Contains("Tämäkin on suomea."));
            Assert.IsTrue(result.NonSense.Single().Equals("Jag bor i Åbo."));
        }

        [Test]
        public void FindFinnishWithOneOriginalSentenceAndOneDecipheredSentenceAnalyzer()
        {
            _sut = new SentenceFinder(new List<ISentenceAnalyzer> { new WordLengthAnalyzer(), new ConsecutiveConsonantAnalyzer() });

            SentenceSplit result = _sut.FindFinnishSentences(new List<string>
            {
                "Tämä on suomea.",
                "bc",
                "Jag bor i Åbo."
            });

            Assert.That(result.Finnish.Count(), Is.EqualTo(2));
            Assert.IsTrue(result.Finnish.Contains("Tämä on suomea."));
            Assert.IsTrue(result.Finnish.Contains("de"));
            Assert.IsTrue(result.NonSense.Single().Equals("Jag bor i Åbo."));
        }
    }
}
