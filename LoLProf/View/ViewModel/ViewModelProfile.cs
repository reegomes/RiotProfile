using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLProf.View.ViewModel
{
    public class ViewModelProfile
    {
        public ViewModelProfile(string summonerName, int icon, long level, string tier, string rank, int wins, int losses)
        {
            SummonerName = summonerName ?? throw new ArgumentNullException(nameof(summonerName));
            Icon = "https://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon + ".jpg";
            Level = level;
            Tier = tier ?? throw new ArgumentNullException(nameof(tier));
            Rank = rank ?? throw new ArgumentNullException(nameof(rank));
            Emblem = "/LoLProf;component/Assets/Images/Emblem_" + tier + ".png";
            Wins = wins;
            Losses = losses;

            float calc = wins + losses;
            float calc2 = (wins / calc) * 100;
            WinRate = calc2.ToString("F1");
        }

        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public string Emblem { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public string Champion { get; private set; }
        public long ChampRating { get; private set; }
        public string LeagueId { get; private set; }
        public string WinRate { get; private set; }
    }
}
