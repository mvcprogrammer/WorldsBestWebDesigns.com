$(document).ready(function () {
    $(document).on('focusin', 'input, select', function () {
        $(this).data('val', $(this).val());
        $('#submitButton').on('click', function () {
            if (!$(this).validate($('#alertform'))) {
                return false;
            }
            SendContactRequest();
        });
    });

    function SendContactRequest() {
        PostUpdate("/Contact/ContactMe",
            JSON.stringify(GetContactData()),
            (response) => ShowContactRequestResponse(response));
    };

    function ShowContactRequestResponse(response) {
        $('#contactform').html(response);
    }

    function GetContactData() {
        return new Object({
            Department: $('#department option:selected').text(),
            Subject: $('#subject').val(),
            Name: $('#name').val(),
            Email: $('#email').val(),
            Phone: $('#phone').val(),
            Message: $('#message').val()
        });
    }

    function PostUpdate(url, payload, callback) {
        $.ajax({
            type: "POST",
            url: url,
            data: payload,
            contentType: "application/json; charset=utf-8",
            dataType: "html",
            success: function (response) {
                if (callback != undefined) {
                    callback(response);
                }
            },
            failure: function (response) {
                IndicateUpdateFailure(response.responseText);
            },
            error: function (response) {
                IndicateUpdateFailure(response.responseText);
            }
        });
    }

    function IndicateUpdateSuccess(message, lastUpdateDateTime) {
        ShowStatusMessage(message, "success");
        $('#LastUpdate').html(lastUpdateDateTime);
    }

    function IndicateUpdateFailure(message) {
        ShowStatusMessage(message, "error");
    }

    function ShowStatusMessage(message, messageType) {
        $.pnotify({
            title: "Worksheet Update",
            text: message,
            type: messageType
        });
    }

    $("#department").focus();
});
