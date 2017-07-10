using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Project
    {
        /**Primary Key**/
        [Key]
        public string ProjectID { get; set; }

        /**Other Attributes**/
        //public int ContractID { get; set; }


        /**Foriegn Keys**/
       // public virtual ApplicationUser User { get; set; } //Employee - Who created?
        public virtual ICollection<ProjectTask> Tasks { get; set; }
    }
}