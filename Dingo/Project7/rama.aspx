<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rama.aspx.cs" Inherits="Project7.rama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="RamaDelete.aspx?id={0}" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" />
                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="RamaDelete.aspx?id={0}" Text="delete" />
            </Columns>
        </asp:GridView>
        <br />
    </form>
</body>
</html>
