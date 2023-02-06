using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCamPopup.Pages
{
    public partial class Search : System.Web.UI.Page
    {
        int id;
        public string conval = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string sql = "select top 1 Id,[Image] from storeimage where Id = @ImageID";
            if (txtID.Text != "")
            {
                int val = Convert.ToInt32(txtID.Text);
                using (SqlConnection conn = new SqlConnection(conval))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ImageID", val);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageData = (byte[])reader["Image"];
                                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                                {
                                    ms.Write(imageData, 0, imageData.Length);
                                    Image1.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(imageData);
                                }
                            }
                        }
                    }
                }
            }

        }
        /*private DataTable GetData(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(conval);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 Id,[Image] from storeimage where Id=@id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = 22;
            cmd.Connection = con;
            try
            {
                con.Open();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
                sda.Dispose();
                con.Dispose();
            }
        }*/
    }
}