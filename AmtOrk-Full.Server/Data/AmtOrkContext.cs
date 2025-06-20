using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AmtOrk.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;

namespace AmtOrk.Server.Data;

public class AmtOrkContext : DbContext
{
	public DbSet<Kingdom> Kingdom { get; set; } = default!;
	public DbSet<Land> Land { get; set; } = default!;
	public DbSet<Event> Event { get; set; } = default!;
	public DbSet<Credit> Credit { get; set; } = default!;
	// public DbSet<OrkUser> OrkUser { get; set; } = default!; // Users not currently implemented

	public AmtOrkContext(DbContextOptions<AmtOrkContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		LoadSeedDataFile(modelBuilder);

		modelBuilder.Entity<AmtClass>().HasIndex(c => c.ClassName).IsUnique();

		// modelBuilder.Entity<Kingdom>().Navigation(k => k.Lands).AutoInclude();
		modelBuilder.Entity<Kingdom>().HasIndex(k => k.KingdomName).IsUnique();
	}

	public void LoadSeedDataFile(ModelBuilder mb)
	{
		// Lands
		List<AmtClass>? classesSeedData = new();
		using (StreamReader r = new(AppContext.BaseDirectory + "/Data/ClassesSeedData.json"))
		{
			string classjson = r.ReadToEnd();
			classesSeedData = JsonSerializer.Deserialize<List<AmtClass>>(classjson);
		}
		if (classesSeedData != null)
			mb.Entity<AmtClass>().HasData(classesSeedData);
		// Kingdoms
		List<Kingdom>? kingdomSeedData = new();
		using (StreamReader r = new(AppContext.BaseDirectory + "/Data/KingdomSeedData.json"))
		{
			string kingdomjson = r.ReadToEnd();
			kingdomSeedData = JsonSerializer.Deserialize<List<Kingdom>>(kingdomjson);
		}
		if (kingdomSeedData != null)
			mb.Entity<Kingdom>().HasData(kingdomSeedData);
		// Lands
		List<Land>? landSeedData = new();
		using (StreamReader r = new(AppContext.BaseDirectory + "/Data/LandSeedData.json"))
		{
			string landjson = r.ReadToEnd();
			landSeedData = JsonSerializer.Deserialize<List<Land>>(landjson);
		}
		if (landSeedData != null)
			mb.Entity<Land>().HasData(landSeedData);
	}
}