//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.Hackaton.Danone.Interfaces
{
    using System;
    using System.Collections.Generic;
    
    public partial class recipe_0_raw_material_used
    {
        public int id { get; set; }
        public int material_code_2 { get; set; }
        public int process_order_sap3 { get; set; }
        public Nullable<double> usage_pct { get; set; }
    
        public virtual recipe_0_orders_details recipe_0_orders_details { get; set; }
    }
}
