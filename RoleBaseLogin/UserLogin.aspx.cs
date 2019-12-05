using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RoleBaseLogin
{
    public partial class UserLogin : System.Web.UI.Page
    {
        SqlConnection con = commonfun.connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCity();
            }
        }
        public void BindCity()
        {
            using (SqlCommand cmd = new SqlCommand("sp_GetCity", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet dst = new DataSet();
                dt.Fill(dst);
                ddlcity.DataSource = dst.Tables[0];
                ddlcity.DataTextField = "city";
                ddlcity.DataValueField = "cityid";
                ddlcity.DataBind();
                ddlcity.Items.Insert(0, new ListItem("---Select City---"));
            }
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            int RowCount;
            string User, Password, Cityid;
            using (SqlCommand cmd = new SqlCommand("sp_CheckUser", con))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    RowCount = dt.Rows.Count;
                    for (int i = 0; i < RowCount; i++)
                    {
                        User = dt.Rows[i]["UserName"].ToString();
                        Password = dt.Rows[i]["Password"].ToString();
                        Cityid = dt.Rows[i]["cityid"].ToString();
                        if (User == txtUser.Text && Password == txtpassword.Text)
                        {
                            Session["UserName"] = User;
                            if (dt.Rows[i]["Designationid"].ToString() == "1")
                                Response.Redirect("~/Roles/Manager.aspx");
                            else if (dt.Rows[i]["Designationid"].ToString() == "2")
                                Response.Redirect("~/Roles/HR.aspx");
                            else if (dt.Rows[i]["Designationid"].ToString() == "3")
                                Response.Redirect("~/Roles/Account.aspx");
                        }
                        else
                        {
                            lblmsg.Text = "UserName or Password Not Correct.....!";
                        }
                    }
                }
            }
        }
    }
}