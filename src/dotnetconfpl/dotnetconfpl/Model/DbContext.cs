using System.Collections.Generic;

namespace dotnetconfpl.Model
{
    public class DbContext
    {
        public DbContext()
        {
        }

        public List<Session> Sessions { get; } = new List<Session>();
        public List<Speaker> Speakers { get; } = new List<Speaker>();
    }
}
