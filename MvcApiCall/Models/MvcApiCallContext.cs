using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MvcApiCall.Models
{
  public class MvcApiCallContext : IdentityDbContext<ApplicationUser>
  {
    

    public MvcApiCallContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseLazyLoadingProxies();
    }
  }
}