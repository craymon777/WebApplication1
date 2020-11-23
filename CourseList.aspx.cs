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
    public partial class CourseList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //IspostBack return true when the page is loaded in response to postback
            //IsPostBack return true if it is not the 1st time loading the page.
            if(!IsPostBack)//enter only when it is 1st time loading the page(not postback).
                DataBindToGridView();
        }

        protected void DataBindToGridView()
        {
            SqlConnection conn = 
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=campusone;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from CourseList", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            
            adapter.Fill(ds);

            //to bind the gridview1 to the database 
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //NewEditIndex is The index of the row being edited.
            //So that the Gridview can show the editing view for the selected row
            GridView1.EditIndex = e.NewEditIndex;
            DataBindToGridView();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            DataBindToGridView();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //RowIndex is The index of the row being updated(same as GridView1.EditIndex)
            int row_index = e.RowIndex;
            SqlConnection conn =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=campusone;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Courses SET name=@NAME, code=@CODE, " +
                "lecturer=@LECTURER, venue=@VENUE, timeline=@TIME WHERE id=@ID", conn);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value =
                ((Label)GridView1.Rows[row_index].FindControl("lbID_edt")).Text;
            cmd.Parameters.Add("@NAME", SqlDbType.VarChar, 100).Value =
                ((TextBox)GridView1.Rows[row_index].FindControl("tbCourseName")).Text;
            cmd.Parameters.Add("@CODE", SqlDbType.VarChar, 100).Value =
                ((TextBox)GridView1.Rows[row_index].FindControl("tbCourseCode")).Text;
            cmd.Parameters.Add("@LECTURER", SqlDbType.VarChar, 100).Value =
                ((DropDownList)GridView1.Rows[row_index].FindControl("ddlLecturer")).SelectedValue;
            cmd.Parameters.Add("@VENUE", SqlDbType.VarChar, 100).Value =
                ((TextBox)GridView1.Rows[row_index].FindControl("tbVenue")).Text;
            cmd.Parameters.Add("@TIME", SqlDbType.VarChar, 100).Value =
                ((TextBox)GridView1.Rows[row_index].FindControl("tbTimeline")).Text;

            cmd.ExecuteNonQuery();
            conn.Close();

            //set the gridview back to no row is selecting for editing  
            GridView1.EditIndex = -1;
            DataBindToGridView();
        }


        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int row_index = e.RowIndex;
            SqlConnection conn =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=campusone;");
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM Courses WHERE id=@ID",conn);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value =
                ((Label)GridView1.Rows[row_index].FindControl("lbID")).Text;

            cmd.ExecuteNonQuery();

            DataBindToGridView();

        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            GridView1.ShowFooter = true;
            DataBindToGridView();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Insert")
            {
                SqlConnection conn =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=campusone;");
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Courses(name,code,lecturer," +
                    "venue,timeline) VALUES(@NAME, @CODE, @LECTURER, @VENUE, @TIME)", conn);
                cmd.Parameters.Add("@NAME", SqlDbType.VarChar, 100).Value =
                    ((TextBox)GridView1.FooterRow.FindControl("tbCourseName_foot")).Text;
                cmd.Parameters.Add("@CODE", SqlDbType.VarChar, 100).Value =
                    ((TextBox)GridView1.FooterRow.FindControl("tbCourseCode_foot")).Text;
                cmd.Parameters.Add("@LECTURER", SqlDbType.VarChar, 100).Value =
                    ((DropDownList)GridView1.FooterRow.FindControl("ddlLecturer_foot")).SelectedValue;
                cmd.Parameters.Add("@VENUE", SqlDbType.VarChar, 100).Value =
                    ((TextBox)GridView1.FooterRow.FindControl("tbVenue_foot")).Text;
                cmd.Parameters.Add("@TIME", SqlDbType.VarChar, 100).Value =
                    ((TextBox)GridView1.FooterRow.FindControl("tbTimeline_foot")).Text;

                cmd.ExecuteNonQuery();

                GridView1.ShowFooter = false;
                DataBindToGridView();

            }    
        }
    }
}