const navLink = document.querySelectorAll('.nav-link');
let activeLink = document.querySelector('.nav-link.filter');

navLink.forEach(link => {
    link.addEventListener('click', () => {
        if (activeLink === link) return;

        if (activeLink) {
            activeLink.classList.remove('filter');
        }
        link.classList.add('filter');
        activeLink = link;
    });
});

// this one friends activity. on clicking it appears and hides
const friendsBtn = document.getElementById('friends-activity');
const friendsPanel = document.getElementById('friends-panel');
const friendsCloseBtn = document.getElementById('friends-close-btn');

function openFriends() {
    document.body.classList.add('friends-open');
}

function closeFriends() {
    document.body.classList.remove('friends-open');
    friendsPanel.classList.remove('active');
}

friendsBtn.addEventListener('click', (e) => {
    e.preventDefault();
    document.body.classList.toggle('friends-open');
    friendsPanel.classList.toggle('active');
});

friendsCloseBtn.addEventListener('click', closeFriends);

// this is for player progress bar
const range = document.getElementById('range');
const cur = document.getElementById('cur');
function format(sec) {
    const m = Math.floor(sec / 60);
    const s = Math.floor(sec % 60);
    return m + ':' + String(s).padStart(2, '0');
}

function updateTrack(){
    const percent = (range.value / range.max) * 100;
    range.style.background = `linear-gradient(to right,
                            #E0E0E0 ${percent}%,
                            rgba(255,255,255,0.15) ${percent}%)`;
    cur.textContent = format(range.value);
}
range.addEventListener('input', updateTrack);
updateTrack();

// this one is for pagination in section

document.querySelectorAll('.next-pgnt-bttn').forEach(btn => {
    btn.addEventListener('click', () => {
        const container = document.getElementById(btn.dataset.target);
        container.scrollBy({left: 300, behavior: 'smooth'});
    });
});
document.querySelectorAll('.prev-pgnt-bttn').forEach(btn => {
    btn.addEventListener('click', () => {
        const container = document.getElementById(btn.dataset.target);
        container.scrollBy({left: -300, behavior: 'smooth'});
    });
});