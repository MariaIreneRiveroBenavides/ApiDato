using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatoApi.Models
{
    public class Dato
    {
        [Key]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="La edad es requerida")]
        [Display(Name ="Edad")]
        public int Edad { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name ="Correo electronico")]
        public string Email { get; set; }
        [Display(Name ="Pelicula favorita")]
        public string Pelicula { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 3, ErrorMessage ="La cancion debe tener entre 2 y 40 caracteres")]
        [Display(Name ="Nombre de cancion favorita")]
        public string Cancion { get; set; }
        [Required]
        [Url]
        [Display(Name ="Enlace de youtube de la cancion")]
        public string Enlace { get; set; }
    }
}
