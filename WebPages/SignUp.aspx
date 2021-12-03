<%@ Page Title="" Language="C#" MasterPageFile="~/WebPages/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Assignment_4.WebPages.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblSignUp" runat="server" CssClass="lblLarge" Text="Sign Up"></asp:Label>
    <asp:Label ID="lblFirstName" runat="server" Text="First Name" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtFirstName" runat="server" CssClass="input"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" CssClass="valError" Display="Dynamic" ErrorMessage="Required"></asp:RequiredFieldValidator>
    <asp:Label ID="lblLastName" runat="server" Text="Last  Name" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtLastName" runat="server" CssClass="input"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" CssClass="valError" Display="Dynamic" ErrorMessage="Required"></asp:RequiredFieldValidator>
    <asp:Label ID="lblAddress" runat="server" Text="Address" CssClass="lblMed"></asp:Label>

    <asp:TextBox ID="txtAddress" runat="server" CssClass="input"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAddress" CssClass="valError" Display="Dynamic" ErrorMessage="Required"></asp:RequiredFieldValidator>
    <asp:Label ID="lblBirthDate" runat="server" Text="Birth Date" CssClass="lblMed"></asp:Label>

    <asp:TextBox ID="txtBirthDate" runat="server" CssClass="input" TextMode="Date"></asp:TextBox>
    <asp:Label ID="lblPhone" runat="server" Text="Phone" CssClass="lblMed"></asp:Label>

    <asp:TextBox ID="txtPhone" runat="server" CssClass="input"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtPhone" CssClass="valError" ErrorMessage="Must be at least a 10 digit number" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
    <asp:Label ID="lblUsername" runat="server" Text="User Name" CssClass="lblMed"></asp:Label>

    <asp:TextBox ID="txtUsername" runat="server" CssClass="input"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUsername" CssClass="valError" Display="Dynamic" ErrorMessage="Required"></asp:RequiredFieldValidator>
    <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="lblMed"></asp:Label>

    <asp:TextBox ID="txtPassword" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtPassword" CssClass="valError" Display="Dynamic" ErrorMessage="Must be at least 8 characters long and should contain at least one uppercase character, one digit, and one special character" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&amp;])[A-Za-z\d@$!%*#?&amp;]{8,}$"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblStatus" runat="server" CssClass="lblMed"></asp:Label>
    <br />
    <asp:Button ID="btnSignup" runat="server" CssClass="input" OnClick="btnSignup_Click" Text="Sign Up" />

</asp:Content>
