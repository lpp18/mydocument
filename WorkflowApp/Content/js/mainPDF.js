requirejs.config({
    baseUrl: '../Content/js/libs',
    shim: {
        "jquery.touchSwipe": {
            deps: ["jquery"]
        },
        "jquery.touchPDF": {
            deps: ["jquery"]
        },
        "jquery.panzoom": {
            deps: ["jquery"]
        },
        "jquery.mousewheel": {
            deps: ["jquery"]
        }
    }
});


require(["jquery","pdf","pdf.compatibility",  "jquery.touchSwipe","jquery.touchPDF","jquery.panzoom","jquery.mousewheel"], function ($,pdf) {
    $(function () {
        $("#myPDF").pdf({
            source: "aa1.pdf"
        });
    });
   
});