using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        public Int16 PlaceNumber { get; set; }
        public String PlaceName { get; set; }
        public Decimal PrizeAmount { get; set; }
        public Double PrizePercentage { get; set; }
    }
}
