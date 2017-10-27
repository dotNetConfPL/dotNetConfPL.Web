namespace dotnetconfpl.Areas._2016.Model
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