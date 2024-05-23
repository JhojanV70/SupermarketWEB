using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Detail
    {
        public int Id { get; set; }
        
        
        public int Quantity { get; set; }
        public int Price { get; set; }
      
    }
}
