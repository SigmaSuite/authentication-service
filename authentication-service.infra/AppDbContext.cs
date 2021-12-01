using Microsoft.EntityFrameworkCore;

namespace AuthenticationService.Infra
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
            
        }

    }

}