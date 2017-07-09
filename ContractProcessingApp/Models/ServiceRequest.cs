using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class ServiceRequest
    {
        /**Primary Key**/
        [Key]
        public int Id { get; set; }

        /**Other Attributes**/
        public virtual ApplicationUser User { get; set; } //Customer
    }
}