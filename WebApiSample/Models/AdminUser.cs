using System.ComponentModel.DataAnnotations;

namespace WebApiSample.Models
{
    public class AdminUser
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool? IsDeleted { get; set; } 
        public DateTime? AddDate { get; set; } = DateTime.Now;
    }
}
