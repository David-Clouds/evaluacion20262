using System.ComponentModel.DataAnnotations;

namespace TecnoGas.Web.Models
{
    public class SolicitudServicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio")]
        [Display(Name = "Cliente")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El distrito es obligatorio")]
        [Display(Name = "Distrito")]
        public string Distrito { get; set; }

        [Required(ErrorMessage = "Selecciona el tipo de servicio")]
        [Display(Name = "Tipo de servicio")]
        public string TipoServicio { get; set; } // Instalación, Mantenimiento, Revisión, Fuga

        [Display(Name = "Descripción")]
        public string? Descripcion { get; set; }

        [Display(Name = "Fecha de registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}