using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_ML_Data.Models
{
    public class M_item
    {
       
            public Guid? Item_ID { get; set; }
            public string Item_Code { get; set; }
            public string Item_Name { get; set; }
            public string Item_Type { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public string Remark { get; set; }
            public Guid Created_By { get; set; }
            public DateTime Created_On { get; set; }
            public string Created_By_Name { get; set; } // optional for view
            public Guid Modified_By { get; set; }
            public DateTime Modified_On { get; set; }
            public string Modified_By_Name { get; set; } // optional for view
            public bool Active { get; set; }
        

    }
}
