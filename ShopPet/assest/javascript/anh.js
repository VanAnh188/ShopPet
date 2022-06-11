var imgFeature = document.querySelector('#img-feature');
var listImages = document.querySelectorAll('.img-product');

var currentIndex = 0;

function updatedImagebyIndex(index) {
    currentIndex = index;
    imgFeature.src = listImages[index].getAttribute('src');
}
listImages.forEach((imgElement, index) => {

    imgElement.addEventListener('click', e => {
        imgFeature.style.opacity = '0';
        setTimeout(() => {
            updatedImagebyIndex(index);
            imgFeature.style.opacity = '1';
        }, 50);
    });
});