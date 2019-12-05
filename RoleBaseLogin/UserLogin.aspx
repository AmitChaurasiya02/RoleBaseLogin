<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="RoleBaseLogin.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Styles/site.css" rel="stylesheet" />  
  
<div class="page">  
    <h1 class="header" style="color: #FFFFFF"> Role Based Login Form Example</h1>  
<div>  
    <asp:Label runat="server" ID="lblmsg"></asp:Label>
    <div class="login">  
    <fieldset><legend>User Login</legend>  
       <asp:Table runat="server" >  
           <asp:TableRow>  
               <asp:TableCell>City</asp:TableCell><asp:TableCell><asp:DropDownList runat="server" ID="ddlcity" ></asp:DropDownList></asp:TableCell>  
           </asp:TableRow>  
           <asp:TableRow>  
               <asp:TableCell>UserName</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="txtUser"></asp:TextBox></asp:TableCell>  
           </asp:TableRow>  
           <asp:TableRow>  
               <asp:TableCell>Password</asp:TableCell><asp:TableCell><asp:TextBox runat="server" ID="txtpassword" TextMode="Password"></asp:TextBox></asp:TableCell>  
           </asp:TableRow>  
           <asp:TableRow>  
               <asp:TableCell></asp:TableCell><asp:TableCell><asp:Button runat="server" ID="btnlogin" Text="Login" OnClick="btnlogin_Click" /></asp:TableCell>  
           </asp:TableRow>  
       </asp:Table>  
    </fieldset>  
</div>  
    </div>  
</div>  
</asp:Content>
