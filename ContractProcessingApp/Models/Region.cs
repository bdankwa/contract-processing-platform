using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Region
    {
        /**Primary Key***/
        [Key]
        public int RegionID { get; set; }

        /**Other Attributes**/
        public string Name { get; set; }

        /**Foreign key**/
        public virtual ICollection<CityOrTown> CityOrTowns { get; set; }
    }
}