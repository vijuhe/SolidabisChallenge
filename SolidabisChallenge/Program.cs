using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using SolidabisChallenge.Api;

namespace SolidabisChallenge
{
    class Programa
    {
        static async Task Main(string[] args)
        {
            IEnumerable<string> sentences = await GetSentences();
            var sentenceFinder = new SentenceFinder(new List<ISentenceAnalyzer>
            {
                new WordLengthAnalyzer()
            });
            SentenceSplit split = sentenceFinder.FindFinnishSentences(sentences);
            await File.WriteAllLinesAsync("bullshit.txt", split.NonSense);
            await File.WriteAllLinesAsync("no bullshit.txt", split.Finnish);
        }

        private static async Task<IEnumerable<string>> GetSentences()
        {
            using var httpClient = new HttpClient();
            var apiClient = new SentenceApiClient(httpClient);
            return await apiClient.GetSentences();
        }
    }
}
