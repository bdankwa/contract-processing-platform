using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class ServiceCatalog
    {
        /**Primary Key**/
        [Key]
        public string ServiceID { get; set; }

        /**Other Attributes**/
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

    }
}