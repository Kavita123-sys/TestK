using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApiApplication1.Models;

namespace WebApiApplication1.Repository
{
    public class ProductRepository
    {
        int i;
        public int CreateProduct(ProductModel ProductModel)
        {
            try
            {
                String MyData = "Data Source=DESKTOP-UE4FHFH;Initial Catalog=MangoDB;Integrated Security= SSPI;";
                SqlConnection con = new SqlConnection(MyData);
                SqlCommand cmd = new SqlCommand("sp_all_ProductDeatails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@Product_name", ProductModel.Product_name);
                cmd.Parameters.AddWithValue("@Product_mfg_date", ProductModel.Product_mfg_date);
                cmd.Parameters.AddWithValue("@Product_cost", ProductModel.Product_cost);
                cmd.Parameters.AddWithValue("@createBy", ProductModel.@createBy);
                cmd.Parameters.AddWithValue("@IsActive", "Y");
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
