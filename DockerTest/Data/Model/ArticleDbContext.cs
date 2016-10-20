using Microsoft.EntityFrameworkCore;
namespace DockerTest.Data.Model
{
    public class ArticleDbContext : DbContext  
    {
        public ArticleDbContext(DbContextOptions<ArticleDbContext> options)
            : base(options)
        { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}