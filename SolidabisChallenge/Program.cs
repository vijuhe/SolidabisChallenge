using System;
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
            await File.WriteAllLinesAsync("bullshits.txt", sentences);
        }

        private static async Task<IEnumerable<string>> GetSentences()
        {
            using var httpClient = new HttpClient();
            var apiClient = new SentenceApiClient(httpClient);
            return await apiClient.GetSentences();
        }
    }
}
