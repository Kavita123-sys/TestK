using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApplication1.Models
{
    public class ProductModel
    {
        public int Product_Id { get; set; }
        public string Product_name { get; set; }
        public DateTime Product_mfg_date { get; set; }
        public Decimal Product_cost { get; set; }
        public string createBy { get; set; }
        public DateTime createDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public char IsActive { get; set; }
    }
}