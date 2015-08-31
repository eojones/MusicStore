$(document).ready(function () {
    $('body').attr({
        'data-spy': 'scroll',
        'data-target': '.nav-tabs',
        'data-offset': '50'
    });
    $("#parallax1").height($(document).height());

    $(window).on("resize load", function () {
        $('section.module.parallax').height($(document).height());
    });
});