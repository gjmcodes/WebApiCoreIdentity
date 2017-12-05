using Infra.CrossCutting.Auth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.CrossCutting.Auth.Context
{
    public class IdentityAppContext : IdentityDbContext<IdentityAppUser>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options)
            : base(options)
        {
        }
    }
}
