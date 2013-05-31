using System.ComponentModel.DataAnnotations;

namespace dotnetconfpl.DAL
{
    public class Attende
    {
        public string Id { get; set; }

        [Required]
        public string Mail { get; set; }
    }
}