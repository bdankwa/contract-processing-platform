using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Bid
    {
        /**Primary Key**/
        [Key]
        public virtual ApplicationUser User { get; set; }
        [Key]
        public virtual ServiceCatalog Service { get; set; }

        /**Other Attributes**/

    }
}