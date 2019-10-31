using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace SolidabisChallenge.Api
{
    class SentenceApiClient
    {
        private readonly HttpClient httpClient;

        public SentenceApiClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://koodihaaste-api.solidabis.com/");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
                "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJidWxsc2hpdCI6ImJ1bGxzaGl0IiwiaWF0IjoxNTcyMTk1NzU5fQ.UIlv7j9VzWzInPp12lXvgC-zEh8z4FSUsr2Jkn_AjX4");
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<string>> GetSentences()
        {
            using HttpResponseMessage response = await httpClient.GetAsync("bullshit");
            response.EnsureSuccessStatusCode();
            Stream responseContent = await response.Content.ReadAsStreamAsync();
            Sentences sentences = await JsonSerializer.DeserializeAsync<Sentences>(responseContent,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return sentences.Bullshits.Select(bs => bs.Message);
        }
    }
}
