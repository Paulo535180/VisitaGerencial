using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitaGerencial.API.Models
{
    [Table("CVG_AREA_PARTICIPANTE")]
    public class AreaParticipante
    {
        [Key]
        public int id { get; set; }
        public int area { get; set; }
        public int participante { get; set; }
        public string gestor { get; set; }
        public DateTime data_criacao { get; set; }
        public string usuario_criacao { get; set; }
        public DateTime? data_alteracao { get; set; }
        public string? usuario_alteracao { get; set; }
        public string? status { get; set; }

    }
}