using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dotnetconfpl.DAL
{
    public class Attende
    {
        public string Id { get; set; }

        [Required]
        [DisplayName("Nazwa :")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Email :")]
        [EmailAddress]
        public string Mail { get; set; }
    }
}