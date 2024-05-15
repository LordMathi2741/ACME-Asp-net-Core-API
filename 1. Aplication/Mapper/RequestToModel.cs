using _1._Aplication.Request;
using _3._Infraestructure.models;
using AutoMapper;

namespace _1._Aplication.Mapper;

public class RequestToModel : Profile
{
    public RequestToModel()
    {
        CreateMap<TutorialRequest, Tutorial>();
    }
}