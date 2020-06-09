using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLProf.Model
{
    public class SpectatorDTO
    {
        public string SummonerId { get; set; }
        public int championId { get; set; }
        public Dictionary<int, int> Participants { get; set; }
    }
}
