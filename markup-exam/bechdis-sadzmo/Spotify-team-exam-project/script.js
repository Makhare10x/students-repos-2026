const audio = document.getElementById("music-file");
const sBtn = document.getElementById("start-btn");
const pBtn = document.getElementById("playing-btn");
const footerPlayer = document.querySelector(".footer-player");

//for playing
sBtn.onclick = function () {
    audio.play();
    sBtn.style.display = "none";
    pBtn.style.display = "flex";
    footerPlayer.classList.add("is-playing");
};

// for pause
pBtn.onclick = function () {
    audio.pause();
    pBtn.style.display = "none";
    sBtn.style.display = "flex";
    footerPlayer.classList.remove("is-playing");
};

// // Additional logic: when music ends the button changes
audio.onended = function() {
    pBtn.style.display = "none";
    sBtn.style.display = "flex";
    footerPlayer.classList.remove("is-playing");
};