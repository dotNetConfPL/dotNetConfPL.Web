using System.Collections.Generic;

namespace dotnetconfpl.DAL
{
    public interface ISessionService
    {
        IEnumerable<Session> GetAll();
    }

    public class SessionService : ISessionService
    {
        public IEnumerable<Session> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}