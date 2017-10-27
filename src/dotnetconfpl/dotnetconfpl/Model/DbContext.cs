using System.Collections.Generic;

namespace dotnetconfpl.Model
{
    public class DbContext
    {
        List<Session> _sessions = new List<Session>();
        List<Speaker> _speakers = new List<Speaker>();

        public DbContext()
        {
        }

        public List<Session> Sessions { get { return _sessions; } private set { _sessions = value; } }
        public List<Speaker> Speakers { get { return _speakers; } private set { _speakers = value; } }
    }
}