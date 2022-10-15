using Microsoft.AspNetCore.Identity;

namespace YtMovieApis.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public string? Name { get; set; }
    }
}
