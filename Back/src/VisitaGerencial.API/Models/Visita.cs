using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitaGerencial.API.Models;

[Table("CVG_VISITA")]
public class Visita
{
    // public Visita(string usuario_criacao, string nome_responsavel, string usuario_alteracao)

    // {
    //     USUARIO_CRIACAO = usuario_criacao;
    //     NOME_RESPONSAVEL = nome_responsavel;
    //     USUARIO_ALTERACAO = usuario_alteracao;
    // }
    [Key]
    public int id { get; set; }
    public int? numero { get; set; }
    public int area { get; set; }
    public EnumStatusVisita status { get; set; }
    public DateTime data_ini { get; set; }
    public DateTime data_fim { get; set; }
    public string? local_inicial { get; set; }
    public string? local_final { get; set; }
    public string? relatorio_final { get; set; }
    public string? motivo_cancelamento { get; set; }
    public DateTime data_criacao { get; set; }
    public string usuario_criacao { get; set; }
    public DateTime? data_alteracao { get; set; }
    public string? usuario_alteracao { get; set; }
    public string? nome_responsavel { get; set; }
}

public enum EnumStatusVisita
{
    AGENDADA = 1,
    CONFIRMADA = 2,
    CANCELADA = 3,
    REALIZADA = 4
}

