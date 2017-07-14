using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Contractor
    {
        /**Primary Key**/
        [Key]
        [ForeignKey("User")]
        public string ContractorID { get; set; }

        /**Other Attributes**/

        /**Foreign Keys**/
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Bid> Bid { get; set; }
    }
}