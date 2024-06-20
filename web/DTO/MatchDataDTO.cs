namespace web.Models;

public class MatchDataDTO
{
	public string Sport {get; set;}
	public string Discipline {get; set;}
	public string Participant {get; set;}
	public string Data {get; set;}

	public MatchDataDTO(string sport, string discipline, string participant, string data)
	{
		Sport = sport;
		Discipline = discipline;
		Participant = participant;
		Data = data;
	}

	public override string ToString()
	{
		return $"Sport: {Sport}, Discipline: {Discipline}, Participant: {Participant}, Data: {Data}";
	}
}
