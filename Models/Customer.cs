using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string BirthdayData { get; set; }
        public string Email { get; set; }       
        public int Phone { get; set; }
        public string? Description { get; set; }
        public ICollection<Invoice>? Invoices { get; set; } = default!;
    }
}