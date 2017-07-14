using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string RegionName { get; set; }

        /**Foreign key**/
        [ForeignKey("Country")]
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<CityOrTown> CityOrTowns { get; set; }
    }
}