using _3._Infraestructure.models;

namespace _2._Domain;

public interface ITutorialDomain
{
    Boolean Save(Tutorial data);
    Boolean Update(Tutorial data);
    Boolean Delete(int id);
}