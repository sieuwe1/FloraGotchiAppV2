// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    $('nav').prepend('<div id="responsive-nav" style="display:none">Icon</div>');
    $('#responsive-nav').on('click', function () {
        $('nav ul').toggle("slide");
    });

    $(window).resize(function () {

        if ($(window).innerWidth() < 768) {
            $('nav ul li').css('display', 'block');
            $('nav ul').hide()
            $('#responsive-nav').show()
        } else {
            $('nav ul li').css('display', 'inline-block');
            $('nav ul').show()
            $('#responsive-nav').hide()
        }

    });

    $(window).resize();

});
