using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YtMovieApis.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
                
        }

        public DbSet<TokenInfo> TokenInfo { get; set; }


    }
}
