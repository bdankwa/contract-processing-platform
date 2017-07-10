using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Contract
    {
        /**Primary Key**/
        [Key]
        public int ContractID { get; set; }

        /**Other Attributes**/


        /**Foriegn Keys**/
        public virtual ApplicationUser User { get; set; } //Employee - Who created?
        public virtual ServiceRequest ServiceRequest { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
   
    }
}