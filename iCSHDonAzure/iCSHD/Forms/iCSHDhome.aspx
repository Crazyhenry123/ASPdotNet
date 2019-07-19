<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iCSHDhome.aspx.cs" Inherits="iCSHD.iCSHDhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to iCSHD where CXD spirits are powered by AI technology! <br/>
            <br/>

        </div>
        <p>
            Enter your alias to start</p>
        <p>
            <asp:TextBox ID="StartAliasBox" runat="server" Height="30px" OnTextChanged="StartAliasBox_TextChanged" Width="592px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="StartButton" runat="server" Height="39px" OnClick="StartButton_OnClick" Text="Start" Width="290px" />
        </p>
    </form>
</body>
</html>
