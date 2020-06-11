using LoLProf.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLProf.Api
{
    public class Match_V4 : Api
    {
        public Match_V4(string region) : base(region)
        {

        }
        public MatchDTO GetMatchHistoryByAccount(string encryptedAccountId, long championId)
        {
            string path = "lol/match/v4/matchlists/by-account/" + encryptedAccountId + "?champion=" + championId;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchDTO>(content);
            }
            else
            {
                return null;
            }
        }
        // Pego accountID s6Zt0xtquvlC997em7yxfR5WdJ7IR2u5JK6x9OizpeTCP1A e com o método acima + key 98, devolve um endIndex com o total da lista..
        // Salvo uma lista com os matchID entra em lista por lista, procura o participando com o championid 98(exemplo) e confere se o "win": é true soma numa variavel global
        // pega a variavel e faz o winrate do char
    }
}
