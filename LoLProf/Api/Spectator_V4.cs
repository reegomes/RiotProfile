using LoLProf.Model;
using Newtonsoft.Json;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLProf.Api
{
    public class Spectator_V4 : Api
    {
        public Spectator_V4(string region) : base(region)
        {

        }
        // Exemplo de Get para uma partida https://br1.api.riotgames.com/lol/spectator/v4/active-games/by-summoner/tvYdUz9IIMXqUPQbVvGIS0KOfyBD-PubOe_KByK4K9Xn?api_key=RGAPI-5a450d00-bf5b-4f62-becc-6bfcfb061217
        public SpectatorDTO GetSpectator(string encryptedSummonerId)
        {
            string path = "lol/spectator/v4/active-games/by-summoner/" + encryptedSummonerId;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SpectatorDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
