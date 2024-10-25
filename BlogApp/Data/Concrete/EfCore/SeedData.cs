using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore{
    public static class SeedData{
        public static void TestVerileriniDoldur(IApplicationBuilder app){
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContex>();
            if(context != null){
                if(context.Database.GetPendingMigrations().Any()){
                    context.Database.Migrate();
                }

                if(!context.Tags.Any()){
                    context.Tags.AddRange(
                        new Tag {Text = "web programlama"},
                        new Tag {Text = "backend"},
                        new Tag {Text = "frontend"},
                        new Tag {Text = "fullstack"},
                        new Tag {Text = "php"}
                    );
                    context.SaveChanges();
                }
                if(!context.Users.Any()){
                    context.Users.AddRange(
                        new User {UserName = "harun"},
                        new User {UserName = "selcuk"}
                    );
                    context.SaveChanges();
                }
                if(!context.Posts.Any()){
                    context.Posts.AddRange(
                        new Post {
                            Title = "Asp.net Core",
                            Content = "Asp .net core öğreniyorumş.",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(5).ToList(),
                            UserId=1,
                        },
                        new Post {
                            Title = "Asp.net Core 2",
                            Content = "Asp .net core öğreniyorumş. 2",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId=1,
                        },
                        new Post {
                            Title = "Asp.net Core 3",
                            Content = "Asp .net core öğreniyorumş. 3",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-5),
                            Tags = context.Tags.Take(1).ToList(),
                            UserId=2,
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}