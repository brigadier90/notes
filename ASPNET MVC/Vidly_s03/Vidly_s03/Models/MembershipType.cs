using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_s03.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }//because we only have a few types
        [Required]
        [StringLength(255)]

        public String Name { get; set; }
        public short SignUpFee { get; set; } //because not more than 100 dollars?
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        //in order to avvoid magic numbers:
        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;

    }
}