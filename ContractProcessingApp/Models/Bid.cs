using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Bid
    {
        /**Primary Key**/
        [Key, Column(Order = 0)]
        [ForeignKey("Contractor")]
        public string ContractorID { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("ProjectTask")]
        public int TaskID { get; set; }


        /**Other Attributes**/

        /**Foreign Keys**/
        public virtual Contractor Contractor { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }

    }
}