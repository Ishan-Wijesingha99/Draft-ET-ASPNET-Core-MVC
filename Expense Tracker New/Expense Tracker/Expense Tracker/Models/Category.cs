// need this to access [Key] and [Required] etc
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Expense_Tracker.Models
{
    public class Category
    {
        // primary key
        [Key]
        public int CategoryId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [MaxLength(50)]
        [Required]
        public string Icon { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; } = "Expense"; // just setting default value
    }
}
