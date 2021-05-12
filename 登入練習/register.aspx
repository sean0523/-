<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="登入練習.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/pic/SignUP_icon.png" />
    <br/>
    <br/>
    <asp:Label ID="Label1" runat="server" Text="使用者帳號"></asp:Label>
    <asp:TextBox ID="userID" runat="server"></asp:TextBox>
    <br/>

    <asp:Label ID="Label2" runat="server" Text="使用者密碼"></asp:Label>
    <asp:TextBox ID="userPWD" runat="server"></asp:TextBox>
    <br/>
    <br/>
    <asp:Button ID="new" runat="server" Text="註冊" OnClick="new_Click" />
    <asp:Button ID="cancel" runat="server" Text="取消" OnClick="cancel_Click" />
    </asp:Content>
