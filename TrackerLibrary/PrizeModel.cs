using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents a team's place in the torunament.
        /// </summary>
        public Int16 PlaceNumber { get; set; }
        /// <summary>
        /// Represents a team's place name in the tournament.
        /// </summary>
        public String PlaceName { get; set; }
        /// <summary>
        /// Represents the amount awarded in the tournament.
        /// </summary>
        public Decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage amount awarded in the tournament.
        /// </summary>
        public Double PrizePercentage { get; set; }
    }
}
