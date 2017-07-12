using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class CityOrTown
    {
        /**Primary Key***/
        [Key]
        public int CityOrTownID { get; set; }

        /**Other Attributes**/
        public string City { get; set; }


    }
}