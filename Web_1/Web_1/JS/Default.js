window.onload = function() {
    //document.getElementById("a_1").addEventListener("click", click);
    var a = "123";
    page.Init(a);
};
function click(a) {
    alert(a);
};

var page = function() {
    Init: function(a) {
        document.getElementById("a_1").addEventListener("click", click(a));
    }
};