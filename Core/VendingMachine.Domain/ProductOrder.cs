using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Domain
{
    public class ProductOrder
    {
        [Key]
        public int Id { get; set; } 
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
