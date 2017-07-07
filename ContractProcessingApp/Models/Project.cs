using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Project
    {
        /**Primary Key**/
        public int Id { get; set; }

        /**Other Attributes**/


        /**Foriegn Keys**/
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}