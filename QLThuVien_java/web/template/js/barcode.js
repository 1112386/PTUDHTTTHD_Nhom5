// Put event listeners into place
$(document).ready(function () {
    // Trigger photo take
    var timer;
    var canvas = document.getElementById("canvas"),
            context = canvas.getContext("2d"),
            dataURL,
            video = document.getElementById("video"),
            videoObj = { "video": true },
            errBack,
                localstream;

    $("#start").click(function () {
        // Grab elements, create settings, etc.
            errBack = function (error) {
                console.log("Video capture error: ", error.code);
            };

        // Put video listeners into place
        if (navigator.getUserMedia) { // Standard
            navigator.getUserMedia(videoObj, function (stream) {
                video.src = stream;
                localstream = stream;
                video.play();
            }, errBack);
        } else if (navigator.webkitGetUserMedia) { // WebKit-prefixed
            navigator.webkitGetUserMedia(videoObj, function (stream) {
                video.src = window.webkitURL.createObjectURL(stream);
                localstream = stream;
                video.play();
            }, errBack);
        } else if (navigator.mozGetUserMedia) { // WebKit-prefixed
            navigator.mozGetUserMedia(videoObj, function (stream) {
                video.src = window.URL.createObjectURL(stream);
                localstream = stream;
                video.play();
            }, errBack);
        }
        upload();
    });

    $("#snap").click(function () {
        upload();
        
    });
    $("#stop").click(function () {
        clearTimeout(timer);
        localstream.stop();
    });
    $("#use_cam").toggle(function () {
        $(this).val("Hide camera");
        $("#barcode").css("display", "block");
    }, function () {
        $(this).val("Use camera");
        $("#barcode").css("display", "none");
        if(timer!==null)
            clearTimeout(timer);
        if(localstream!==null)
            localstream.stop();
        
    });
    function upload() {
        context.drawImage(video, 0, 0, 280, 210);
        var image = canvas.toDataURL("image/jpeg");
        image = image.replace('data:image/jpeg;base64,', '');

        $.ajax({
            type: 'POST',
            url: '/barcode/read',
            data: { imageData: image },
            success: function (o) {
                if (o !== "") {
                    o = o.slice(0, o.lastIndexOf("("));
                    $("#code").val(o);
                }
            }
        });
        timer = setTimeout(upload, 2000);
    }
});

