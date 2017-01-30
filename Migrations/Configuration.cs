namespace Test_MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    
    internal sealed class Configuration : DbMigrationsConfiguration<Test_MVC.Models.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Test_MVC.Models.MovieContext context)
        {
            context.Movies.AddOrUpdate(m => m.Title,
                new Models.Movie
                {
                    Title = "Star Wars", ReleaseYear = 1977, Runtime = 121
                },
                new Models.Movie
                {
                    Title = "Inception", ReleaseYear = 2010, Runtime = 148
                },
                new Models.Movie
                {
                    Title = "Toy Story", ReleaseYear = 1995, Runtime = 81
                }
            );
        }
    }
}
