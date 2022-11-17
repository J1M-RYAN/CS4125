// ORM implementation using EFcore

public class ApplicationDbContext : DbContext
{
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>().ToTable("Blog");
        modelBuilder.Entity<Post>().ToTable("Post");
    }
}
