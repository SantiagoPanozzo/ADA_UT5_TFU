using web.Interfaces;
using web.Interfaces.Disciplines;
using web.Models.Athletics;

namespace web.Models;

public class AthleticsFactory : AbstractHandler, ISportFactory<IAthletics>
{
    private static AthleticsFactory _instance {get; set;}
    
    private AthleticsFactory(){}

    public static AthleticsFactory GetInstance()
    {
        return _instance ??= new AthleticsFactory();
    }

    public override object Handle(object request)
    {
        return CreateDisciplines();
    }

    public List<IAthletics> CreateDisciplines()
    {
        IAthletics speedRace = new SpeedRace();
        IAthletics batonRace = new BatonRace();
        IAthletics fenceRace = new FenceRace();
        IAthletics marchRace = new MarchRace();
        List<IAthletics> res = new List<IAthletics>{speedRace, batonRace, fenceRace, marchRace};
        return res;
    }
}