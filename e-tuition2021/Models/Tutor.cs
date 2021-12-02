using System;
using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    public class Tutor:Person
    {
        [DataType(DataType.Date), Required]
        public DateTime DbsCheck { get; set; }

        [StringLength(30), Required]
        public string Degree { get; set; }

        [StringLength(15), Required]
        public string MobileNumber { get; set; }

        public bool PGCE { get; set; }

        [StringLength(255)]
        public string ImageURL { get; set; }

        [StringLength(255)]
        public string Bio { get; set; }

        [DataType(DataType.Currency), Required]
        public decimal Cost { get; set; }
    }
}
