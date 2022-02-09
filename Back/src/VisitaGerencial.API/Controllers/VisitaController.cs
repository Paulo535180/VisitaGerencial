using Microsoft.AspNetCore.Mvc;
using VisitaGerencial.API.Data;
using VisitaGerencial.API.Models;

namespace VisitaGerencial.API.Controllers;

[ApiController]
[Route("[controller]")]
public class VisitaController : ControllerBase
{
    private readonly DataContext _dataContext;
    public VisitaController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet("")]
    public IEnumerable<Visita> Get()
    {
        return _dataContext.CVG_VISITA;
    }

    [HttpGet("{id}")]
    public IEnumerable<Visita> GetById(int id)
    {
        return _dataContext.CVG_VISITA.Where(visita => visita.id == id);
    }
}
