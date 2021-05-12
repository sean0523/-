<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test1.aspx.cs" Inherits="登入練習.test1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br/>
    <br/>
    <br/>
    <asp:Button ID="Click" runat="server" Text="Button" OnClick="Click_Click" />
    <br/>
    <asp:Label ID="Message" runat="server" Text="Label"></asp:Label>
    <br/>    
    <asp:Image ID="Image1" runat="server" />
    </asp:Content>
