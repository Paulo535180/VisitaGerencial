using Microsoft.AspNetCore.Mvc;
using VisitaGerencial.API.Models;

namespace VisitaGerencial.API.Controllers;

[ApiController]
[Route("[controller]")]
public class VisitaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var visita = new Visita();
        visita.ID = 1;
        visita.NUMERO = 1;
        visita.AREA = 110;
        visita.STATUS = EnumStatusVisita.REALIZADA;
        visita.DATA_INI = DateTime.Now;
        visita.DATA_FIM = DateTime.Today;
        visita.LOCAL_INICIAL = "no proprio setor";
        visita.LOCAL_FINAL = "";
        visita.RELATORIO_FINAL = "0";
        visita.DATA_CRIACAO = DateTime.Now;
        visita.USUARIO_CRIACAO = "Lucassd";
        visita.NOME_RESPONSAVEL = "Cel.Daniel";
        return Ok(visita);
    }
}
