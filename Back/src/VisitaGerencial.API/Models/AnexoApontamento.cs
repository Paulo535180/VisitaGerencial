using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisitaGerencial.API.Models
{
    [Table("CVG_ANEXO_APONTAMENTO")]
    public class AnexoApontamento
    {
        [Key]
        public int id { get; set; }
        public int apontamento { get; set; }
        public string data_file { get; set; }
        public string file_name { get; set; }
        public string extension { get; set; }
        public string usuario_criacao { get; set; }
        public DateTime data_criacao { get; set; }
        public string? usuario_alteracao { get; set; }
        public DateTime? data_alteracao { get; set; }
        public string? tamanho { get; set; }
        

    }
}