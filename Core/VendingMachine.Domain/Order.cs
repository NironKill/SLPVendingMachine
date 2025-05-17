using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Domain
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsCompleted { get; set; } = false;

        public ICollection<Product> Products { get; set; }
        public ICollection<ProductOrder> ProductsOrder { get; set; }
    }
}
