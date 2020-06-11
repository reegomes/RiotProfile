using LoLProf.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLProf.Api
{
    class LeagueTFT1 : Api
    {
        public LeagueTFT1(string region) : base(region)
        {

        }

        public List<TFTLeagueDTO> GetPositions(string summonerId)
        {
            string path = "tft/league/v1/entries/by-summoner/" + summonerId;
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<TFTLeagueDTO>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
