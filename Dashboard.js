$(document).ready(function (){

})
function LoadPartialView(Option) {
    if (Option == "1") {
        $("#LoadPartails").html("");
        $("#LoadPartails").load("/Maintenance/NewRequest");
    }
    else if (Option == "2") {
        $("#LoadPartails").html("");
        $("#LoadPartails").load("/Maintenance/ViewForm");
    }
    else if (Option == "3") {
        $("#LoadPartails").html("");
        $("#LoadPartails").load("/Maintenance/MachineHistory");
    }
    else if (Option == "4") {
    }
}