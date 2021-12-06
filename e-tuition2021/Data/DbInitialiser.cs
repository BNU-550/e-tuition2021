using e_tuition2021.Models;
using System;
using System.Linq;

namespace e_tuition2021.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            AddAddresses(context);

            AddPaymentCards(context);

            AddPeople(context);

            AddTutors(context);

            AddStaff(context);

            AddLessons(context);

            AddStudents(context);

            AddTimeSlots(context);
        }

        private static void AddAddresses(ApplicationDbContext context)
        {
            if (context.Addresses.Any())
            {
                return;   // DB has been seeded
            }

            var addresses = new Address[]
            {
                new Address{HouseNumber="5", PostCode="OX5 7JD"},
                new Address{HouseNumber="23", PostCode="OX23 8GH"},
                new Address{HouseNumber="11", PostCode="LO11 14AD"},
                new Address{HouseNumber="66", PostCode="HW66 2GF"},
                new Address{HouseNumber="90", PostCode="PM90 4TF"},
                new Address{HouseNumber="4", PostCode="HW4 9IH"},
                new Address{HouseNumber="8", PostCode="HW8 5MN"},
                new Address{HouseNumber="7", PostCode="LT7 2HG"},
                new Address{HouseNumber="9", PostCode="OX9 6FD"},
                new Address{HouseNumber="10", PostCode="HW10 14DB"}

            };

            context.Addresses.AddRange(addresses);
            //context.SaveChanges();
        }

        private static void AddPaymentCards(ApplicationDbContext context)
        {
            if (context.PaymentCards.Any())
            {
                return;
            }

            var paymentcards = new PaymentCard[]
            {
                new PaymentCard {CardNumber = "6745637892653678", SortCode = "09-87-89", ExpiryMonth=03, ExpiryYear=2025},
                new PaymentCard {CardNumber = "5689024563765434", SortCode = "02-82-56", ExpiryMonth=08, ExpiryYear=2023},
                new PaymentCard {CardNumber = "8723453609467397", SortCode = "06-79-22", ExpiryMonth=09, ExpiryYear=2022},
                new PaymentCard {CardNumber = "0986742543672563", SortCode = "01-37-56", ExpiryMonth=04, ExpiryYear=2025},
                new PaymentCard {CardNumber = "8754673890753425", SortCode = "07-56-12", ExpiryMonth=07, ExpiryYear=2030},
                new PaymentCard {CardNumber = "3452637352738464", SortCode = "08-45-10", ExpiryMonth=11, ExpiryYear=2029},
                new PaymentCard {CardNumber = "6743653848728894", SortCode = "12-90-98", ExpiryMonth=02, ExpiryYear=2022},
                new PaymentCard {CardNumber = "0093737267367283", SortCode = "26-09-77", ExpiryMonth=12, ExpiryYear=2021},
                new PaymentCard {CardNumber = "9928763527189173", SortCode = "24-78-99", ExpiryMonth=10, ExpiryYear=2030},
                new PaymentCard {CardNumber = "5566253513252626", SortCode = "84-22-11", ExpiryMonth=01, ExpiryYear=2027}
            };

            context.PaymentCards.AddRange(paymentcards);
            //context.SaveChanges();
        }

        private static void AddPeople(ApplicationDbContext context)
        {
            if (context.People.Any())
            {
                return;
            }

            var people = new Person[]
            {
                new Person {FirstName="Scaevola", LastName="Sommer", MobileNumber="078945362736789373", AddressId=1, PaymentCardId=3},
                new Person {FirstName="Silvio", LastName="Ture", MobileNumber="08735272536782456", AddressId=2, PaymentCardId=4},
                new Person {FirstName="Judith", LastName="Rickard", MobileNumber="0585463789478654", AddressId=3, PaymentCardId=5},
                new Person {FirstName="Artemis", LastName="Aikema", MobileNumber="04352653629987655", AddressId=4, PaymentCardId=6},
                new Person {FirstName="Munir", LastName="Seth", MobileNumber="0867453678906546", AddressId=5, PaymentCardId=7},
                new Person {FirstName="Robert", LastName="Poggio", MobileNumber="0676556342524566", AddressId=6, PaymentCardId=8},
                new Person {FirstName="Jeremi", LastName="Hussain", MobileNumber="0123456473896735", AddressId=7, PaymentCardId=9},
                new Person {FirstName="Pepin", LastName="Trevor", MobileNumber="0234564689256376", AddressId=8, PaymentCardId=10},
                new Person {FirstName="Nathan", LastName="Stern", MobileNumber="0800674523435678", AddressId=9, PaymentCardId=11},
                new Person {FirstName="Vidya", LastName="Olofsson", MobileNumber="0400536749090034", AddressId=10, PaymentCardId=12}
            };

            context.People.AddRange(people);
            //context.SaveChanges();
        }

        private static void AddTutors(ApplicationDbContext context)
        {
            if (context.Tutors.Any())
            {
                return;
            }

            var tutor = new Tutor[]
            {
                new Tutor {Degree="Maths", MobileNumber="009746789345673", Bio=" ", Cost=17, PGCE=true},
                new Tutor {Degree="English", MobileNumber="056352673898843", Bio=" ", Cost=15, PGCE=true},
                new Tutor {Degree="Biology", MobileNumber="023456278645638", Bio=" ", Cost=15, PGCE=true},
                new Tutor {Degree="Chemistry", MobileNumber="017845537284563", Bio=" ", Cost=15, PGCE=true},
                new Tutor {Degree="Physics", MobileNumber="045647783954623", Bio=" ", Cost=19, PGCE=true},
                new Tutor {Degree="Maths", MobileNumber="089465367992345", Bio=" ", Cost=20, PGCE=true},
                new Tutor {Degree="English", MobileNumber="034566273564825", Bio=" ", Cost=15, PGCE=true}
            };

            context.Tutors.AddRange(tutor);
            //context.SaveChanges();
        }

        private static void AddStaff(ApplicationDbContext context)
        {
            if (context.Staff.Any())
            { 
                return; 
            }

            var staff = new Staff[]
            {
                new Staff {JobTitle="Lead Programmer", Salary=50000},
                new Staff {JobTitle="Designer", Salary=20000},
                new Staff {JobTitle="Project Manager", Salary=15000},
                new Staff {JobTitle="Technician", Salary=18000}
            };

            context.Staff.AddRange(staff);
            //context.SaveChanges();
        }

        private static void AddLessons(ApplicationDbContext context)
        {
            if(context.Lessons.Any())
            {
                return;
            }

            var lessons = new Lesson[]
            {
                new Lesson {LessonId=1, TimeSlotId=1, PersonId=1, StudentId=1, KeyStage=4, FaceToFace=true},
                new Lesson {LessonId=2, TimeSlotId=2, PersonId=2, StudentId=2, KeyStage=3, Online=true},
                new Lesson {LessonId=3, TimeSlotId=3, PersonId=3, StudentId=3, KeyStage=2, FaceToFace=true},
                new Lesson {LessonId=4, TimeSlotId=4, PersonId=4, StudentId=4, KeyStage=1, Online=true},
                new Lesson {LessonId=5, TimeSlotId=5, PersonId=5, StudentId=5, KeyStage=1, FaceToFace=true},
                new Lesson {LessonId=6, TimeSlotId=6, PersonId=6, StudentId=6, KeyStage=2, Online=true},
                new Lesson {LessonId=7, TimeSlotId=7, PersonId=7, StudentId=7, KeyStage=3, FaceToFace=true},
                new Lesson {LessonId=8, TimeSlotId=8, PersonId=8, StudentId=8, KeyStage=4, Online=true},
                new Lesson {LessonId=9, TimeSlotId=9, PersonId=9, StudentId=9, KeyStage=4, FaceToFace=true},
                new Lesson {LessonId=10, TimeSlotId=10, PersonId=10, StudentId=10, KeyStage=3, Online=true}

            };

            context.Lessons.AddRange(lessons);
            //context.SaveChanges();
        }

        private static void AddStudents(ApplicationDbContext context)
        {
            if(context.Students.Any())
            {
                return ;
            }

            var students = new Student[]
            {
                new Student {Id=1, KeyStage=3, ParentId=1, TutorId=1},
                new Student {Id=2, KeyStage=4, ParentId=2, TutorId=2},
                new Student {Id=3, KeyStage=2, ParentId=3, TutorId=3},
                new Student {Id=4, KeyStage=1, ParentId=4, TutorId=4},
                new Student {Id=5, KeyStage=1, ParentId=5, TutorId=5},
                new Student {Id=6, KeyStage=2, ParentId=6, TutorId=6},
                new Student {Id=7, KeyStage=3, ParentId=7, TutorId=7},
                new Student {Id=8, KeyStage=4, ParentId=8, TutorId=8},
                new Student {Id=9, KeyStage=4, ParentId=9, TutorId=9},
                new Student {Id=10, KeyStage=3, ParentId=10, TutorId=10}
            };

            context.Students.AddRange(students);
            //context.SaveChanges();
        }

        private static void AddTimeSlots (ApplicationDbContext context)
        {
            if(context.TimeSlot.Any())
            {
                return;
            }

            var timeslots = new TimeSlot[]
            {
                new TimeSlot{TutorId=1, Booked=true, DayOfTheWeek=12, StartHour=0900, EndHour=1000},
                new TimeSlot{TutorId=2, Booked=true, DayOfTheWeek=15, StartHour=1200, EndHour=1300},
                new TimeSlot{TutorId=3, Booked=true, DayOfTheWeek=18, StartHour=1000, EndHour=1100},
                new TimeSlot{TutorId=4, Booked=true, DayOfTheWeek=21, StartHour=1400,EndHour=1500},
                new TimeSlot{TutorId=5, Booked=true, DayOfTheWeek=24, StartHour=0930, EndHour=1030},
                new TimeSlot{TutorId=6, Booked=true, DayOfTheWeek=27, StartHour=1030, EndHour=1130},
                new TimeSlot{TutorId=7, Booked=true, DayOfTheWeek=30, StartHour=1230, EndHour=1300},
                new TimeSlot{TutorId=8, Booked=true, DayOfTheWeek=14, StartHour=1410, EndHour=1510},
                new TimeSlot{TutorId=9, Booked=true, DayOfTheWeek=22, StartHour=0900, EndHour=1030},
                new TimeSlot {TutorId=10, Booked=true, DayOfTheWeek=29, StartHour=1330, EndHour=1430}
            };

            context.TimeSlot.AddRange(timeslots);
            //context.SaveChanges();
        }




    }
}
