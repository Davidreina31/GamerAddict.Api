using System;
using Microsoft.EntityFrameworkCore;
using GamerAddict.Domain.Entity;

namespace GamerAddict.DAL.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
		{
		}
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
            //options.UseSqlServer("Data Source=(localdb)\\Local;Initial Catalog=GamerAddict;Integrated Security=True;" +
            //             "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            options.UseSqlServer("Server=localhost;Database=GamerAddict;User Id=SA;Password=P@ssword1;");
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Plateform> Plateforms { get; set; }
        public DbSet<Plateform_VideoGame> Plateform_VideoGames { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_VideoGame> User_VideoGames { get; set; }
        public DbSet<VideoGame> VideoGames { get; set; }
    }
}

