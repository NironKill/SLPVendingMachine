using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VendingMachine.Domain;

namespace VendingMachine.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Coin> Coins { get; set; }
        DbSet<ProductOrder> ProductsOrder { get; set; }

        DbSet<User> Users { get; set; }
        DbSet<IdentityUserToken<Guid>> UserTokens { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
