using Microsoft.AspNetCore.Mvc;
using VisitaGerencial.API.Data;
using VisitaGerencial.API.Models;

namespace VisitaGerencial.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AreaController : ControllerBase
{
    private readonly DataContext _dataContext;

    public AreaController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }


    [HttpGet("")]
    public IEnumerable<Area> Get(){
        return _dataContext.CVG_AREA;    
    }

     [HttpGet("{id}")]
    public IEnumerable<Area> GetById(int id){
        return _dataContext.CVG_AREA.Where(area => area.id == id);    
    }
}
