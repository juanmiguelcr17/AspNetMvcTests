function OnSuccess(data) {
    var json = $.parseJSON(data.responseText);
    var data = json.data;
    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_INFO,
        title: 'Info',
        message: data.Message
    });
}

function OnError(data) {
    var json = $.parseJSON(data.responseText);
    var data = json.data;
    BootstrapDialog.show({
        type: BootstrapDialog.TYPE_DANGER,
        title: 'Atención',
        message: data.Message
    });
}