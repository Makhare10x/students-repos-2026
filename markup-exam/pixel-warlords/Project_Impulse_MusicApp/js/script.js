const searchBtn = document.getElementById('search-nav-item');
const homeBtn = document.getElementById('home-nav-item');
const libraryBtn = document.getElementById('library-nav-item');
const navItems = document.querySelectorAll('.nav-item');
const meBtn = document.getElementById('me-nav-item');

function resetView() {
    document.body.classList.remove('search-active', 'library-active', 'me-active');
    navItems.forEach(item => item.classList.remove('active'));
}

searchBtn.addEventListener('click', () => {
    resetView();
    document.body.classList.add('search-active');
    searchBtn.classList.add('active');
});

homeBtn.addEventListener('click', () => {
    resetView();
    homeBtn.classList.add('active');
});

libraryBtn.addEventListener('click', () => {
    resetView();
    document.body.classList.add('library-active');
    libraryBtn.classList.add('active');
});

meBtn.addEventListener('click', () => {
    resetView();
    document.body.classList.add('me-active');
    meBtn.classList.add('active');
});