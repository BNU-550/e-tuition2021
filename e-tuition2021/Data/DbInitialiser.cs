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

            Add
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
        }
    }
}
