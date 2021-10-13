using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents all matchup entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the winner of a particular match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round of a particular match.
        /// </summary>
        public Int16 MatchupRound { get; set; }
    }
}
