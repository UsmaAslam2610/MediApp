
    var mydata;
    var id;
    $(document).ready(function () {
        $.ajax
            ({
                type: 'GET', url: '/Patient/GetAppointments',
                datatype:'json',
                success: function (result) { 
                    myData = result
                    console.log(myData);
                    //if (myData != null || myData != "") {
                        //function createBtn() {
                        //    return '<button id="del" class="btn fa fa-trash"></button>'
                        //}
                    $('#userApp').DataTable({});
                            //({
                            //    data: result, /*destroy: true,*/
                            //    //columnDefs:
                            //    //    [{
                            //    //        "targets": -1, "data": null,
                            //    //        "defaultContent": createBtn()
                            //    //    }],

                            //    columns: [
                            //        {
                            //            data: 'appNo',
                            //            render: function (data, type, row, meta) {
                            //                return row.id
                            //            }
                            //        }
                            //        ,{
                            //            data: 'DocName',
                            //            render: function (data, type, row, meta) {
                            //                return row.id
                            //            }
                            //        }
                            //        , {
                            //            data: 'AppTime',
                            //            render: function (data, type, row, meta) {
                            //                return row.id
                            //            }
                            //        },
                            //        {
                            //            data: 'AppDate',
                            //            render: function (data, type, row, meta) {
                            //                return row.id
                            //            }
                            //        },
                            //        {
                            //            data: 'AppDay',
                            //            render: function (data, type, row, meta) {
                            //                return row.id
                            //            }
                            //        }, {
                            //            data: 'AppStatus',
                            //            render: function (data, type, row, meta) {
                            //                return row.id
                            //            }
                            //        }
                            //    ]
                            //});
                    //}
                }
        });
//    $('#del').on('click', 'td button', function() {
//    var closestRow = $(this).closest('tr');
//    var arr = table.row(closestRow).data();
//    id = arr[0]
//    console.log(id)
//    $.ajax({
//        url: "/Patient/PostAppointments",
//    type: "POST",
//    data: {"id": id },
//    success: function() {
//        window.location = '/Patient/UserAppointments';
//        }
//    });
//});
    });