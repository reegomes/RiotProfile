using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLProf.Model
{
    public class MatchDTO
    {

        // Essa classe vai servir para ver todas as partidas da conta, ela precisa de um encryptedAccountId, por exemplo o meu nu9_PpTf9U-DX_p-GvbAGIC5PkRoPLM555TcO_g4XJw
        // A ideia aqui é justamente pegar todas as partidas de uma conta no ano e poder pegar porcentagens
        // Existe os parâmetros champion, queue, season, endTime, beginTime, endIndex, beginIndex
        // Request da conta toda https://br1.api.riotgames.com/lol/match/v4/matchlists/by-account/nu9_PpTf9U-DX_p-GvbAGIC5PkRoPLM555TcO_g4XJw?api_key=RGAPI-5a450d00-bf5b-4f62-becc-6bfcfb061217
        // Request da conta para um champion único https://br1.api.riotgames.com/lol/match/v4/matchlists/by-account/nu9_PpTf9U-DX_p-GvbAGIC5PkRoPLM555TcO_g4XJw?champion=412&api_key=RGAPI-5a450d00-bf5b-4f62-becc-6bfcfb061217
        // Os ids estão em Assets/champion.json, 412 do exemplo acima é o Thresh

        public string encryptedAccountId { get; set; }
        public int champion { get; set; }
        public int queue { get; set; }
        public int season { get; set; }
        public long endTime { get; set; }
        public long beginTime { get; set; }
        public int endIndex { get; set; }
        public int beginIndex { get; set; }
    }
}
