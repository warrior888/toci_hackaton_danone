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
    
    public partial class recipe_0_out_semi_finished_production
    {
        public int orders_details_id { get; set; }
        public int bigbag_number { get; set; }
        public Nullable<System.DateTime> bigbag_filling_time_end { get; set; }
        public Nullable<double> bigbag_filling_duration { get; set; }
        public Nullable<double> bigbag_weight { get; set; }
        public Nullable<double> efficiency { get; set; }
        public string @class { get; set; }
    
        public virtual recipe_0_orders_details recipe_0_orders_details { get; set; }
    }
}
