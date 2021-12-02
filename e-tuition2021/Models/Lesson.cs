using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    /// <summary>
    /// This lesson will be deliverd in a particular time slot
    /// by a tutor with a student payed for by a parent.
    /// </summary>
    public class Lesson
    {
        public int LessonId { get; set; }

        public int TimeSlotId { get; set; }

        [Required, DisplayName("Parent")]
        public int PersonId { get; set; }

        [Required, DisplayName("Student")]
        public int StudentId { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public int NoRepeat { get; set; }

        [Range(1, 4)]
        public int KeyStage { get; set; }

        public bool FaceToFace { get; set; }

        public bool Online { get; set; }

        //navigation property

        public virtual TimeSlot TimeSlot { get; set; }

        public virtual Student Student { get; set; }
    }
}
