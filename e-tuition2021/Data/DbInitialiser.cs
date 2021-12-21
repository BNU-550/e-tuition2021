using e_tuition2021.Models;
using System;
using System.Linq;

namespace e_tuition2021.Data
{ 
    public static class DbInitialiser
    {
        /// <summary>
        /// people 1-5 are parents 
        /// people 6-10 are staff
        /// people 11-20 are students
        /// people 21-30 are tutors
        /// 
        /// address 1-5 are parents
        /// addresses 6-10 are staff
        /// addresses  11-20 are tutors
        /// 
        /// students use parent address
        /// tutors have address have 11-20
        /// 
        /// payment cards 1-5
        /// 
        /// payment card 1 is a dummy
        /// 
        /// payments cards 2-6 are parents
        /// </summary>
        /// <param name="context"></param>
        public static void Initialise(ApplicationDbContext context)
        {
            //address id = 31-40
            AddAddresses(context);

            //payment id = 34-44 
            AddPaymentCards(context);

            AddPeople(context);

            AddTutors(context);

            AddStaff(context);

            //AddLessons(context);

            AddStudents(context);

            //AddTimeSlots(context);
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
            context.SaveChanges();
        }

        private static void AddPaymentCards(ApplicationDbContext context)
        {
            if (context.PaymentCards.Any())
            {
                return;
            }

            var paymentcards = new PaymentCard[]
            {
                new PaymentCard {CardNumber = "0000000000000000", SortCode = "00-00-00", ExpiryMonth=01, ExpiryYear=2030},
                new PaymentCard {CardNumber = "5689024563765434", SortCode = "02-82-56", ExpiryMonth=08, ExpiryYear=2023},
                new PaymentCard {CardNumber = "8723453609467397", SortCode = "06-79-22", ExpiryMonth=09, ExpiryYear=2022},
                new PaymentCard {CardNumber = "0986742543672563", SortCode = "01-37-56", ExpiryMonth=04, ExpiryYear=2025},
                new PaymentCard {CardNumber = "8754673890753425", SortCode = "07-56-12", ExpiryMonth=07, ExpiryYear=2030},
                new PaymentCard {CardNumber = "3452637352738464", SortCode = "08-45-10", ExpiryMonth=11, ExpiryYear=2029},
                new PaymentCard {CardNumber = "6743653848728894", SortCode = "12-90-98", ExpiryMonth=02, ExpiryYear=2022},
                new PaymentCard {CardNumber = "0093737267367283", SortCode = "26-09-77", ExpiryMonth=12, ExpiryYear=2021},
                new PaymentCard {CardNumber = "9928763527189173", SortCode = "24-78-99", ExpiryMonth=10, ExpiryYear=2030},
                new PaymentCard {CardNumber = "5566253513252626", SortCode = "84-22-11", ExpiryMonth=01, ExpiryYear=2027},
                new PaymentCard {CardNumber = "6745637892653678", SortCode = "09-87-89", ExpiryMonth=03, ExpiryYear=2025}
            };

            context.PaymentCards.AddRange(paymentcards);
            context.SaveChanges();
        }

        private static void AddPeople(ApplicationDbContext context)
        {
            if (context.People.Any())
            {
                return;
            }

            var people = new Person[]
            {
                new Person 
                {
                    FirstName="Scaevola", 
                    LastName="Sommer", 
                    MobileNumber="078945362736789", 
                    AddressId=1, 
                    PaymentCardId=1
                },
                new Person 
                {   
                    FirstName="Silvio", 
                    LastName="Ture", 
                    MobileNumber="087352725367824", 
                    AddressId=2, 
                    PaymentCardId=2
                },
                new Person 
                {
                    FirstName="Judith", 
                    LastName="Rickard", 
                    MobileNumber="058546378947865", 
                    AddressId=3, 
                    PaymentCardId=3
                },
                new Person 
                {
                    FirstName="Artemis", 
                    LastName="Aikema", 
                    MobileNumber="043526536299876", 
                    AddressId=4, 
                    PaymentCardId=4
                },
                new Person 
                {
                    FirstName="Munir", 
                    LastName="Seth",
                    MobileNumber="086745367890654", 
                    AddressId=5, 
                    PaymentCardId=5
                }
                //new Person {FirstName="Robert", LastName="Poggio", MobileNumber="0676556342524566", AddressId=6, PaymentCardId=8},
                //new Person {FirstName="Jeremi", LastName="Hussain", MobileNumber="0123456473896735", AddressId=7, PaymentCardId=9},
                //new Person {FirstName="Pepin", LastName="Trevor", MobileNumber="0234564689256376", AddressId=8, PaymentCardId=10},
                //new Person {FirstName="Nathan", LastName="Stern", MobileNumber="0800674523435678", AddressId=9, PaymentCardId=11},
                //new Person {FirstName="Vidya", LastName="Olofsson", MobileNumber="0400536749090034", AddressId=10, PaymentCardId=12}
            };

            context.People.AddRange(people);
            context.SaveChanges();
        }

        private static void AddTutors(ApplicationDbContext context)
        {
            if (context.Tutors.Any())
            {
                return;
            }

            var tutor = new Tutor[]
            {
                new Tutor 
                {
                    AddressId = 6,
                    PaymentCardId = 6,
                    FirstName = "Bob",
                    LastName = "Miles",
                    Degree="BSc (Hons) Maths", 
                    MobileNumber="009746789345673", 
                    Cost=17, 
                    PGCE=true, 
                    DbsCheck=new DateTime(2018,7,12)
                },

                new Tutor
                {
                    AddressId=7,
                    PaymentCardId=7,
                    FirstName="Elif",
                    LastName="Sharma",
                    Degree="Bsc (Hons)English",
                    MobileNumber="056352673898843",
                    Cost=15,
                    PGCE=true,
                    DbsCheck=new DateTime(2016,3,14)
                },
                new Tutor
                {
                    AddressId=8,
                    PaymentCardId=8,
                    FirstName="Sammuel",
                    LastName="Lennon",
                    Degree="Hsc (Hons)Biology",
                    MobileNumber="023456278645638",
                    Cost=15,
                    PGCE=true,
                    DbsCheck=new DateTime(2017,9,11)
                },
                new Tutor
                {
                    AddressId=9,
                    PaymentCardId=9,
                    FirstName="Milada",
                    LastName="Slavkov",
                    Degree="Bsc (Hons)Chemistry",
                    MobileNumber="017845537284563",
                    Cost=15,
                    PGCE=true,
                    DbsCheck=new DateTime(2019,10,1)
                },
                new Tutor
                {
                    AddressId=10,
                    PaymentCardId=10,
                    FirstName="Nada",
                    LastName="Beck",
                    Degree="PHD Physics",
                    MobileNumber="045647783954623",
                    Cost=19,
                    PGCE=true,
                    DbsCheck=new DateTime(2020,2,10)
                }
                //new Tutor
                //{
                //    AddressId=36,
                //    PaymentCardId=34,
                //    FirstName="Miksa",
                //    LastName="Linden",
                //    Degree="Bsc (Hons)Maths",
                //    MobileNumber="089465367992345",
                //    Cost=20,
                //    PGCE=true,
                //    DbsCheck=new DateTime(2021,4,3)
                //},
                //new Tutor
                //{
                //    AddressId=37,
                //    PaymentCardId=34,
                //    FirstName="Davor",
                //    LastName="Statham",
                //    Degree="Bsc (Hons)English",
                //    MobileNumber="034566273564825",
                //    Cost=15,
                //    PGCE=true,
                //    DbsCheck=new DateTime(2018,9,29)
                //},
                //new Tutor
                //{
                //    AddressId=38,
                //    PaymentCardId=34,
                //    FirstName="Govad",
                //    LastName="Montgomery",
                //    Degree="PHD Computing",
                //    MobileNumber="056473826372886",
                //    Cost=20,
                //    PGCE=true,
                //    DbsCheck=new DateTime(2020,11,11)
                //}
            };

            context.Tutors.AddRange(tutor);
            context.SaveChanges();
        }

        private static void AddStaff(ApplicationDbContext context)
        {
            if (context.Staff.Any())
            { 
                return; 
            }

            var staff = new Staff[]
            {
                new Staff 
                {
                    FirstName = "Gita",
                    LastName = "Patel",
                    MobileNumber = "07981234765",
                    JobTitle = "Lead Programmer", 
                    Salary = 50000, 
                    
                },
                new Staff 
                {
                    FirstName="Jela",
                    LastName="Williams",
                    MobileNumber="03456278973",
                    JobTitle="Designer", 
                    Salary=20000,
                    
                },
                new Staff 
                {
                    FirstName="Karpos",
                    LastName="Esben",
                    MobileNumber="06748536892",
                    JobTitle="Project Manager", 
                    Salary=15000,
                    
                },
                new Staff 
                {
                    FirstName="Rudolf",
                    LastName="Ruskin",
                    MobileNumber="01439876634",
                    JobTitle="Technician", 
                    Salary=18000,
                   
                }
            };

            context.Staff.AddRange(staff);
            context.SaveChanges();
        }

        private static void AddLessons(ApplicationDbContext context)
        {
            if (context.Lessons.Any())
            {
                return;
            }

            var lessons = new Lesson[]
            {
                new Lesson 
                {
                    //TimeSlotId=1, 
                    PersonId=1, 
                    StudentId=1, 
                    KeyStage=4, 
                    FaceToFace=true, 
                    StartDate=new DateTime(11,4/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=2, 
                    PersonId=2, 
                    StudentId=2, 
                    KeyStage=3, 
                    Online=true, 
                    StartDate=new DateTime(5/1/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=3, 
                    PersonId=3, 
                    StudentId=3, 
                    KeyStage=2, 
                    FaceToFace=true, 
                    StartDate=new DateTime(7/3/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=4, 
                    PersonId=4, 
                    StudentId=4, 
                    KeyStage=1, 
                    Online=true, 
                    StartDate=new DateTime(3/6/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=5, 
                    PersonId=5, 
                    StudentId=5, 
                    KeyStage=1, 
                    FaceToFace=true, 
                    StartDate=new DateTime(10/2/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=6, 
                    PersonId=6, 
                    StudentId=6, 
                    KeyStage=2, 
                    Online=true, 
                    StartDate=new DateTime(12/9/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=7, 
                    PersonId=7, 
                    StudentId=7, 
                    KeyStage=3, 
                    FaceToFace=true, 
                    StartDate=new DateTime(9/11/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=8, 
                    PersonId=8, 
                    StudentId=8, 
                    KeyStage=4, 
                    Online=true, 
                    StartDate=new DateTime(30/1/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=9, 
                    PersonId=9,
                    StudentId=9,
                    KeyStage=4, 
                    FaceToFace=true,
                    StartDate=new DateTime(22/5/2020)
                },
                new Lesson 
                {
                    //TimeSlotId=10,
                    PersonId=10,
                    StudentId=10, 
                    KeyStage=3,
                    Online=true,
                    StartDate=new DateTime(19/10/2020)
                }

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
                new Student 
                {
                    StudentName="Govinder Sommer",
                    KeyStage=3, 
                    ParentId=1, 
                    TutorId=1
                },

                new Student 
                {   
                    StudentName="Susan Ture",
                    KeyStage=4, 
                    ParentId=2, 
                    TutorId=2
                },
                new Student 
                {
                    StudentName="Magda Rickard",
                    KeyStage=2, 
                    ParentId=3, 
                    TutorId=3
                },
                new Student 
                {
                    StudentName="Mohan Aikema",
                    KeyStage=1, 
                    ParentId=4, 
                    TutorId=4
                },
                new Student 
                {
                    StudentName="Helen Seth",
                    KeyStage=1, 
                    ParentId=5, 
                    TutorId=5
                }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }

        private static void AddTimeSlots (ApplicationDbContext context)
        {
            if (context.TimeSlot.Any())
            {
                return;
            }

            var timeslots = new TimeSlot[]
            {
                new TimeSlot
                {
                    //TutorId=1, 
                    Booked=true, 
                    DayOfTheWeek=12, 
                    StartHour=0900, 
                    EndHour=1000
                },
                new TimeSlot
                {
                    //TutorId=2, 
                    Booked=true,
                    DayOfTheWeek=15,
                    StartHour=1200,
                    EndHour=1300
                },
                new TimeSlot
                {
                    //TutorId=3, 
                    Booked=true,
                    DayOfTheWeek=18,
                    StartHour=1000,
                    EndHour=1100
                },
                new TimeSlot
                {
                    //TutorId=4,
                    Booked=true,
                    DayOfTheWeek=21,
                    StartHour=1400,
                    EndHour=1500
                },
                new TimeSlot
                {
                    //TutorId=5, 
                    Booked=true,
                    DayOfTheWeek=24,
                    StartHour=0930,
                    EndHour=1030
                },
                new TimeSlot
                {
                    //TutorId=6, 
                    Booked=true, 
                    DayOfTheWeek=27, 
                    StartHour=1030, 
                    EndHour=1130
                },
                new TimeSlot
                {
                    //TutorId=7, 
                    Booked=true, 
                    DayOfTheWeek=30, 
                    StartHour=1230, 
                    EndHour=1300
                },
                new TimeSlot
                {
                    //TutorId=8, 
                    Booked=true, 
                    DayOfTheWeek=14, 
                    StartHour=1410, 
                    EndHour=1510
                },
                new TimeSlot
                {
                    //TutorId=9, 
                    Booked=true, 
                    DayOfTheWeek=22, 
                    StartHour=0900, 
                    EndHour=1030
                },
                new TimeSlot
                {
                    //TutorId=10, 
                    Booked=true, 
                    DayOfTheWeek=29, 
                    StartHour=1330, 
                    EndHour=1430
                }
            };

            context.TimeSlot.AddRange(timeslots);
            //context.SaveChanges();
        }




    }
}
