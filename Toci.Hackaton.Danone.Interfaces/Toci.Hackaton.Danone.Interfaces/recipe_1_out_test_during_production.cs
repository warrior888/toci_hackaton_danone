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
    
    public partial class recipe_1_out_test_during_production
    {
        public int orders_details_id { get; set; }
        public string line_dd { get; set; }
        public Nullable<double> process_order { get; set; }
        public System.DateTime testing_time { get; set; }
        public Nullable<double> moisture { get; set; }
        public string bulk_density { get; set; }
    
        public virtual recipe_1_orders_details recipe_1_orders_details { get; set; }
    }
}
