console.log("JavaScript is working!");
const container = document.getElementById('scroll-container');
const leftBtn = document.querySelector('.scroll-btn.left');
const rightBtn = document.querySelector('.scroll-btn.right');

// Adjust this value if you want faster/slower scrolling
const scrollAmount = 300; 

leftBtn.addEventListener('click', () => {
    container.scrollBy({
        left: -scrollAmount,
        behavior: 'smooth' // This makes it glide instead of jumping
    });
});

rightBtn.addEventListener('click', () => {
    container.scrollBy({
        left: scrollAmount,
        behavior: 'smooth'
    });
});