using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly_s03.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //String is nullable and infinite by default
        //can apply data annotation
        [Required] //can do [Required(ErrorMessage = "Please eneter the customer's name")], but in most cases default message is fine
        [StringLength(255)]
        public String Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        //add reference to membership type (should be 1 to 1)
        //this is a navigation property. It allows us to navigate from one type to another
        //in this case from customer to membership type
        //allows us to load object and its related objects from db
        public MembershipType MembershipType { get; set; }

        //sometimes for optimization puposes, we may not want to load the entire property
        ///instead we may just want the foreign key
        //by convention we call it

        //NOTE THIS FIELD IS IMPLICITELY REQUIRED BECAUSE IT IS A BYTE
        //CAN MAKE IT NULLABLE USING ?
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } //entity will recognize this
        [Display(Name = "Date of birth")]
        [Min18YearsIfACustomer]
        public DateTime? Birthdate { get; set; } //? means something is nullable
    }
}