using System;
using System.Collections.Generic;
using System.Text;

namespace LoLzada.Profile
{
    class Profile
    {
        public Profile()
        {

        }

        public Profile(string summonerName, string icon, long level, string tier, string rank, string emblem, int wins, int losses, string champion, long champRating)
        {
            SummonerName = summonerName ?? throw new ArgumentNullException(nameof(summonerName));
            Icon = icon ?? throw new ArgumentNullException(nameof(icon));
            Level = level;
            Tier = tier ?? throw new ArgumentNullException(nameof(tier));
            Rank = rank ?? throw new ArgumentNullException(nameof(rank));
            Emblem = "Assets/emblems/Emblem_" + tier + ".png";
            Wins = wins;
            Losses = losses;
            Champion = champion ?? throw new ArgumentNullException(nameof(champion));
            ChampRating = champRating;
        }

        public float WinRate(int win, int lose)
        {
            return win / (win + lose) * 100;
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
        public long WinRating { get; private set; }
    }
}
