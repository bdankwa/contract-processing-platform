using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Ammendment
    {
        /**Primary Key**/
        [Key]
        public int Id { get; set; }

        /**Other Attributes**/


        /**Foriegn Keys**/
        public virtual ApplicationUser User { get; set; } //Employee - Who created?
        public virtual ServiceCatalog Service { get; set; }
    }
}