﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace e_tuition2021.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Key Stage"), Range(1, 4)]
        public int KeyStage { get; set; } = 4;

        public int ParentId { get; set; }

        public Nullable<int> TutorId { get; set; }

        //navigation properties

        public Person Parent { get; set; }

        public Person Tutor { get; set; }

    }
}
