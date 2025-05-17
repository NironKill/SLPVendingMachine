using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendingMachine.Domain;

namespace VendingMachine.Persistence.EntityTypeConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(p => p.Orders).WithMany(p => p.Products).UsingEntity<ProductOrder>(
                x => x.HasOne<Order>(po => po.Order).WithMany(o => o.ProductsOrder).HasForeignKey(po => po.OrderId),
                x => x.HasOne<Product>(po => po.Product).WithMany(p => p.ProductsOrder).HasForeignKey(po => po.ProductId));
        }
    }
}
