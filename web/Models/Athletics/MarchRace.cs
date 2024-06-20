using web.Interfaces;
using web.Interfaces.Disciplines;

namespace web.Models.Athletics;

public class MarchRace : AbstractHandler, IDiscipline, IAthletics
{
    private string _name = "March Race";
    public string Name {get => _name; set => _name = value;}
    
    public override object Handle(object request) {
        return Calculate(request);
    }
    
    public double Calculate(object request) {
        MatchDataDTO data = (MatchDataDTO)request;
        return 2;
    }
}