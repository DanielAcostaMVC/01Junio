//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApuestasPolla.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partido
    {
        public Partido()
        {
            this.ApuestaPartido = new HashSet<ApuestaPartido>();
            this.EquipoPartido = new HashSet<EquipoPartido>();
        }
    
        public int IdPartido { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdFase { get; set; }
    
        public virtual ICollection<ApuestaPartido> ApuestaPartido { get; set; }
        public virtual ICollection<EquipoPartido> EquipoPartido { get; set; }
        public virtual FasePartido FasePartido { get; set; }
    }
}
