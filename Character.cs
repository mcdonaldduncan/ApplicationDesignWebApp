//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationDesignWebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Character
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Character()
        {
            this.Maps = new HashSet<Map>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Element_Type { get; set; }
        public string Job_Class { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int Mana { get; set; }
        public int HP_Initial { get; set; }
        public int HP_Max { get; set; }
        public bool NPC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Map> Maps { get; set; }
    }
}
