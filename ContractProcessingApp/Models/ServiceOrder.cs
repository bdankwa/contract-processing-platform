using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class ServiceOrder
    {
        /**Primary Key**/
        [Key, Column(Order = 0)]
        [ForeignKey("Catalog")]
        public int ServiceID { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("Task")]
        public int TaskID { get; set; }

        /**Other Attributes**/
        public string Description { get; set; }

        /**Foreign Keys**/
        public virtual ServiceCatalog Catalog { get; set; }
        public virtual ProjectTask Task { get; set; }
    }
}