using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }
    }
}