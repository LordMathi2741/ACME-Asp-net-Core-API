using _3._Infraestructure.models;

namespace _3._Infraestructure;

public class TutorialOracle : ITutorialInfraestructure
{
    public bool Save(Tutorial data)
    {
        throw new NotImplementedException();
    }

    public bool Update(Tutorial data)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Tutorial> getAll()
    {
        var list = new List<Tutorial>();
        list.Add(new Tutorial { Id = 1, Name = "Tutorial 1 Oracle" });
        list.Add(new Tutorial { Id = 2, Name = "Tutorial 2 Oracle" });
        list.Add(new Tutorial { Id = 3, Name = "Tutorial 3 Oracle" });
        return list;
    }

    public Tutorial getbyId(int id)
    {
        throw new NotImplementedException();
    }
}