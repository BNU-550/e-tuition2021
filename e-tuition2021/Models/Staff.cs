using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_tuition2021.Models
{
    public class Staff : Person
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Currency), Required]
        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [DisplayName("Job Title"), StringLength(30), Required]
        public string JobTitle { get; set; }
    }
}
