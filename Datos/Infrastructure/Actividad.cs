//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actividad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actividad()
        {
            this.Usuario_Actividad = new HashSet<Usuario_Actividad>();
        }
    
        public int Id_Actividad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string DNI_Monitor { get; set; }
        public Nullable<byte> Media_Valoracion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario_Actividad> Usuario_Actividad { get; set; }
        public virtual Monitor Monitor { get; set; }
    }
}
