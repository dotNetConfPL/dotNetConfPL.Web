using System.ComponentModel.DataAnnotations;

namespace dotnetconfpl.DAL
{
    public class Session
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Presenter { get; set; }

        [Required]
        public string Description { get; set; }
    }
}