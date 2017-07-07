using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Bid
    {
        /**Primary Key**/
        public virtual ApplicationUser User { get; set; }
        public virtual Service Service { get; set; }

        /**Other Attributes**/

    }
}