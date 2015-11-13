<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1_List._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox runat="server" ID="listbox1">
        </asp:ListBox>        
        <asp:BulletedList runat="server">
            <asp:ListItem Text="1" Value="1"></asp:ListItem>
            <asp:ListItem Text="2" Value="2"></asp:ListItem>
            <asp:ListItem Text="3" Value="3"></asp:ListItem>
            <asp:ListItem Text="4" Value="4"></asp:ListItem>
        </asp:BulletedList>
    </div>
    <asp:Button runat="server" ID="button1" onclick="button1_Click" Text="点击加载数据" />
    <asp:Button ID="Button2" runat="server" onprerender="Button2_PreRender" 
        Text="Button" />
    </form>
</body>
</html>
