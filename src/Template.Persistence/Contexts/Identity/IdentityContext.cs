using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template.Domain.Models;

namespace Template.Persistence.Contexts.Identity;

public sealed class IdentityContext : IdentityDbContext<User>
{
    public IdentityContext(DbContextOptions options) : base(options)
    {
    }
}