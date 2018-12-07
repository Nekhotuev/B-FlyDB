function showDialog (buttonId, url, dialogContentId, modalDialogId, action) {
    $.ajaxSetup({ cache: false });
    $(buttonId).click(function (e) {
        e.preventDefault();
        $.get(url,
            function (data) {
                $(dialogContentId).html(data);
                $(modalDialogId).modal(action);
            });
    });
}