using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace DataLayer.Database
{
	public class DatabaseContext : DbContext
	{
		public DbSet<DatabaseUser> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string databaseFile = "Welcome.db";
			string databasePath = Path.Combine(solutionFolder, databaseFile);
			optionsBuilder.UseSqlite($"Data Source={databasePath}");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

			//create user
			var user = new DatabaseUser()
			{
				Id = 1,
				Name = "John Doe",
				Password = "1234",
				Email = "sjrhgkusjglshgk",
				FakNomer = "125435y76352",
				Role = UserRolesEnum.ADMIN,
				Expires = DateTime.Now.AddYears(10)
			};

			var user2 = new DatabaseUser()
			{
				Id = 2,
				Name = "John Doe",
				Password = "1234",
				Email = "sjrhgkusjglshgk",
				FakNomer = "125435y76352",
				Role = UserRolesEnum.STUDENT,
				Expires = DateTime.Now.AddYears(5)
			};

			var user3 = new DatabaseUser()
			{
				Id = 3,
				Name = "John Doe",
				Password = "1234",
				Email = "sjrhgkusjglshgk",
				FakNomer = "125435y76352",
				Role = UserRolesEnum.PROFESSOR,
				Expires = DateTime.Now.AddYears(12)
			};

			modelBuilder.Entity<DatabaseUser>().HasData(user);
			modelBuilder.Entity<DatabaseUser>().HasData(user2);
			modelBuilder.Entity<DatabaseUser>().HasData(user3);
		}
	}
}
