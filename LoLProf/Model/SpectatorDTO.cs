using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLProf.Model
{
    public class SpectatorDTO
    {
        public long gameId { get; set; }
        public string gameType { get; set; }
        public List<Participants> Participants { get; set; }
    }
    public class Participants
    {
        public long TeamId { get; set; }
        public long ChampionId { get; set; }
        public string SummonerName { get; set; }
        public string SummonerId { get; set; }
    }
}