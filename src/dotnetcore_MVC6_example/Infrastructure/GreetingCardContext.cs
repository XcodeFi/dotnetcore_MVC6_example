using Gradudate_project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gradudate_project.Infrastructure
{
    public class GreetingCardContext:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public GreetingCardContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            string schema = "dbo";
            // Card
            modelBuilder.Entity<Card>().Property(x => x.CateId).HasColumnName("CateId").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Card>().Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Card>().Property(x => x.Title).HasColumnName("Title").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            modelBuilder.Entity<Card>().Property(x => x.Content).HasColumnName("Content").HasColumnType("nvarchar").HasMaxLength(500);
            modelBuilder.Entity<Card>().Property(x => x.ViewNo).HasColumnName("ViewNo").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Card>().Property(x => x.LikesNo).HasColumnName("LikesNo").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Card>().Property(x => x.CardSize).HasColumnName("CardSize").HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Entity<Card>().Property(x => x.CardType).HasColumnName("CardType").HasColumnType("nvarchar").HasMaxLength(50);
            modelBuilder.Entity<Card>().Property(x => x.IsDelete).HasColumnName("IsDelete").IsRequired().HasColumnType("bit");
            modelBuilder.Entity<Card>().Property(x => x.ImageUrl).HasColumnName("ImageUrl").HasColumnType("nvarchar").HasMaxLength(250);
            modelBuilder.Entity<Card>().Property(x => x.RateNo).HasColumnName("RateNo").HasColumnType("tinyint");
            modelBuilder.Entity<Card>().Property(x => x.DateCreated).HasColumnName("DateCreated").IsRequired().HasColumnType("datetime");
            modelBuilder.Entity<Card>().Property(x => x.IsPublish).HasColumnName("IsPublish").IsRequired().HasColumnType("bit");
            modelBuilder.Entity<Card>().Property(x => x.TextSearch).HasColumnName("TextSearch").HasColumnType("nvarchar").HasMaxLength(250);

            // Blog
            modelBuilder.Entity<Blog>().Property(x => x.CateBlogId).HasColumnName("CateBlogId").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Blog>().Property(x => x.Title).HasColumnName("Title").IsRequired().HasColumnType("nvarchar").HasMaxLength(250);
            modelBuilder.Entity<Blog>().Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Blog>().Property(x => x.UrlSlug).HasColumnName("UrlSlug").HasColumnType("nvarchar").HasMaxLength(250);
            modelBuilder.Entity<Blog>().Property(x => x.Summary).HasColumnName("Summary").IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            modelBuilder.Entity<Blog>().Property(x => x.Content).HasColumnName("Content").IsRequired().HasColumnType("nvarchar");
            modelBuilder.Entity<Blog>().Property(x => x.ImageUrl).HasColumnName("ImageUrl").HasColumnType("nvarchar").HasMaxLength(500);
            modelBuilder.Entity<Blog>().Property(x => x.ViewNo).HasColumnName("ViewNo").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Blog>().Property(x => x.IsDelete).HasColumnName("IsDelete").IsRequired().HasColumnType("bit");
            modelBuilder.Entity<Blog>().Property(x => x.IsLock).HasColumnName("IsLock").IsRequired().HasColumnType("bit");
            modelBuilder.Entity<Blog>().Property(x => x.Status).HasColumnName("Status").IsRequired().HasColumnType("bit");
            modelBuilder.Entity<Blog>().Property(x => x.DatePosted).HasColumnName("DatePosted").IsRequired().HasColumnType("datetime");
            modelBuilder.Entity<Blog>().Property(x => x.LikeNo).HasColumnName("LikeNo").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Blog>().Property(x => x.DateEdited).HasColumnName("DateEdited").IsRequired().HasColumnType("datetime");
            modelBuilder.Entity<Blog>().Property(x => x.TextSearch).HasColumnName("TextSearch").HasColumnType("nvarchar").HasMaxLength(250);

            //Category
            modelBuilder.Entity<Category>().ToTable(schema + ".Category");
            modelBuilder.Entity<Category>().HasKey(x => x.Id);

            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int");
            modelBuilder.Entity<Category>().Property(x => x.ParentId).HasColumnName("Parent_Id").HasColumnType("int");
            modelBuilder.Entity<Category>().Property(x => x.Level).HasColumnName("Level").IsRequired().HasColumnType("tinyint");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(450);
            modelBuilder.Entity<Category>().Property(x => x.UrlSlug).HasColumnName("UrlSlug").IsRequired().HasColumnType("varchar").HasMaxLength(450);
            modelBuilder.Entity<Category>().Property(x => x.ImageUrl).HasColumnName("ImageUrl").HasColumnType("nvarchar").HasMaxLength(250);
            modelBuilder.Entity<Category>().Property(x => x.DateCreated).HasColumnName("DateCreated").IsRequired().HasColumnType("datetime");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("Description").HasColumnType("nvarchar");
            modelBuilder.Entity<Category>().Property(x => x.IsPublish).HasColumnName("IsPublish").IsRequired().HasColumnType("tinyint");
            modelBuilder.Entity<Category>().Property(x => x.IsDelete).HasColumnName("IsDelete").IsRequired().HasColumnType("tinyint");
            modelBuilder.Entity<Category>().Property(x => x.IsMainMenu).HasColumnName("IsMainMenu").IsRequired().HasColumnType("bit");
            modelBuilder.Entity<Category>().Property(x => x.Status).HasColumnName("Status").IsRequired().HasColumnType("tinyint");
            

            // User
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.Salt).IsRequired().HasMaxLength(200);

            // UserRole
            modelBuilder.Entity<UserRole>().Property(ur => ur.UserId).IsRequired();
            modelBuilder.Entity<UserRole>().Property(ur => ur.RoleId).IsRequired();

            // Role
            modelBuilder.Entity<Role>().Property(r => r.Name).IsRequired().HasMaxLength(50);
        }
    }
}
