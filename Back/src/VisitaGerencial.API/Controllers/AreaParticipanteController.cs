using Microsoft.AspNetCore.Mvc;
using VisitaGerencial.API.Data;
using VisitaGerencial.API.Models;

namespace VisitaGerencial.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AreaParticipanteController
    {
        private readonly DataContext _dataContext;

        public AreaParticipanteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("")]
        public IEnumerable<AreaParticipante> Get()
        {
            return _dataContext.CVG_AREA_PARTICIPANTE;
        }

        [HttpGet("{id}")]
        public IEnumerable<AreaParticipante> GetById(int id)
        {
            return _dataContext.CVG_AREA_PARTICIPANTE.Where(areaParticipante => areaParticipante.id == id);
        }
    }
}