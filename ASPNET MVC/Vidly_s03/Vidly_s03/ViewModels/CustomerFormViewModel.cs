using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_s03.Models;

namespace Vidly_s03.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}