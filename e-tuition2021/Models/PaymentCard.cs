using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    public class PaymentCard
    {
        public int Id { get; set; }

        [StringLength(16), Required, DisplayName("Card number")]
        public string CardNumber { get; set; }

        [StringLength(8), Required, DisplayName("Sort code")]
        public string SortCode { get; set; }

        [Range(1, 12), Required, DisplayName("Expiry Month")]
        public int ExpiryMonth { get; set; }

        [Range(2021, 2030), Required]
        public int ExpiryYear { get; set; }


    }
}
