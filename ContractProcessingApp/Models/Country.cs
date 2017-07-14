using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Country
    {
        /**Primary Key***/
        [Key]
        public int CountryID { get; set; }

        /**Other Attributes**/
        public string CountryName { get; set;}

        /**Foreign key**/
        public virtual ICollection<Region> Regions { get; set; }

    }
}