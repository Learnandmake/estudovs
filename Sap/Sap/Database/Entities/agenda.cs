//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sap.Database.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class agenda
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public System.DateTime dt { get; set; }
        public System.DateTime registro { get; set; }
        public string nick { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}