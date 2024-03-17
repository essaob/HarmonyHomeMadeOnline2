using System;
using Microsoft.EntityFrameworkCore;

namespace HarmonyHomeMadeOnline.Models
{
    public class OnlineContext: DbContext
    {
        public OnlineContext(DbContextOptions<OnlineContext> options):base(options) { }
        public DbSet<User> users { get; set; }      
        public DbSet<Product> products { get; set; }
    }
}
