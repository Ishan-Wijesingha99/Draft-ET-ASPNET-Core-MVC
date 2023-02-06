
// need this to access [Key] and [Required] etc
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        // primary key
        [Key]
        public int TransactionId { get; set; }


        // the CategoryId will be this table's foreign key, which we know is the primary key of the other table
        // you do this by defining CategoryId again here, and right after, you include a Category property for that key
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        [Required]
        public int Amount { get; set; }


        [MaxLength(50)]
        [AllowNull]
        public string? Note { get; set; }


        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}