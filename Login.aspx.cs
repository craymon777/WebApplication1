using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=campusone;");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Users where username = @UN and " +
                "password = @PWD",sqlConnection);

            cmd.Parameters.Add("@UN", SqlDbType.VarChar, 100).Value = Username.Text;
            cmd.Parameters.Add("@PWD", SqlDbType.VarChar, 100).Value = Password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            if(ds.Tables[0].Rows.Count == 0)
            {
                Result.Text = "Fail";
                Result.ForeColor = Color.Red;
            }
            else
            {
                Session["username"] = Username.Text;
                Session["userID"] = ds.Tables[0].Rows[0][0];

                if (Request["postBackUrl"] == null)
                    Response.Redirect("HomePage.aspx");
                else
                    Response.Redirect(Request["postBackUrl"] + ".aspx");
            }
        }
    }
}