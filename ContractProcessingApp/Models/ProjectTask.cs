using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/**This model is descriptive model to describe what tasks will be used to fullfil the project**/

namespace ContractProcessingApp.Models
{
    public class ProjectTask
    {
        /**Primary Key**/
        [Key]
        public int TaskID { get; set; }

        /**Other Attributes**/
        public string Description { get; set; }

        /**Foriegn Keys**/
        //public virtual ApplicationUser User { get; set; } //Employee - Who created?
        //public virtual ICollection<Project> Projects { get; set; }
    }
}