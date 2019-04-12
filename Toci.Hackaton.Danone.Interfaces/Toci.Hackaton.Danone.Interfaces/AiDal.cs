// <copyright file="AiDal.cs" company="Rolls-Royce plc">
//   Copyright (c) 2019 Rolls-Royce plc
// </copyright>

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime;

namespace Toci.Hackaton.Danone.Interfaces
{
    public class AiDal
    {
        public List<string> Tables = new List<string>()
        {
            "recipe_0_processing_details_slurry",
            "recipe_0_processing_details_dd"
        };

        public Dictionary<string, object> Results = new Dictionary<string, object>();
        public virtual Dictionary<string, object> GetAggregations()
        {
            hackathon_danoneEntities ent = new hackathon_danoneEntities();

            foreach (string table in Tables)
            {
                Results.Add(table, ent.recipe_0_orders_details.Include(table));
            }

            return Results;
        }

        
    }
}