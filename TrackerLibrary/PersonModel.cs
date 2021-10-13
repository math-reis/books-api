using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of a particular player.
        /// </summary>
        public String FirstName { get; set; }
        /// <summary>
        /// Represents the last name of a particular player.
        /// </summary>
        public String LastName { get; set; }
        /// <summary>
        /// Represents the email adress of a particular player.
        /// </summary>
        public String EmailAdress { get; set; }
        /// <summary>
        /// Represents the cellphone number of a particular player.
        /// </summary>
        public String CellphoneNumber { get; set; }
    }
}
