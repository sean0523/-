<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="game.aspx.cs" Inherits="登入練習.遊戲介面" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/scissors.png" OnClick="buttomClick" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/stone.png" OnClick="buttomClick" />
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/paper.png" OnClick="buttomClick" />
    <asp:TextBox ID="userResult" runat="server"></asp:TextBox>
    </br>
    </br>
    <asp:ImageButton ID="computerImage" runat="server" ImageUrl="~/pic/paper.png" />
        <asp:TextBox ID="computerResult" runat="server"></asp:TextBox>

    </br>
    </br>
    <asp:Label ID="Label1" runat="server" Text="遊戲結果"></asp:Label>
    <asp:TextBox ID="final" runat="server"></asp:TextBox>
    <asp:Label ID="gameResult" runat="server" Text=""></asp:Label>
    </br>
    </br>
    <asp:Label ID="Label2" runat="server" Text="線上人數:"></asp:Label>
    </br>
    </br>
    </br>
    <asp:TextBox ID="inputText" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="SendBtn" runat="server" Text="送出訊息" OnClick="SendBtn_Click" />
    <asp:Button ID="Logout" runat="server" Text="登出" OnClick="Logout_Click" />
     </br>
    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="1000">
    </asp:Timer>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br>
            <br></br>
            <asp:Label ID="Label3" runat="server" Text="訊息資訊 :"></asp:Label>
            <br>
            <br></br>
            <asp:Label ID="chatResult" runat="server"></asp:Label>
            </br>
            </br>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick">
            </asp:AsyncPostBackTrigger>
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
