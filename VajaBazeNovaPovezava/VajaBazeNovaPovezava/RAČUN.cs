//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VajaBazeNovaPovezava
{
    using System;
    using System.Collections.Generic;
    
    public partial class RAČUN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RAČUN()
        {
            this.VRSTICA = new HashSet<VRSTICA>();
        }
    
        public int RAČ_ID { get; set; }
        public Nullable<int> KUP_KODA { get; set; }
        public Nullable<System.DateTime> RAČ_DATUM { get; set; }
    
        public virtual KUPEC KUPEC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VRSTICA> VRSTICA { get; set; }
    }
}
