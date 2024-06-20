namespace web.Models;

public class MatchDataDTO
{
	public string _sport {get; set;}
	public string _discipline {get; set;}
	public string _participant {get; set;}
	public string _data {get; set;}

	public MatchDataDTO(string sport, string discipline, string participant, string data)
	{
		_sport = sport;
		_discipline = discipline;
		_participant = participant;
		_data = data;
	}
}
