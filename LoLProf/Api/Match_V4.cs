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
        // Essa classe vai servir para ver todas as partidas da conta, ela precisa de um encryptedAccountId, por exemplo o meu nu9_PpTf9U-DX_p-GvbAGIC5PkRoPLM555TcO_g4XJw
        // A ideia aqui é justamente pegar todas as partidas de uma conta no ano e poder pegar porcentagens
        // Existe os parâmetros champion, queue, season, endTime, beginTime, endIndex, beginIndex
        // Request da conta toda https://br1.api.riotgames.com/lol/match/v4/matchlists/by-account/nu9_PpTf9U-DX_p-GvbAGIC5PkRoPLM555TcO_g4XJw?api_key=RGAPI-5a450d00-bf5b-4f62-becc-6bfcfb061217
        // Request da conta para um champion único https://br1.api.riotgames.com/lol/match/v4/matchlists/by-account/nu9_PpTf9U-DX_p-GvbAGIC5PkRoPLM555TcO_g4XJw?champion=412&api_key=RGAPI-5a450d00-bf5b-4f62-becc-6bfcfb061217
        // Request da conta/Champ + fila https://br1.api.riotgames.com/lol/match/v4/matchlists/by-account/nu9_PpTf9U-DX_p-GvbAGIC5PkRoPLM555TcO_g4XJw?champion=412&queue=450&api_key=RGAPI-5a450d00-bf5b-4f62-becc-6bfcfb061217
        // Os ids estão em Assets/champion.json, 412 do exemplo acima é o Thresh

        public Match_V4(string region) : base(region)
        {

        }

        public MatchDTO GetMatchHistoryByAccount(string encryptedAccountId)
        {
            string path = "match/v4/matchlists/by-account/" + encryptedAccountId;
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

        public MatchDTO GetChampionByAccount(string encryptedAccountId, int queue, int champion)
        {
            string path = "match/v4/matchlists/by-account/" + encryptedAccountId + "?champion=" + champion + "&queue=" + queue;
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
    }
}
