using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Bid
    {
        /**Primary Key**/
        /**Primary Key**/
        [Key, Column(Order = 0)]
        public String Id { get; set; }
        [Key, Column(Order = 1)]
        public string ServiceID { get; set; }
        [Key, Column(Order = 2)]
        public int TaskID { get; set; }


        /**Other Attributes**/

        /**Foreign Keys**/
        public virtual ApplicationUser User { get; set; }
        public virtual ServiceOrders Orders { get; set; }

    }
}