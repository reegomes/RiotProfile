using LoLProf.Model;
using LoLProf.Utils;
using LoLProf.View.ViewModel;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LoLProf.Api;

namespace LoLProf.Controller
{
    class ControllerTFT
    {
        public object GetContext()
        {
            var summoner = Constants.Summoner;
            var position = GetPosition(summoner);

            return new ViewModelTFT(summoner.Name, summoner.ProfileIconId, summoner.SummonerLevel, position.Tier, position.Rank, position.Wins, position.Losses);
        }

        // Pego as informações do ranking e fila
        private TFTLeagueDTO GetPosition(SummonerDTO summoner)
        {
            LeagueTFT1 league = new LeagueTFT1(Constants.Region);

            var position = league.GetPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_TFT")).FirstOrDefault();
            //var position = league.GetPositions(summoner.Id);

            return position ?? new TFTLeagueDTO();
            //return null;
        }
        public void OpenMain()
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}