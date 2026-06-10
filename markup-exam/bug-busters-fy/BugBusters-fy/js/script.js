const mobileQuery = window.matchMedia("(max-width: 920px)");

// Control
const playBtn = document.getElementById("play");
const pauseBtn = document.getElementById("pause");
const prevBtn = document.getElementById("prev");
const nextBtn = document.getElementById("next");

// Track
const mediaInfo = document.querySelector(".media-info");
const audio = document.getElementById("audio");
const title = document.getElementById("title");
const subTitle = document.getElementById("sub-title");
const author = document.getElementById("author");
const album = document.getElementById("album");
const cover = document.getElementById("cover");

//
const progress = document.getElementById("progress");
const currentTimeEl = document.getElementById("currentTime");
const durationEl = document.getElementById("duration");
const volumeSlider = document.getElementById("volumeSlider");
const volumeIcon = document.getElementById("volumeIcon");

//
const volumeOn = `
<svg width="41" height="41" viewBox="0 0 41 41" fill="none" xmlns="http://www.w3.org/2000/svg">
<g clip-path="url(#clip0_24_424)">
<path d="M12.8558 23.8203C9.87736 22.3311 9.87736 18.081 12.8558 16.5918L21.5883 12.2256C22.0359 12.0018 22.5625 12.3268 22.5629 12.8271L22.5629 27.584C22.5629 28.0846 22.036 28.4102 21.5883 28.1865L12.8558 23.8203Z" stroke="currentColor" stroke-width="2.02054"/>
<path d="M26.9406 25.2578C27.7294 25.0427 28.4588 24.5653 29.04 23.8699C29.852 22.8983 30.3082 21.5805 30.3082 20.2065C30.3082 18.8324 29.852 17.5146 29.04 16.543C28.4588 15.8476 27.7294 15.3703 26.9406 15.1551" stroke="currentColor" stroke-width="1.68378" stroke-linecap="round"/>
<path d="M26.0987 19.6957C26.0987 19.5131 26.2522 19.3593 26.4208 19.4291C26.523 19.4714 26.6158 19.5335 26.694 19.6116C26.7722 19.6898 26.8342 19.7826 26.8765 19.8848C26.9188 19.9869 26.9406 20.0964 26.9406 20.2069C26.9406 20.3175 26.9188 20.427 26.8765 20.5291C26.8342 20.6313 26.7722 20.7241 26.694 20.8022C26.6158 20.8804 26.523 20.9424 26.4208 20.9847C26.2522 21.0546 26.0987 20.9008 26.0987 20.7182L26.0987 20.2069L26.0987 19.6957Z" fill="#898989" stroke="#898989" stroke-width="0.841892"/>
</g>
<defs>
<clipPath id="clip0_24_424">
<rect width="23.573" height="23.573" fill="white" transform="translate(8.41895 8.41992)"/>
</clipPath>
</defs>
</svg>
`;

const volumeOff = `
<svg width="41" height="41" viewBox="0 0 41 41" fill="none" xmlns="http://www.w3.org/2000/svg">
  <path d="M18 13v15l-5-4H9a1 1 0 0 1-1-1v-5a1 1 0 0 1 1-1h4l5-4z" fill="currentColor"/>
  <line x1="25" y1="15" x2="33" y2="25" stroke="currentColor" stroke-width="2.2" stroke-linecap="round"/>
  <line x1="33" y1="15" x2="25" y2="25" stroke="currentColor" stroke-width="2.2" stroke-linecap="round"/>
</svg>
`;

const songs = [
  {
    audio: "../assets/audio/Daft Punk - Get Lucky.mp3",
    title: "Get Lucky",
    author: "Daft Punk",
    album: "Random Access Memories",
    cover: "../assets/images/daftpunk.png",
  },
  {
    audio: "../assets/audio/Ghostbusters .mp3",
    title: "Ghostbusters",
    author: "Ray Parker Jr.",
    album: "Ghostbusters",
    cover: "../assets/images/covers/GhostbustersCover.jpg",
  },
  {
    audio: "../assets/audio/DjBudzi.mp3",
    title: "აბობოქრებულ ზღვაში გატარებ",
    author: "Dj Budzi.",
    album: "აბობოქრებულ ზღვაში",
    cover: "../assets/images/covers/DjBudzi.jpeg",
  },
];

// index of the currently playing song
let songIndex = 0;

/*==================
 Initial load Song
==================*/

loadSong(songs[songIndex]);

/*==================
   Control Buttons
==================*/

// **Play button action
playBtn.addEventListener("click", playSong);

// **Pause button action
pauseBtn.addEventListener("click", pauseSong);

// **Next button action
nextBtn.addEventListener("click", () => {
  songIndex++;

  if (songIndex > songs.length - 1) {
    songIndex = 0;
  }

  loadSong(songs[songIndex]);
  playSong();
});

// **Previous button action
prevBtn.addEventListener("click", () => {
  songIndex--;

  if (songIndex < 0) {
    songIndex = songs.length - 1;
  }
  loadSong(songs[songIndex]);
  playSong();
});

/*==================
  Audio Control
==================*/

// **Load meta data and display duration when song loads
audio.addEventListener("loadedmetadata", () => {
  console.log(audio.duration);
  displayFormattedTime(audio.duration, durationEl);
});

// **Updates progress bar color, current time, and duration
// ** automatically while audio is playing
audio.addEventListener("timeupdate", () => {
  if (!audio.duration) return;

  const progressPercent = (audio.currentTime / audio.duration) * 100;
  progress.value = progressPercent;

  progress.style.background = `linear-gradient(
          to right,
          #1ed760 ${progressPercent}%,
          #89898945 ${progressPercent}%
          )`;

  // Update current and rested duration time display
  displayFormattedTime(audio.currentTime, currentTimeEl);
  displayFormattedTime(audio.duration - audio.currentTime, durationEl);
});

// **Updates progress bar, current time, and duration
// ** when dragging progress bar
progress.addEventListener("input", () => {
  audio.currentTime = (progress.value / 100) * audio.duration;
});

audio.addEventListener("ended", nextSong);

/*==================
 Volume
==================*/

// volume control
volumeIcon.addEventListener("click", () => {
  audio.muted = !audio.muted;

  volumeIcon.innerHTML =
    audio.muted || audio.volume == 0 ? volumeOff : volumeOn;
});

/*==================
 Reusable Helper function
==================*/

function loadSong(song) {
  if (mobileQuery.matches) {
    title.innerText = `${song.title} - ${song.album}`;
    album.innerText = "";
  } else {
    title.innerText = song.title;
    album.innerText = song.album;
  }

  author.innerText = song.author;
  cover.src = song.cover;
  cover.alt = `${song.title} cover by ${song.author}`;
  audio.src = song.audio;

  currentTimeEl.textContent = "0:00";
  durationEl.textContent = "0:00";
  playBtn.classList.add("show");
  pauseBtn.classList.remove("show");
}

function playSong() {
  audio.play();

  playBtn.classList.remove("show");
  pauseBtn.classList.add("show");
  pauseBtn.classList.add("active");
}

function pauseSong() {
  audio.pause();

  pauseBtn.classList.remove("show");
  playBtn.classList.add("show");
  playBtn.classList.add("active");
}

function nextSong() {
  songIndex++;

  if (songIndex > songs.length - 1) {
    songIndex = 0;
  }

  loadSong(songs[songIndex]);
  playSong();
}

//**function to format and display time
function displayFormattedTime(time, element) {
  const minutes = Math.floor(time / 60);
  let seconds = Math.floor(time % 60);
  if (seconds < 10) seconds = "0" + seconds;
  element.textContent = `${minutes}:${seconds}`;
}

/*==================
 Popup open-close
==================*/
const userMenuBtn = document.querySelectorAll(".nav-btn");
const popups = document.querySelectorAll(".sidePopup");
const layout = document.querySelector(".pageLayout");
const popupClose = document.querySelector("btn-close");
console.log(popupClose);

userMenuBtn.forEach((button) => {
  button.addEventListener("click", () => {
    const popup = button.dataset.popup;
    console.log(popup);
    button.classList.toggle("active");
    const activeSection = document.getElementById(popup);
    console.log(activeSection);

    // if the same section is already open → close popup
    if (activeSection.classList.contains("active")) {
      layout.classList.remove("open");
      activeSection.classList.remove("active");
      return;
    }

    layout.classList.add("open");
    popups.forEach((sec) => sec.classList.remove("active"));

    activeSection.classList.add("active");
  });
});

layout.addEventListener("click", (e) => {
  const closeBtn = e.target.closest(".btn-close");

  if (!closeBtn) return;

  layout.classList.remove("open");

  popups.forEach((p) => p.classList.remove("active"));
  userMenuBtn.forEach((b) => b.classList.remove("active"));
});
