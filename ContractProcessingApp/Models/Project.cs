using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Project
    {
        /**Primary Key**/
        [Key]
        public int ProjectID { get; set; }

        /**Other Attributes**/
        //public int ContractID { get; set; }
        [ForeignKey("Contract"), Column(Order = 0)]
        public int ContractID { get; set; }
        [ForeignKey("Contract"), Column(Order = 1)]
        public int ServiceRequestID { get; set; }


        /**Foriegn Keys**/
        public virtual Contract Contract { get; set; } 
        public virtual ICollection<ProjectTask> Tasks { get; set; }
    }
}