<%@ Page Title="" Language="C#" MasterPageFile="~/WebPages/Site1.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="Assignment_4.WebPages.MyAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server" id="theDiv">
    <asp:Label ID="lblMyAccount" runat="server" Text="My Acount" CssClass="lblLarge"></asp:Label>
    <asp:Label ID="lblUsername0" runat="server" CssClass="lblMed">User Name:</asp:Label>
    <asp:Label ID="lblUsername" runat="server" CssClass="lblMed" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="lblPassword0" runat="server" CssClass="lblMed">Password:</asp:Label>
    <asp:Label ID="lblPassword" runat="server" CssClass="lblMed" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="lblFirstName0" runat="server" CssClass="lblMed">First Name:</asp:Label>
    <asp:Label ID="lblFirstName" runat="server" CssClass="lblMed" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="lblLastName0" runat="server" CssClass="lblMed">Last Name:</asp:Label>
    <asp:Label ID="lblLastName" runat="server" CssClass="lblMed" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="lblAddress0" runat="server" CssClass="lblMed">Address:</asp:Label>
    <asp:Label ID="lblAddress" runat="server" CssClass="lblMed" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="lblDOB0" runat="server" CssClass="lblMed">Date of Birth:</asp:Label>
    <asp:Label ID="lblDOB" runat="server" CssClass="lblMed" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="lblPhone0" runat="server" CssClass="lblMed">Phone:</asp:Label>
    <asp:Label ID="lblPhone" runat="server" CssClass="lblMed" ForeColor="#0000CC"></asp:Label>
    <asp:Label ID="lblUpdateDetails" runat="server" Text="Update Account Details" CssClass="lblLarge"></asp:Label>
    <asp:Label ID="Label1" runat="server" Text="Password" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtUpdatePassword" runat="server" CssClass="input"></asp:TextBox>
    <asp:Button ID="btnUpdatePassword" runat="server" Text="Update" CssClass="input" OnClick="btnUpdatePassword_Click" />
    <asp:Label ID="Label2" runat="server" Text="First Name" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtUpdateFirstName" runat="server" CssClass="input"></asp:TextBox>
    <asp:Button ID="btnUpdateFirstName" runat="server" Text="Update" CssClass="input" OnClick="btnUpdateFirstName_Click" />
    <asp:Label ID="Label3" runat="server" Text="Last Name" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtUpdateLastName" runat="server" CssClass="input"></asp:TextBox>
    <asp:Button ID="btnUpdateLastName" runat="server" Text="Update" CssClass="input" OnClick="btnUpdateLastName_Click" />
    <asp:Label ID="Label4" runat="server" Text="Address" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtUpdateAddress" runat="server" CssClass="input"></asp:TextBox>
    <asp:Button ID="btnUpdateAddress" runat="server" Text="Update" CssClass="input" OnClick="btnUpdateAddress_Click" />
    <asp:Label ID="Label5" runat="server" Text="Birth Date" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtUpdateDOB" runat="server" CssClass="input"></asp:TextBox>
    <asp:Button ID="btnUpdateDOB" runat="server" Text="Update" CssClass="input" OnClick="btnUpdateDOB_Click" />
    <asp:Label ID="Label6" runat="server" Text="Phone" CssClass="lblMed"></asp:Label>
    <asp:TextBox ID="txtUpdatePhone" runat="server" CssClass="input"></asp:TextBox>
    <asp:Button ID="btnUpdatePhone" runat="server" Text="Update" CssClass="input" OnClick="btnUpdatePhone_Click" />
    </div>
    <asp:Label ID="lblStatus" runat="server" CssClass="lblMed"></asp:Label>
    
</asp:Content>
