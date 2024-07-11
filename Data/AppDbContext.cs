using IdentityApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityApi.Data
{
    public class AppDbContext(DbContextOptions options) : IdentityDbContext<User>(options);
    
}
