using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; }=string.Empty;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
       // public DateTime UpdatedAt { get; set; } = DateTime.Now;
        // Additional properties can be added as needed
    }
}
