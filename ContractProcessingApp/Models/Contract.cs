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
        public int Id { get; set; }

        /**Other Attributes**/


        /**Foriegn Keys**/
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Project> Projects { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
    }
}