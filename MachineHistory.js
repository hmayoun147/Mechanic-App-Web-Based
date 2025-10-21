$(document).ready(function () {
/*    RetriveMachineHistory();*/
});

function RetriveMachineHistory() {
    $.ajax({
        url: '/Maintenance/RetriveMachineHistory',
        type: 'POST',
        datatype: 'json',
        contenttype: 'application/json; charset=utf-8',
        success: function (data) {
            $('#machinedatatable').DataTable({
                data: data,
                paging: 'true',
                search: 'true',
                scrollY: '200',
                sorting: 'true',
                columnDefs: [
                    {
                        className: 'dt-center', targets: '_all',
                    }
                ],
                columns: [
                    { 'data': 'MachineVenderName' },
                    {
                        'data': 'MachinePurchaseDate',
                        'render': function (jsonDate) {
                            
                            var date = new Date(parseInt(jsonDate.substr(6)));
                            var month = date.getMonth() + 1;
                            return date.getDate() + "-" + month + "-" + date.getFullYear();
                        }
                    },
                    {
                        'data': 'LastMaintenceDate',
                        'render': function (jsonDate) {
                            var date = new Date(parseInt(jsonDate.substr(6)));
                            var month = date.getMonth() + 1;
                            return date.getDate() + "-" + month + "-" + date.getFullYear();
                        }
                    }
                ]
            });
        }
    });
}