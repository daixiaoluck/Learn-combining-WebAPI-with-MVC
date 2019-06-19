using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Learn_combining_WebAPI_with_MVC.Models
{
    public class MyInitializer: CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            Gig gig1 = new Gig
            {
                GigDate = new DateTime(2000, 1, 1)
            };
            Gig gig2 = new Gig
            {
                GigDate = new DateTime(2000, 2, 2)
            };
            context.Gigs.AddRange(new List<Gig> { gig1, gig2 });
            context.SaveChanges();
        }
    }
}