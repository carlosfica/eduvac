//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntregaTress.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ENVIOCODIGOQR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENVIOCODIGOQR()
        {
            this.QRENTRADA = new HashSet<QRENTRADA>();
        }
    
        public int cod_codigo { get; set; }
        public int fk_alumno { get; set; }
        public Nullable<System.DateTime> fecha_envio { get; set; }
    
        public virtual ALUMNOS ALUMNOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QRENTRADA> QRENTRADA { get; set; }
    }
}
