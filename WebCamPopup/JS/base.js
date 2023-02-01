$(function () {
    Webcam.set({
        width: 350,
        height: 450,
        image_format: 'jpeg',
        jpeg_quality: 90
    });
    $("#cam").click(function () {
        Webcam.attach('#webcam');
    });

    $("#btnCapture").click(function () {
        Webcam.snap(function (data_uri) {
            $("#imgCapture")[0].src = data_uri;
            $("#btnUpload").removeAttr("disabled");
        });
    });
    $("#btnUpload").click(function () {
        $.ajax({
            type: "POST",
            url: "/Cam/SaveCapturedImage",
            data: "{data: '" + $("#imgCapture")[0].src + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                console.log(response);
            },
            error: function (req, status, error) {
                console.log(status);
                console.log(error);
                console.log(req);
            }
        });
        window.location = "Base.aspx";
    });
});