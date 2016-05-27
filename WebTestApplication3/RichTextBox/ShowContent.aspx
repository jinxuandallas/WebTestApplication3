<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowContent.aspx.cs" Inherits="WebTestApplication3.RichTextBox.ShowContent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server"><%=content %>
        </asp:Panel>
    
    </div>
        <div id="contentDiv" runat="server">

        </div>
        <asp:Literal ID="Literal1" runat="server" Mode="Encode"></asp:Literal>
    </form>
</body>
</html>
