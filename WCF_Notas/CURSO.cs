//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Notas
{
    using System;
    using System.Collections.Generic;
    
    public partial class CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CURSO()
        {
            this.MATRICULA_CURSO = new HashSet<MATRICULA_CURSO>();
            this.PROFESOR_CURSO = new HashSet<PROFESOR_CURSO>();
        }
    
        public int id_curso { get; set; }
        public string nombre { get; set; }
        public Nullable<int> credito { get; set; }
        public Nullable<int> id_sede { get; set; }
    
        public virtual SEDE SEDE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATRICULA_CURSO> MATRICULA_CURSO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROFESOR_CURSO> PROFESOR_CURSO { get; set; }
    }
}
