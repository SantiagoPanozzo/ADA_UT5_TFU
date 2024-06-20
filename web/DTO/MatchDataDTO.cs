namespace web.Models;

public class MatchDataDTO
{
	public string Sport {get; set;}
	public string Discipline {get; set;}
	public int ParticipantCedula {get; set;}
	public string Data {get; set;}
	public int RefereeCedula {get; set;}

	public MatchDataDTO(string sport, string discipline, int participantCedula, string data, int refereeCedula)
	{
		Sport = sport;
		Discipline = discipline;
		ParticipantCedula = participantCedula;
		RefereeCedula = refereeCedula;
		Data = data;
	}

	public override string ToString()
	{
		return $"Sport: {Sport}, Discipline: {Discipline}, Participant: {ParticipantCedula}, Data: {Data}";
	}
}
