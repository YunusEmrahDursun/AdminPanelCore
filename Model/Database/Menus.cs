//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menus
    {
        public long ID { get; set; }
        public long Tablo { get; set; }
        public string Sıra { get; set; }
    
        public virtual Tablolars Tablolars { get; set; }
    }
}