using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_4.WebPages
{
    public partial class SignUp : System.Web.UI.Page
    {
        SqlLogic logic = new SqlLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (logic.CheckUsername(txtUsername.Text))
            {
                lblStatus.Text = "Username is already taken";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if (logic.SignUp(txtUsername.Text, txtPassword.Text, txtLastName.Text, txtFirstName.Text, txtAddress.Text, txtBirthDate.Text, txtPhone.Text))
            {
                lblStatus.Text = "Succesfully created account!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatus.Text = "Account creation failed!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}