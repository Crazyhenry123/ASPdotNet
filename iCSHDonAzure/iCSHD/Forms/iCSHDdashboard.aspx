<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iCSHDdashboard.aspx.cs" Inherits="iCSHD.Forms.iCSHDdashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What&#39;s the likelyhood we get 5 stars today?
        </div>

        <p>








            <asp:Button ID="CxInfoButton" runat="server" Height="99px" Text="Get Customer Pattern" Width="300px" style="margin-bottom: 0px; margin-top: 0px;" />








            <asp:DetailsView ID="CxInfoView" runat="server" Height="100px" OnPageIndexChanging="CxInfoView_PageIndexChanging" Width="300px">
            </asp:DetailsView>








            <asp:ListBox ID="CaseListBox" runat="server" Height="103px" OnSelectedIndexChanged="CaseListBox_SelectedIndexChanged" Width="180px"></asp:ListBox>
        </p>
    </form>
</body>
</html>
