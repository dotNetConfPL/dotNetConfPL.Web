using System;
using System.Collections.Generic;
using dotnetconfpl.App_Start;
using dotnetconfpl.DAL;

namespace dotnetconfpl.Services
{
    public class RavenDbClient
    {
        public void AddTestUser()
        {
            using (var documentSession = RavenDb.DocumentStore.OpenSession())
            {
                var newAttende = new Attende
                {
                    Id = Guid.NewGuid().ToString(),
                    Mail = "michal.franc@gmail.com",
                    Name = "Michal Franc"
                };

                documentSession.Store(newAttende);
                documentSession.SaveChanges();
            }
        }

        public IEnumerable<Attende> List()
        {
            using (var documentSession = RavenDb.DocumentStore.OpenSession())
            {
               return documentSession.Query<Attende>();
            }
        }
    }
}