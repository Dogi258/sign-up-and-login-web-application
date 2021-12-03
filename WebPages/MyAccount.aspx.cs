using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4.WebPages
{
    public partial class MyAccount : System.Web.UI.Page
    {
        SqlLogic logic = new SqlLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["user"] == null)
            {
                theDiv.Visible = false;
                lblStatus.Text = "You must login to see account details!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if ((String)Session["user"] != null)
            {
                string[] user = logic.GetLoginInfo((String)Session["user"]);
                lblUsername.Text = user[0];
                lblPassword.Text = user[1];
                lblLastName.Text = user[2];
                lblFirstName.Text = user[3];
                lblAddress.Text = user[4];
                lblDOB.Text = user[5];
                lblPhone.Text = user[6];
            }
            
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(logic.UpdatePassword((String)Session["user"], txtUpdatePassword.Text))
            {
                lblStatus.Text = "Update Succefull!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblPassword.Text = txtUpdatePassword.Text;
            }
            else
            {
                lblStatus.Text = "Update Failed";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnUpdateFirstName_Click(object sender, EventArgs e)
        {
            if (logic.UpdateFirstName((String)Session["user"], txtUpdateFirstName.Text))
            {
                lblStatus.Text = "Update Succefull!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblFirstName.Text = txtUpdateFirstName.Text;
            }
            else
            {
                lblStatus.Text = "Update Failed";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnUpdateLastName_Click(object sender, EventArgs e)
        {
            if (logic.UpdateLastName((String)Session["user"], txtUpdateLastName.Text))
            {
                lblStatus.Text = "Update Succefull!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblLastName.Text = txtUpdateLastName.Text;
            }
            else
            {
                lblStatus.Text = "Update Failed";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            if (logic.UpdateAddress((String)Session["user"], txtUpdateAddress.Text))
            {
                lblStatus.Text = "Update Succefull!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblAddress.Text = txtUpdateAddress.Text;
            }
            else
            {
                lblStatus.Text = "Update Failed";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnUpdateDOB_Click(object sender, EventArgs e)
        {
            if (logic.UpdateDOB((String)Session["user"], txtUpdateDOB.Text))
            {
                lblStatus.Text = "Update Succefull!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblDOB.Text = txtUpdateDOB.Text;
            }
            else
            {
                lblStatus.Text = "Update Failed";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            if (logic.UpdatePhone((String)Session["user"], txtUpdatePhone.Text))
            {
                lblStatus.Text = "Update Succefull!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblPhone.Text = txtUpdatePhone.Text;
            }
            else
            {
                lblStatus.Text = "Update Failed";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}