<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="dataBind._Default" %>
<!doctype html>
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList runat="server" DataKeyField="testId" 
            DataSourceID="SqlDataSource1">
            <ItemTemplate>                
                testId:
                <asp:Label ID="testIdLabel" runat="server" Text='<%# Eval("testId") %>' data-of-Id="1" />
                <br />
                testName:
                <asp:Label ID="testNameLabel" runat="server" Text='<%# Eval("testName") %>' />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:testConnectionString %>" 
            SelectCommand="SELECT * FROM [testTable]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
