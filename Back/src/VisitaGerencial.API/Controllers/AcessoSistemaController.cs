using Microsoft.AspNetCore.Mvc;
using VisitaGerencial.API.Data;
using VisitaGerencial.API.Models;

namespace VisitaGerencial.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcessoSistemaController
    {
    private readonly DataContext _dataContext;

    public AcessoSistemaController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet("")]
    public IEnumerable<AcessoSistema> Get(){
        return _dataContext.CVG_ACESSO_SISTEMA;    
    }

    [HttpGet("{id}")]
    public IEnumerable<AcessoSistema> GetById(int id){
        return _dataContext.CVG_ACESSO_SISTEMA.Where(acesso => acesso.id == id);
    }
    }
}