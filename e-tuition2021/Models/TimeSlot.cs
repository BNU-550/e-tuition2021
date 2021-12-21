using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    public class TimeSlot
    {
        [Key]
        public int Id { get; set; }

        public int TutorId { get; set; }

        public bool Booked { get; set; }

        [Range(1, 7), Required, DisplayName("Day of the week")]
        public int DayOfTheWeek { get; set; }

        [Range(1, 24), Required, DisplayName("Start hour")]
        public int StartHour { get; set; }

        [Range(1, 24), Required, DisplayName("End hour")]
        public int EndHour { get; set; }

        //navigation properties

        public Tutor Tutor { get; set; }

    }
}
