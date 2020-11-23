using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=campusone;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into Users (username,password,type) " +
                "values(@UN, @PWD, 1)", sqlConnection);

            sqlCommand.Parameters.Add("@UN", SqlDbType.VarChar, 100).Value = RegUsername.Text;
            sqlCommand.Parameters.Add("@PWD", SqlDbType.VarChar, 100).Value = RegPassword.Text;

            sqlCommand.ExecuteNonQuery();

        } 
    }
}