using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitaGerencial.API.Models;

[Table("CVG_AREA")]
public class Area
{
    [Key]
    public int id { get; set; }
    public string nome { get; set; }
    public string calendario { get; set; }
    public string ativo { get; set; }
    public DateTime data_criacao { get; set; }
    public string usuario_criacao { get; set; }
    public DateTime? data_alteracao { get; set; }
    public string? usuario_alteracao { get; set; }
    public int tp_origem { get; set; }

}
