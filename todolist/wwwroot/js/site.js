// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    console.log("ready!");

   // var dataObject = JSON.stringify({Id: 0, Title: "ajax1", Description: "descajax", Completed: 99, IsDone:true});
    console.log('okee'+dataObject);
    $.ajax({
        url: 'http://localhost:51657/todo/add/89',
        type: 'get',
        contentType: "application/json; charset=utf-8",
        dataType: "json"    
       // data:23,
        datatype: 'json',
        success: function (data, textstatus, xhr) {
            console.log(data);
        },
        error: function (xhr, textstatus, errorthrown) {
            console.log('error in operation');
        }
    });  
});