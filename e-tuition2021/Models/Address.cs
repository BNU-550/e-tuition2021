using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    public class Address
    {
        public int Id { get; set; }
        
        [StringLength(20), Required]
        public string HouseNumber { get; set; }

        [StringLength(10), Required]
        public string PostCode { get; set; }
    }
}
