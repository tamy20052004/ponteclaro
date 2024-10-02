using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class CandidatoCapacitacion
    {
        [Key]
        public int CandidatoCapacitacionID { get; set; }

        [ForeignKey("Candidato")]
        public int CandidatoID { get; set; }

        [ForeignKey("Capacitacion")]
        public int CapacitacionID { get; set; }

        public Candidato Candidato { get; set; }
        public Capacitacion Capacitacion { get; set; }
    }
}
