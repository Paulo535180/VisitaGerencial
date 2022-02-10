using Microsoft.AspNetCore.Mvc;
using VisitaGerencial.API.Data;
using VisitaGerencial.API.Models;

namespace VisitaGerencial.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnexoApontamentoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public AnexoApontamentoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("")]
        public IEnumerable<AnexoApontamento> Get()
        {
            return _dataContext.CVG_ANEXO_APONTAMENTO;
        }

        [HttpGet("{id}")]
        public IEnumerable<AnexoApontamento> GetById(int id)
        {
            return _dataContext.CVG_ANEXO_APONTAMENTO.Where(anexo => anexo.id == id);
        }

    }
}