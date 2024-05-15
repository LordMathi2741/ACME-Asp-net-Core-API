using _1._Aplication.Request;
using _3._Infraestructure.models;
using AutoMapper;

namespace _1._Aplication.Mapper;

public class ModelToRequest : Profile
{
   public ModelToRequest()
   {
      CreateMap<Tutorial, TutorialRequest>();
   }
}