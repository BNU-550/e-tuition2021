using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    public class TutorReview
    {
        [StringLength(500), DisplayName("Review"), DataType(DataType.MultilineText)]
        public string ReviewText { get; set; }

        [DisplayName("Rating"), Range(1, 5)]
        public int Rating { get; set; }

        public Tutor Tutor { get; set; }

        public Person Parent { get; set; }
    }
}
