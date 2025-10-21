$(document).ready(function () {
    setInterval(GetTimerStatus, 1000);
});
function GetTimerStatus() {
    $.ajax({
        url: '/Maintenance/RetriveMachineUnscheduleStatus',
        type: 'POST',
        datatype: 'json',
        contenttype: 'application/json; charset=utf-8',
        success: function (data) {
            var Seconds = 0;
            if(data.Started == true && data.Ended == false) {
                $("#starttime").hide();
                $("#stoptime").show();
                $("#timer").html('');
                if (data.DownTimeSecond > 60) {

                }
                else {
                    Seconds = data.DownTimeSecond;
                }
                var newsec = data.DownTimeSecond % 60;
                $("#timer").html(data.DownTimeMinute + ' Mins. ' + newsec +' Secs.');
            }
            else {
                $("#starttime").show();
                $("#stoptime").hide();
            }
        },
        error: function () {
        }
    });
}
function StartTimer() {
    $.ajax({
        url: '/Maintenance/SaveUnScheduleMaintenance',
        type: 'POST',
        datatype: 'json',
        contenttype: 'application/json; charset=utf-8',
        success: function (data) {
            GetTimerStatus();
        },
        error: function () {
        }
    });
}
function EndTimer() {
    $.ajax({
        url: '/Maintenance/UpdateUnscheduleMaintenance',
        type: 'POST',
        datatype: 'json',
        contenttype: 'application/json; charset=utf-8',
        success: function (data) {
            $("#timer").html('0:00');
            $("#starttime").show();
            $("#stoptime").hide();
        },
        error: function () {
        }
    });
}