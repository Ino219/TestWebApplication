<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Button ID="AcountButton" runat="server" BackColor="#009933" ForeColor="Black" Height="30px" Text="アカウント管理" />
&nbsp;
            <asp:Button ID="HystoryButton" runat="server" BackColor="#009933" Height="30px" Text="注文履歴" />
&nbsp;<br />
&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />
&nbsp;<asp:Image ID="Image1" runat="server"/>
            &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click" />
&nbsp;<br />
            

            <asp:Label ID="Label1" runat="server" Font-Size="20pt" Text="ID:"></asp:Label>
&nbsp;
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="20pt" Text="商品名:"></asp:Label>
&nbsp;
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="20pt" Text="単価:"></asp:Label>
&nbsp;
            <br />
            <asp:Label ID="Label4" runat="server" Font-Size="20pt" Text="数量:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="77px">1</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="OrderButton" runat="server" BackColor="Yellow" Font-Size="20pt" Height="45px" Text="注文" />
        </div>
    </form>
    <%--<img src="220953.png" height="500" width="500"/>--%>
</body>
</html>
