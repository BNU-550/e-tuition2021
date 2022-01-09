using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        [StringLength(20), Required, DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(20), Required, DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(20), Required, DisplayName("Mobile")]
        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public Nullable<int> AddressId { get; set; }

        public Nullable<int> PaymentCardId { get; set; }

        //Navigation property
        public virtual Address Address { get; set; }

        public virtual PaymentCard PaymentCard { get; set; }

        public string GetFullName() { return FirstName + " " + LastName; }
    }
}
