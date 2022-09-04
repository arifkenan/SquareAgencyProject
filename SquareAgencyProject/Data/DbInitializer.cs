using KareAjans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AgencyContext context)
        {
            context.Database.EnsureCreated();
            if (context.Actors.Any())
            {
                return; // DB has data
            }

            var actors = new Actor[]
            {
                new Actor{ FirstName="Test", LastName="test", Address="test", ContractPrice=100, PhoneNumber="+123456" },
               
            };
            context.Actors.AddRange(actors);
            context.SaveChanges();

            var staff = new Staff[]
            {
                new Staff{ FirstName="Test", LastName="test", Address="test", PhoneNumber="+123456", PerformanceScore=1.0, Salary=100 },
                
            };
            context.Staff.AddRange(staff);
            context.SaveChanges();

            var contracts = new Contract[]
            {
                new Contract{ Actor=actors.First(), ManagingStaff=staff.First(), StartDate=new DateTime(2020, 11, 20), EndDate=new DateTime(2020, 11, 27), TotalPrice=10000  },
               
            };
            context.Contracts.AddRange(contracts);
            context.SaveChanges();
        }
    }
}
