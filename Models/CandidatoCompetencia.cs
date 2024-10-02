using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class CandidatoCompetencia
    {
        [Key]
        public int CandidatoCompetenciaID { get; set; }

        [ForeignKey("Candidato")]
        public int CandidatoID { get; set; }

        [ForeignKey("Competencia")]
        public int CompetenciaID { get; set; }

        public Candidato Candidato { get; set; }
        public Competencias Competencia { get; set; }
    }
}
