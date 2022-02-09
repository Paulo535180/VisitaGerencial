using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitaGerencial.API.Models
{
    [Table("CVG_ACESSO_SISTEMA")]
    public class AcessoSistema
    {
        [Key]
        public int id { get; set; }
        public string sistema { get; set; }
        public string perfil { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
    }
}