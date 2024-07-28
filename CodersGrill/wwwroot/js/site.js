alert("Hello JS")

(document).foundation();

$(function () {
    console.log('Document is ready');

    try {
        $(".image-slider").slick({
            dots: true,
            infinite: true,
            speed: 500,
            slidesToShow: 1,
            slidesToScroll: 1,
            adaptiveHeight: true,
            autoplay: true,
            autoplaySpeed: 2000,
            arrows: true,
            fade: true,
            cssEase: "linear",
            lazyLoad: 'ondemand'
        });
    } catch (error) {
        console.error('Error initializing first Slick slider:', error);
    }

    /* try {
        $('.single-item').slick();
    } catch (error) {
        console.error('Error initializing first Slick slider for single-item:', error);
    } */

    console.log('Document is ready 2');

    try {
        $(".image-slider-2").slick({
            dots: true,
            infinite: true,
            speed: 500,
            slidesToShow: 1,
            slidesToScroll: 1,
            adaptiveHeight: true,
            autoplay: true,
            autoplaySpeed: 2000,
            arrows: true,
            fade: true,
            cssEase: "linear",
            lazyLoad: 'ondemand'
        });
    } catch (error) {
        console.error('Error initializing second Slick slider:', error);
    }

    try {
        $('.multiple-items').slick({
            infinite: true,
            slidesToShow: 3,
            slidesToScroll: 3
        });
    } catch (error) {
        console.error('Error initializing second Slick slider for multiple items:', error);
    }
})