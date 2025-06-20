using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace AmtOrk.Server.Models;

public class Land : RootModel
{
	public string LandName { get; set; } = default!;
	public string LandDescription { get; set; } = default!;
	public string LandLocation { get; set; } = default!;
	[ForeignKey("Kingdom")]
	public int KingdomId { get; set; }
	public string? LandIconPath { get; set; }
	public virtual OrkUser? Monarch { get; set; }
	public virtual OrkUser? Regent { get; set; }
	public virtual OrkUser? Champion { get; set; }
	public virtual OrkUser? PrimeMinister { get; set; }
	public virtual OrkUser? GMR { get; set; }

	public virtual List<Event>? LandEvents { get; set; }
	[NotMapped]
	public virtual string LandSlug { get => Regex.Replace(LandName.ToLower(), @"\s", "-"); }
}