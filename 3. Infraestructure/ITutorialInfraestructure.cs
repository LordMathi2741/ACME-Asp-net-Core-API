using _3._Infraestructure.models;

namespace _3._Infraestructure;

public interface ITutorialInfraestructure
{
    Boolean Save(Tutorial data);
    Boolean Update(Tutorial data);
    Boolean Delete(int id);
    List<Tutorial> getAll();
    Tutorial getbyId(int id);
}