namespace AmtOrk.Server.Models;

public class Event : RootModel
{
	public string EventName { get; set; } = default!;
	public string EventLocation { get; set; } = default!; // Possibly add Google maps reference or coordinates
	public string EventDescription { get; set; } = default!;
	public DateTime EventStartDate { get; set; }
	public DateTime EventEndDate { get; set; }
}