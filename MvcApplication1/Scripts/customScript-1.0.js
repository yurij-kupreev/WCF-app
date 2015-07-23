$(function () {
    $('#GetUserList').click(function (event) {
        event.preventDefault();
        $.ajax({
            type: "GET",
            url: "http://localhost:51746/UserService.svc/Users/",
            contentType: "json",
            dataType: "json",
            success: GetJsonData,
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    });

    //$("#addUserButton").click(function (event) {
    //    event.preventDefault();
    //    var data2 = $('form');
    //    var data = $('form').serialize();
    //    $.ajax({
    //        type: "PUT",
    //        url: "http://localhost:51746/UserService.svc/AddUser/0",
    //        data: data,
    //        contentType: "application/json; charset=utf-8",
    //        dataType: "json",
    //        processData: true,
    //        success: function (data, status, jqXHR) {
    //            alert("success..." + data);
    //        },
    //        error: function(xhr){
    //            alert(xhr.responseText);
    //        }
    //    });
    //});
    $("#formUser").submit(function (event) {
        event.preventDefault();
        var data2 = $('form');
        var data = $('form').serialize();
        $.ajax({
            type: "PUT",
            url: "http://localhost:51746/UserService.svc/AddUser/0",
            data: data,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            processData: true,
            success: function (data, status, jqXHR) {
                alert("success..." + data);
            },
            error: function (xhr) {
                alert(xhr.responseText);
            }
        });
    });
});

function sendData(data) {
    //var data2 = $('form');
    //var data = $('form').serialize();
    var a = data.Id;
    var b = data.Name;
    var c = data.Phone;
    //var data2 = { "Name": "qwerty", "Phone": "123456" };
    $.ajax({
        type: "PUT",
        url: "http://localhost:51746/UserService.svc/AddUser/0",
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        processData: true,
        success: function (data, status, jqXHR) {
            alert("success..." + data);
        },
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
}

function updateData(data) {
    var a = data.Id;
    var b = data.Name;
    var c = data.Phone;
    var url = "http://localhost:51746/UserService.svc/UpdateUser/" + data.Id;
    $.ajax({
        type: "PUT",
        url: url,
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        processData: true,
        success: function (data, status, jqXHR) {
            alert("success..." + data);
        },
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
}

function GetDataById(data) {
    var url = "http://localhost:51746/UserService.svc/UserById/" + data.Id;
    $.ajax({
        type: "GET",
        url: url,
        contentType: "json",
        dataType: "json",
        success: GetJsonData,
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
}

function DeleteData(data) {
    var url = "http://localhost:51746/UserService.svc/DeleteUser/" + data.Id;
    $.ajax({
        type: "DELETE",
        url: url,
        contentType: "json",
        dataType: "json",
        success: function (data){
            alert("success... " + data);
        },
        error: function (xhr) {
            alert(xhr.responseText);
        }
    });
}

function GetJsonData(data) {
    var results = $('#JsonData');
    results.empty();

    var contentArray = [];
    contentArray[0] = "<ul>";

    for (var i = 0; i < data.length; ++i) {
        contentArray.push('<li>id: ' + data[i].Id + ' name: ' + data[i].Name + ' phone ' + data[i].Phone + '</li>');
    }
    if (data.length == null) {
        contentArray.push('<li>id: ' + data.Id + ' name: ' + data.Name + ' phone ' + data.Phone + '</li>');
    }
    contentArray.push('</ul>');
    results.append(contentArray.join(""));
}
