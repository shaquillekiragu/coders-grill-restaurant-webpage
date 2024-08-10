console.log("site.js initialized!");

$(function () {
    console.log("site.js is loaded and running");

    const elements = document.querySelectorAll('[data-new-gr-c-s-check-loaded]');
    console.log(elements);

    elements.forEach(el => {
        el.style.display = 'none';
    });
});

$(function () {
    console.log('Carousel 1');
    try {
        $(".image-slider").slick({
            infinite: true,
            slidesToShow: 1,
            slidesToScroll: 1,
            dots: true,
            arrows: false,
        });
    } catch (error) {
        console.error('Error initializing first Slick carousel:', error);
    }

    console.log('Carousel 2');
    try {
        $(".image-slider-2").slick({
            infinite: true,
            slidesToShow: 4,
            slidesToScroll: 4,
            arrows: true,
        });
    } catch (error) {
        console.error('Error initializing second Slick carousel:', error);
    }
})