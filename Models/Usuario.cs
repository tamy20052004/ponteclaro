using System.ComponentModel.DataAnnotations;

namespace RsystemWeb.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Rol { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int? EmpleadoID { get; set; }

        public int? CandidatoID { get; set; }

        [Required]
        [StringLength(20)]
        public string TipoUsuario { get; set; }
    }
}
