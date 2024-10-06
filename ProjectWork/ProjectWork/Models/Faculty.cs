using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
