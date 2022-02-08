using System.ComponentModel.DataAnnotations;

namespace VisitaGerencial.API.Models;

public class Visita
{
    // public Visita(string usuario_criacao, string nome_responsavel, string usuario_alteracao)
    // {
    //     USUARIO_CRIACAO = usuario_criacao;
    //     NOME_RESPONSAVEL = nome_responsavel;
    //     USUARIO_ALTERACAO = usuario_alteracao;
    // }
    public int ID { get; set; }
    public int? NUMERO { get; set; }
    public int AREA { get; set; }
    public EnumStatusVisita STATUS { get; set; }
    public DateTime DATA_INI { get; set; }
    public DateTime DATA_FIM { get; set; }
    public string? LOCAL_INICIAL { get; set; }
    public string? LOCAL_FINAL { get; set; }
    public string? RELATORIO_FINAL { get; set; }
    public string? MOTIVO_CANCELAMENTO { get; set; }
    public DateTime DATA_CRIACAO { get; set; }
    public string USUARIO_CRIACAO { get; set; }    
    public DateTime DATA_ALTERACAO { get; set; }
    public string USUARIO_ALTERACAO { get; set; }
    public string NOME_RESPONSAVEL { get; set; }
}

public enum EnumStatusVisita
{
    AGENDADA = 1,
    CONFIRMADA = 2,
    CANCELADA = 3,
    REALIZADA = 4
}

