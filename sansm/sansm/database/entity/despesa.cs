//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sansm.database.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class despesa
    {
        public int iddespesa { get; set; }
        public string tipo { get; set; }
        public string nmboleto { get; set; }
        public string nmproduto { get; set; }
        public string nmservico { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<System.DateTime> vencimento { get; set; }
        public Nullable<System.DateTime> registro { get; set; }
    }
}