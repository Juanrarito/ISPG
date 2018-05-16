//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proyecto
    {
        public Proyecto()
        {
            this.Anteproyecto = new HashSet<Anteproyecto>();
            this.InformeTecnico = new HashSet<InformeTecnico>();
            this.BancoProyecto = new HashSet<BancoProyecto>();
            this.Residencia = new HashSet<Residencia>();
            this.TitulacionTesis = new HashSet<TitulacionTesis>();
            this.TitulacionProyecto = new HashSet<TitulacionProyecto>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Ambito { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }
    
        public virtual ICollection<Anteproyecto> Anteproyecto { get; set; }
        public virtual ICollection<InformeTecnico> InformeTecnico { get; set; }
        public virtual ICollection<BancoProyecto> BancoProyecto { get; set; }
        public virtual ICollection<Residencia> Residencia { get; set; }
        public virtual ICollection<TitulacionTesis> TitulacionTesis { get; set; }
        public virtual ICollection<TitulacionProyecto> TitulacionProyecto { get; set; }
    }
}