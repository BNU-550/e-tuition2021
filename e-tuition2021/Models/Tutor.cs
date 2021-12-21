using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_tuition2021.Models
{
    /// <summary>
    /// Removed MobilePhoneNumber as it is duplicated!
    /// </summary>
    public class Tutor : Person
    {
        [DataType(DataType.Date), Required]
        public DateTime DbsCheck { get; set; }

        [StringLength(30), Required]
        public string Degree { get; set; }

        public bool PGCE { get; set; }

        [StringLength(100)]
        public string ImageURL { get; set; }

        [StringLength(500), DataType(DataType.MultilineText)]
        public string Bio { get; set; }

        [DataType(DataType.Currency), Required, DisplayName("Cost per hour"), Range(15, 20)]
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        public virtual ICollection<TimeSlot> Lessons { get; set; }
    }
}
