using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("User")]
        public string EmployeeID { get; set; }
        [ForeignKey("ServiceRequest")]
        public int ServiceRequestID { get; set; }
        public virtual ApplicationUser User { get; set; } //Employee - Who created?
        public virtual ServiceRequest ServiceRequest { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
   
    }
}