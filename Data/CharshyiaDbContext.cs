using Charshiya.Data.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Charshiya.Data
{
    public class CharshyiaDbContext : IdentityDbContext<CharshiyaUser>
    {
        public CharshyiaDbContext(DbContextOptions<CharshyiaDbContext> options)
            : base(options)
        {
        }
    }
}