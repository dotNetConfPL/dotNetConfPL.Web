using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotnetconfpl.Model
{
    public class Session
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string Title { get; set; }
        public Speaker Speaker { get; set; }
        public string About { get; set; }
        public string YoutubeUrl { get; set; }
    }
}