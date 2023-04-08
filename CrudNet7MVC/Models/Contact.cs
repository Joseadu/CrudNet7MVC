using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Name missing")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone missing")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email missing")]
        public string Email { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
