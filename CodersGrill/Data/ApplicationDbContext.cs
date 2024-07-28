using Microsoft.EntityFrameworkCore;
using CodersGrill.Models;

namespace CodersGrill.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<TextContent> TextContents { get; set; }
    }
}