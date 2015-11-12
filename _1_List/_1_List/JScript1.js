window.onload = function() {
    document.getElementById("button1").addEventListener("click", button1_click);
}
function button1_click() {
    var xmlhttp = new XMLHttpRequest();
    var url = ""
    xmlhttp.open("get", "/Handler1.ashx", false);

    xmlhttp.onreadystatechange = function() {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            console.log(xmlhttp.responseText);
            //var cc = eval('(' + xmlhttp.responseText + ')');
            var cc = JSON.parse(xmlhttp.responseText);
            alert(cc.Table);
            console.log(cc.Table.length);
            alert(cc["Table"]);
            alert(cc["Table"][0]["testId"]);
            alert(cc["Table"][0]["testName"]);

        }
    }
    xmlhttp.send();
}
