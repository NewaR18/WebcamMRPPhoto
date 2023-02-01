using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation.DLL
{
    public class DLL
    {
        public string conval = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public string InsertImage(string data)
        {
            byte[] imageBytes = Convert.FromBase64String(data.Split(',')[1]);
            SqlConnection con = new SqlConnection(conval);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertimageonly";
                cmd.Parameters.Add("@img", SqlDbType.Image).Value = imageBytes;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return "success";
        }
    }
}
