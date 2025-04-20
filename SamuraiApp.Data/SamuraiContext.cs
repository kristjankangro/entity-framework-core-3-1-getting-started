using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
	public class SamuraiContext : DbContext
	{
		public DbSet<Samurai> Samurais { get; set; }
		public DbSet<Clan> Clans { get; set; }
		public DbSet<Quote> Quotes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder
					.UseSqlServer(
						"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SamuraiAppData;Trusted_Connection=True;");
			}
		}
	}
}