using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace X20240408.EntidadesDeNegocio
{
    public class PersonaX
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Nombre")]
        public string NombreX { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Apellido")]
        public string ApellidoX { get; set; }
        [Required]
        [Display(Name = "FechaNacimiento")]
        public DateTime FechaNacimientoX { get; set; }
        [Required]
        [Display(Name = "Sueldo")]
        public decimal SueldoX {  get; set; }
        [Required]
        [Display(Name = "Estado")]
        public int StatusX { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Comentario")]
        public string ComentarioX {  get; set; }

    }
}
