using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Services
    {
        /**Primary Key**/
        [Key, Column(Order = 0)]
        public string ServiceID { get; set; }
        [Key, Column(Order = 1)]
        public int TaskID { get; set; }

        /**Other Attributes**/
        public string description { get; set; }

        /**Foreign Keys**/
        public virtual ServiceCatalog Catalog { get; set; }
        public virtual ProjectTask Task { get; set; }
    }
}