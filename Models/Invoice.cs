namespace SupermarketWEB.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int PayModeId { get; set; }
        public PayMode PayMode { get; set; }
        public ICollection<Detail>? Detsails { get; set; } = default!;
    }
}