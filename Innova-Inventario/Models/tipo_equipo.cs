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
    
    public partial class tipo_equipo
    {
        public tipo_equipo()
        {
            this.equipo = new HashSet<equipo>();
        }
    
        public int id_tipo { get; set; }
        public string descripcion { get; set; }
    
        public virtual ICollection<equipo> equipo { get; set; }
    }
}