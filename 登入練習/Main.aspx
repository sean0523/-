<%@ Page Title="登入畫面" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="登入練習.登入畫面" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <asp:Image ID="Image1" runat="server" Height="206px" ImageUrl="~/pic/background.jpg" Width="248px" />
    <br/>
    &nbsp;
    <asp:Label ID="Label1" runat="server" Text="使用者帳號" ></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="user" runat="server" Width="125px" ></asp:TextBox>
    &nbsp;&nbsp;
    <asp:Label ID="UserText" runat="server" Text=""></asp:Label>
    <br/>
    <br/>
    &nbsp;
    <asp:Label ID="Label2" runat="server" Text="使用者密碼" ></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="PWD" runat="server" Width="125px" ></asp:TextBox>
    &nbsp;&nbsp;
    <asp:Label ID="PWDText" runat="server" Text=""></asp:Label>
    <br/>
    <br/>
    &nbsp;
    <asp:Label ID="Label3" runat="server" Text="姓名"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="name" runat="server" Width="125px"></asp:TextBox>
    <br/>
    <br/>
    <br/>
    &nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登入" Height="37px" Width="120px" />

    <asp:Button ID="register" runat="server" Text="註冊" Height="37px" Width="120px" OnClick="register_Click" />
    <br/>

</asp:Content>
