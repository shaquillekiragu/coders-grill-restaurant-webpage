console.log("site.js initialized!");
$(function () {
    try {
        $(".image-slider").slick({
            infinite: true,
            slidesToShow: 1,
            slidesToScroll: 1,
            dots: true,
            arrows: false,
        });
        console.log('Slider 1 loaded');
        
    } catch (error) {
        console.error('Error initializing first Slick carousel:', error);
    }

    try {
        $(".image-slider-2").slick({
            infinite: true,
            slidesToShow: 2,
            slidesToScroll: 2,
            arrows: true,
        });
        console.log('Slider 2 loaded');

    } catch (error) {
        console.error('Error initializing second Slick carousel:', error);
    }
})