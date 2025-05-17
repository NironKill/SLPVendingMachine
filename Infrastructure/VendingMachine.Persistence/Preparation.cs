using Microsoft.EntityFrameworkCore;

namespace VendingMachine.Persistence
{
    public static class Preparation
    {
        public static async Task Initialize(ApplicationDbContext context) => await context.Database.MigrateAsync();    
    }
}
