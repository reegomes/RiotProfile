using LoLProf.Api;
using LoLProf.Model;
using LoLProf.Utils;
using LoLProf.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLProf.Controller
{
    public class ControllerProfile
    {
        public object GetContext()
        {
            var summoner = Constants.Summoner;
            var position = GetPosition(summoner);

            var mhistory = GetMatch(summoner);
            var currentlyMatch = GetChampion(summoner);

            return new ViewModelProfile(summoner.Name, summoner.ProfileIconId, summoner.SummonerLevel, position.Tier, position.Rank, position.Wins, position.Losses, summoner.accountId);
        }
        // Pego as informações do ranking e fila
        private PositionDTO GetPosition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4(Constants.Region);

            var position = league.GetPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return position ?? new PositionDTO();
        }
        // Pego os historicos de partida
        private MatchDTO GetMatch(SummonerDTO summoner)
        {
            Match_V4 matchs = new Match_V4(Constants.Region);
            var mhistory = matchs.GetMatchHistoryByAccount(summoner.accountId, Constants.CurrentyChampionId);
            return mhistory ?? new MatchDTO();
        }
        // Precisa do spectator funcionando
        private SpectatorDTO GetChampion(SummonerDTO summoner)
        {
            try
            {
                Spectator_V4 spectator = new Spectator_V4(Constants.Region);
                var spectatorVar = spectator.GetSpectator(summoner.Id);

                for (int i = 0; i < spectatorVar.Participants.Count; i++)
                {
                    if (summoner.Id == spectatorVar.Participants[i].SummonerId)
                    {
                        Constants.CurrentyChampionId = spectatorVar.Participants[i].ChampionId;
                    }
                }
                return spectatorVar ?? new SpectatorDTO();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void OpenMain()
        {
            MainWindow profile = new MainWindow();
            profile.Show();
        }
    }
}
