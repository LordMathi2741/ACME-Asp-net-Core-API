using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1._Aplication.Request;
using _2._Domain;
using _3._Infraestructure;
using _3._Infraestructure.models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1._Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialsController : ControllerBase
    {
        private ITutorialInfraestructure _tutorialData;
        private ITutorialDomain _tutorialDomain;
        private IMapper _mapper;
        public TutorialsController(ITutorialInfraestructure tutorialData, ITutorialDomain tutorialDomain)
        {
            _tutorialData = tutorialData;
            _tutorialDomain = tutorialDomain; //Inyect new instance of TutorialDomain
        } //Inyect new instance of TutorialInfraestructure
        
        // GET: api/Tutorials
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _tutorialData.getAll().Select(x => x.Name).ToList();
        }

        // GET: api/Tutorials/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tutorials
        [HttpPost]
        public Boolean Post([FromBody] TutorialRequest data)
        {
           
            var tutorial = _mapper.Map<Tutorial>(data);
            return _tutorialDomain.Save(tutorial);
        }

        // PUT: api/Tutorials/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tutorials/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
