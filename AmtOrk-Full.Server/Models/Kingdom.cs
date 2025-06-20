using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace AmtOrk.Server.Models;

public class Kingdom : RootModel
{
	public string KingdomName { get; set; } = default!;
	public string? KingdomDescription { get; set; }
	public string? KingdomIconPath { get; set; } // Possibly replace with either a BLOB storage of the image or figure out a differing solution
	public virtual List<Land> Lands { get; set; } = default!;
	public virtual OrkUser? Monarch { get; set; }
	public virtual OrkUser? Regent { get; set; }
	public virtual OrkUser? Champion { get; set; }
	public virtual OrkUser? PrimeMinister { get; set; }
	public virtual OrkUser? GMR { get; set; }
	public virtual List<Event>? KingdomEvents { get; set; }
	[NotMapped]
	public virtual string KingdomSlug { get => Regex.Replace(KingdomName.ToLower(), @"\s", "-"); }
}