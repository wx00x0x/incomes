//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XXWx.Incoms.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CardBalance
    {
        public System.Guid CardId { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Balance { get; set; }
    
        public virtual Card Card { get; set; }
    }
}
