using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class ServiceCatalog
    {
        /**Primary Key**/
        [Key]
        public int ServiceID { get; set; }

        /**Other Attributes**/
        public string Service { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        /**Foreign Key**/
        [ForeignKey("Categories")]
        public int CategoryID { get; set; }
        public virtual ServiceCategory Categories { get; set; }
    }
}