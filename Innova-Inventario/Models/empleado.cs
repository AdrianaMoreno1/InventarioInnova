//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Innova_Inventario.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class empleado
    {
        public empleado()
        {
            this.asignacion = new HashSet<asignacion>();
        }
    
        public int id_empleado { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int no_empleado { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string apellidos { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string puesto { get; set; }
    
        public virtual ICollection<asignacion> asignacion { get; set; }
        public virtual usuarios usuarios { get; set; }
    }
}
