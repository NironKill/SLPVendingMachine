using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Domain
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Brand Brand { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<ProductOrder> ProductsOrder { get; set; }
    }
}
