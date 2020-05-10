<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WeatherApp._Default" %>




<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
   
    <div id="input">
        <asp:Label ID="LabelIn" runat="server" Text="Enter City Name: "></asp:Label>
        <asp:TextBox ID="TextBoxIn" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonGo" runat="server" Text="Go" OnClick="ButtonGo_Click" />
    </div>
    
    &nbsp

    <div id="output">
        <asp:Label ID="LabelOut" runat="server"  Text="Choose Correct State and Zipcode: "></asp:Label>
        <asp:DropDownList ID="DropDownListState" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListZip" runat="server">
        </asp:DropDownList>
    </div>
    


   

</asp:Content>
