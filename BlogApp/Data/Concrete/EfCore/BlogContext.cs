using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogContex:DbContext {

        public BlogContex(DbContextOptions<BlogContex> options): base(options){
            
        }

        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<User> Users => Set<User>();

    }
}
