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

    $('#sideBar li').each(function (index, value) {
        $(value).on('click', function () {
            //alert("index: "+ (index+1));
            $(value).scrollTop(1000);
        });

    });

    //$(function () {
    //    $('#sideBar li').each(function (index, value) {
    //        $(value).scrollify({
    //            section: value
    //        });
    //    });
    //});
});
var nrFaixas;
function setAlbum() {
     nrFaixas = $('input[name=nrFaixa]').val();
}
function getAlbum(){
    for (var i =  nrFaixas; i > 0 ; i--)
    {
        $('#parallax-2 .container').prepend("<input placeholder='nome da faixa' name='faixa" + (i) + "'/>");
    }
}