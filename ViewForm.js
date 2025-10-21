
$(document).ready(function () {
    RetriveDataTable();
});

function RetriveDataTable() {
    $.ajax({
        url: '/Maintenance/RetriveDataTable',
        type: 'POST',
        datatype: 'json',
        contenttype: 'application/json; charset=utf-8',
        success: function (data) {
            $('#datatable').DataTable({
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
                    { 'data': 'MachineID' },
                    { 'data': 'CardNo' },
                    {
                        'data': 'StartDateTime',
                        'render': function (jsonDate) {
                            var date = new Date(parseInt(jsonDate.substr(6)));
                            var month = date.getMonth() + 1;
                            return date.getDate() + "-" + month + "-" + date.getFullYear();
                        }
                    },
                    {
                        'data': 'EndDateTime',
                        'render': function (jsonDate) {
                            var date = new Date(parseInt(jsonDate.substr(6)));
                            var month = date.getMonth() + 1;
                            return date.getDate() + "-" + month + "-" + date.getFullYear();
                        }
                    },
                    {
                        'data': 'StartTime' },
                    { 'data': 'EndTime' }
                ]
            });
        }
    });
}