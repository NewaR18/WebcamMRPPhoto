$(function () {
    Webcam.set({
        width: 450,
        height: 450,
        image_format: 'jpeg',
        jpeg_quality: 90
    });
    $("#cam").click(function () {
        Webcam.attach('#webcam');
        document.getElementById("btnCapture").style.display = "block";
        document.getElementById("webcam").style.display = "block";
        document.getElementById("imgCapture").style.display = "none";
        document.getElementById("btnRetake").style.display = "none";
        document.getElementById("btnUpload").style.display = "none";
    });

    $("#btnCapture").click(function () {
        Webcam.snap(function (data_uri) {
            $("#imgCapture")[0].src = data_uri;
            document.getElementById("imgCapture").style.display = "block";
            document.getElementById("btnRetake").style.display = "block";
            document.getElementById("btnUpload").style.display = "block";
            document.getElementById("btnCapture").style.display = "none";
            document.getElementById("webcam").style.display = "none";
            Webcam.reset('#webcam');
        });
    });
    $("#btnRetake").click(function () {
        Webcam.attach('#webcam');
        document.getElementById("btnCapture").style.display = "block";
        document.getElementById("webcam").style.display = "block";
        document.getElementById("imgCapture").style.display = "none";
        document.getElementById("btnRetake").style.display = "none";
        document.getElementById("btnUpload").style.display = "none";
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
        document.getElementById("displayimage").style.display = "block";
        $("#displayimage")[0].src = $("#imgCapture")[0].src
        Webcam.reset('#webcam');
    });
});