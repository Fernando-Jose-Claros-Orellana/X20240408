using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace X20240408.EntidadesDeNegocio
{
    public class PersonaX
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre")]
        public string NombreX { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "El apellido es requerido")]
        [Display(Name = "Apellido")]
        public string ApellidoX { get; set; }
        
        [Display(Name = "FechaNacimiento")]
        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime FechaNacimientoX { get; set; }
        
        [Display(Name = "Sueldo")]
        [Required(ErrorMessage = "El sueldo es requerido")]
        public decimal SueldoX {  get; set; }
       
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El estado es requerido")]
        public int StatusX { get; set; }
        
        [StringLength(60)]
        [Display(Name = "Comentario")]
        [Required(ErrorMessage = "El comentario es requerido")]
        public string ComentarioX {  get; set; }

    }
}
