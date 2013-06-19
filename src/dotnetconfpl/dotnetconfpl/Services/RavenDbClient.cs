using System;
using System.Collections.Generic;
using dotnetconfpl.App_Start;
using dotnetconfpl.DAL;

namespace dotnetconfpl.Services
{
    public class RavenDbClient
    {
        public IEnumerable<Attende> List()
        {
            using (var documentSession = RavenDb.DocumentStore.OpenSession())
            {
               return documentSession.Query<Attende>();
            }
        }

        public void AddAttende(Attende newAttende)
        {
            using (var documentSession = RavenDb.DocumentStore.OpenSession())
            {
                newAttende.Id = Guid.NewGuid().ToString();

                documentSession.Store(newAttende);
                documentSession.SaveChanges();
            }
        }
    }
}