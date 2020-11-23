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
    public partial class CourseSelect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] == null)
                Response.Redirect("Login.aspx?postBackUrl=CourseSelect");
                
        }

        protected void btnSelectAll_Click(object sender, EventArgs e)
        {
            for(int i=0; i<GridView1.Rows.Count; i++)
            {
                CheckBox checkBox = (CheckBox)GridView1.Rows[i].FindControl("chk");
                checkBox.Checked = true;
            }
        }

        protected void btnSelectNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox checkBox = (CheckBox)GridView1.Rows[i].FindControl("chk");
                checkBox.Checked = false;
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=campusone;");
            conn.Open();

            for(int i=0; i<GridView1.Rows.Count; i++)
            {
                CheckBox checkBox = (CheckBox)GridView1.Rows[i].FindControl("chk");
                if(checkBox.Checked)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Intake(course_id, student_id," +
                        "mark) VALUES(@CID, @SID, 0)", conn);
                    cmd.Parameters.Add("@CID", SqlDbType.VarChar, 100).Value =
                        ((Label)GridView1.Rows[i].FindControl("Label1")).Text;
                    cmd.Parameters.Add("@SID", SqlDbType.VarChar, 100).Value =
                        Session["userID"];

                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
    }
}