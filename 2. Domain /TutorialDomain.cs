using _3._Infraestructure.models;

namespace _2._Domain;

public class TutorialDomain: ITutorialDomain
{
    public bool Save(Tutorial data)
    {
        if (data.Name.Contains('a'))
        {
            throw new Exception("Contains a");
        }
        return true;
    }

    public bool Update(Tutorial data)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}