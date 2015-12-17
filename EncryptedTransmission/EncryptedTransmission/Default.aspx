<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EncryptedTransmission._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <script type="text/javascript">
            function xmlHttp() {
                var xmlHttp;
                var URL = encodeURIComponent("Default.aspx?123=而非为");
                xmlHttp = new XMLHttpRequest();
                xmlHttp.open("get", URL, false);
                xmlHttp.onreadystatechange = function() {
                    if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {
                        alert(xmlHttp.resopnseText);
                    }
                }
                xmlHttp.send();
            }
            function xmlHttp1() {
                var xmlHttp;
                var URL = encodeURIComponent("123.txt");
                xmlHttp = new XMLHttpRequest();
                xmlHttp.open("get", URL, false);
                xmlHttp.onreadystatechange = function() {
                    if (xmlHttp.readyState == 4 && xmlHttp.status == 200) {
                        var div = document.createElement("div");
                        div.innerHTML = xmlHttp.responseText;
                        document.body.appendChild(div);
                        console.log(xmlHttp.responseText);
                    }
                }
                xmlHttp.send();
            }
        
        </script>

        <input type="button" onclick="xmlHttp()" />
        <input type="button" onclick="xmlHttp1()" />
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="testId" HeaderText="Id"  />
            <asp:BoundField DataField="testName" HeaderText="Name" />
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
