using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;

namespace WebCamPopup.Pages
{
    public partial class Base : System.Web.UI.Page
    {
        /*public string conval = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ImageID"] != null)

            {


                SqlCommand cmd = new SqlCommand();

                DataTable dt = GetData(cmd);

                if (dt != null)

                {

                    Byte[] bytes = (Byte[])dt.Rows[0]["image"];

                    Response.Buffer = true;

                    Response.Charset = "";

                    Response.Cache.SetCacheability(HttpCacheability.NoCache);


                    Response.AddHeader("content-disposition", "attachment;filename=" + dt.Rows[0]["Id"].ToString());

                    Response.BinaryWrite(bytes);

                    Response.Flush();

                    Response.End();

                }
            }
        }
        private DataTable GetData(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(conval);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 Id,[Image] from storeimage order by Id desc";
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