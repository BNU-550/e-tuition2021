using e_tuition2021.Models;
using System;
using System.Linq;

namespace e_tuition2021.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Addresses.Any())
            {
                return;   // DB has been seeded
            }

            var addresses = new Address[]
            {
                new Address{HouseNumber="5", PostCode="OX5 7JD"}
                
            };

            context.Addresses.AddRange(addresses);
            //context.SaveChanges();
        }
    }
}
