// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function CheckUserExist() {
    var data = $("#pemail").serialize();
    $.ajax({
        type: 'POST',
        url: '/Patient/EmailExist',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: data,
        success: function (result) {
            $("#ErrorMsj").html(result);
        },
        error: function () {
            console.log('Failed ');
        }
    })
}
function CheckDoctorExist() {
    var data = $("#demail").serialize();
    $.ajax({
        type: 'POST',
        url: '/Doctor/EmailExist',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: data,
        success: function (result) {
            $("#ErrorMsj").html(result);
        },
        error: function () {
            console.log('Failed ');
        }
    })
}