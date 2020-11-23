using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;

namespace WebApplication1
{
    public partial class BatchRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if(upload.HasFile)
            {
                upload.SaveAs(Server.MapPath("`/files/batch.xml"));

                XmlDocument doc = new XmlDocument();

            }
        }
    }
}