using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20), Required, DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(20), Required, DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(15), Required, DisplayName("Mobile")]
        public string MobileNumber { get; set; }

        public virtual int AddressId { get; set; }

        //Navigation property
        public virtual Address Address { get; set; }

        public string GetFullName() { return FirstName + " " + LastName; }


    }
}
