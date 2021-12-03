using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Assignment_4.WebPages
{
    public partial class LogIn : System.Web.UI.Page
    {
        SqlLogic logic = new SqlLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if ((string)Session["user"] != null)
            {
                lblUserLogin.Visible = false;
                lblUser.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                txtUser.Visible = false;
                lblStatus.Text = "Log In Successful!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                btnLogin.Visible = false;
                btnLogOut.Visible = true;
                Session["user"] = txtUser.Text;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (logic.GetLogin(txtUser.Text, txtPassword.Text))
            {
                lblUserLogin.Visible = false;
                lblUser.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                txtUser.Visible = false;
                lblStatus.Text = "Log In Successful!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                btnLogin.Visible = false;
                btnLogOut.Visible = true;
                Session["user"] = txtUser.Text;
            }
            else
            {
                lblStatus.Text = "Invalid Login Credentials";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            lblUserLogin.Visible = true;
            lblUser.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            txtUser.Visible = true;
            lblStatus.Text = "Logged Out";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            btnLogOut.Visible = false;
            btnLogin.Visible = true;
            Session["user"] = null;
        }
    }
}