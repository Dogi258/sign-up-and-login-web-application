<%@ Page Title="" Language="C#" MasterPageFile="~/WebPages/Site1.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Assignment_4.WebPages.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" Text="User Login " CssClass="lblLarge" ID="lblUserLogin"></asp:Label>
    <asp:Label ID="lblUser" runat="server" Text="Username" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtUser" runat="server" CssClass="input"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUser" CssClass="valError" Display="Dynamic" ErrorMessage="Required"></asp:RequiredFieldValidator>
    <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" CssClass="valError" Display="Dynamic" ErrorMessage="Required"></asp:RequiredFieldValidator>
<br />
    <asp:Label ID="lblStatus" runat="server" CssClass="lblMed"></asp:Label>
<br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="input" OnClick="btnLogin_Click" />
    <br />
    <asp:Button ID="btnLogOut" runat="server" CssClass="input" OnClick="btnLogOut_Click" Text="Log Out" Visible="False" />
</asp:Content>
