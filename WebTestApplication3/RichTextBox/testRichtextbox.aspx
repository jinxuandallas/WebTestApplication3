<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testRichtextbox.aspx.cs" validateRequest="false" Inherits="WebTestApplication3.RichTextBox.testRichtextbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="js/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="js/xheditor-1.2.2.min.js"></script>  
    <script type="text/javascript" src="js/xheditor_lang/zh-cn.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 24px;
            height: 24px;
        }
        .xheditor {
            height: 150px;
            width: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <textarea name="content" id="elm1" class="xheditor {tools:'simple',upImgUrl:'upload/upload.aspx',upImgExt:'jpg,jpeg,gif,png'}" runat="server">test</textarea><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" />
&nbsp;<br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
        <img alt="" class="auto-style1" src="js/brokenheart.gif" /><img alt="" class="auto-style1" src="upload/brokenheart.gif" /></p>
        <p>
        <div id="divBox" runat="server">怎么办</div>   
        </p>
       
    </div>
    </form>
   
</body>
</html>
