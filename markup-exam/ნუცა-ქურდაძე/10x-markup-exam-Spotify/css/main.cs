@charset "UTF-8";
/* დასადგენი მაქვს ეს რისი ფერია */
/* Spacing & Sizing გასაწერი მაქვს */
/*  Breakpoints გასაწერი მაქვს */
* {
  box-sizing: border-box;
  padding: 0;
  margin: 0;
}

ul, ol {
  list-style: none;
  padding: 0;
  margin: 0;
}

li {
  cursor: pointer;
}

a {
  text-decoration: none;
  color: inherit; /* ეს მინდა თუ მაინც ისე შევიყვანო ფერი? */
}

body {
  font-family: "Satoshi-Light";
  background-color: #060606;
  color: #898989;
  font-size: 14px;
  font-weight: 400;
  margin: 0;
  padding-right: 7px;
}

h1, h2, h3 {
  color: #E0E0E0;
}

h2 {
  font-size: 20px;
  padding-top: 22px;
  padding-bottom: 22px;
}

h3 {
  font-size: 14px;
}

p {
  color: #898989;
}

.container {
  margin: 0 auto;
}

.main-layout {
  display: grid;
  grid-template-columns: 260px 1fr;
  grid-template-rows: 54px 1fr 81px;
  column-gap: 5px;
  row-gap: 5px;
  height: 100vh;
  overflow: hidden;
  position: relative;
  padding-bottom: 10px;
  scroll-behavior: smooth;
  scroll-snap-type: x mandatory;
}
.main-layout::-webkit-scrollbar {
  width: 0;
}
.main-layout::-webkit-scrollbar-track {
  background: transparent;
}
.main-layout::-webkit-scrollbar-thumb {
  background-color: #111111;
  border-radius: 3px;
}

.header-container {
  grid-column: 1/-1;
  grid-row: 1;
  left: 0;
  top: 0;
  margin-bottom: 16px; /* არაფერი არ შეცვალა ((( */
}

.sidebar {
  grid-column: 1;
  grid-row: 2/4;
}

.main-content {
  grid-column: 2;
  grid-row: 2;
  grid-template-columns: repeat(auto-fit, 170px);
  justify-content: center;
  border: 1px solid #6E6E6E;
  border-radius: 8px;
  padding: 25px;
  overflow-y: auto;
  height: 100%;
  width: 100%;
  box-sizing: border-box;
}

footer {
  grid-column: 2; /* ზის მე-2 სვეტში (სიდბარის გვერდით) */
  grid-row: 3;
  height: 81px;
  display: flex;
}

.section-name {
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.album {
  width: 170px;
}

.main-liked-songs {
  grid-column-start: 2;
  grid-row-start: 2;
  border-radius: 8px;
  padding: 37px;
  overflow-y: auto;
  height: 100%;
  background: radial-gradient(circle at center, #575F70 0%, transparent 70%), linear-gradient(to bottom, #54565F);
  background-repeat: no-repeat;
  background-attachment: fixed;
}

.liked-song-container {
  width: 721px;
  height: 494px;
  gap: 20px;
  display: flex;
  flex-direction: column;
}

.song-content-wrapper {
  display: flex;
  gap: 62px;
  align-items: flex-start;
}

.song-content-wrapper img {
  width: 500px;
  height: 500px;
}

.icons-and-details {
  display: flex;
  width: 529px;
  align-items: center;
  justify-content: space-between;
}

.liked-songs-playlist li {
  display: flex;
  align-items: center;
  gap: 20px;
  margin-bottom: 15px;
}

.liked-songs-playlist img {
  width: 61px;
  height: 61px;
}

.song-lyrics-section {
  margin-top: 54px;
  width: 100%;
}
.song-lyrics-section .lyrics-nav {
  border-bottom: 1px solid #6E6E6E;
  margin-bottom: 35px;
}
.song-lyrics-section .lyrics-nav ul {
  display: flex;
  gap: 50px;
  padding-left: 46px;
}
.song-lyrics-section .lyrics-nav ul li {
  font-size: 14px;
  font-weight: 700;
  color: #898989;
  padding-bottom: 12px;
  transition: color 0.3s ease;
}
.song-lyrics-section .lyrics-nav ul li:hover {
  color: #E0E0E0;
}
.song-lyrics-section .lyrics-nav li.active {
  color: #fff;
  position: relative;
  margin-bottom: 0;
}
.song-lyrics-section .lyrics-nav li.active::after {
  content: "";
  position: absolute;
  bottom: -1.5px;
  left: 50%;
  transform: translateX(-50%);
  /* ხაზის ზომა (დაარეგულირე შენით) */
  width: calc(100% + 20px);
  height: 3px;
  /* ხაზის ფერი და მომრგვალება */
  background-color: #13BF51;
  border-radius: 4px;
}
.song-lyrics-section .lyrics-container {
  display: flex;
  gap: 60px;
}
.song-lyrics-section .lyrics-container .lyrics-sidebar {
  display: flex;
  flex-direction: column;
  gap: 24px;
  padding-top: 8px;
}
.song-lyrics-section .lyrics-container .lyrics-sidebar .sidebar-icon {
  cursor: pointer;
  opacity: 0.6;
  transition: opacity 0.2s;
}
.song-lyrics-section .lyrics-container .lyrics-sidebar .sidebar-icon:hover {
  opacity: 1;
}
.song-lyrics-section .lyrics-container .lyrics-sidebar .sidebar-icon svg {
  width: 20px;
  height: 20px;
  fill: #b3b3b3;
}

.lyrics-content {
  /* ეს თვისება აიძულებს ბრაუზერს აღიქვას Enter-ები */
  white-space: pre-line;
  font-size: 28px;
  font-weight: 700;
  color: #fff;
  line-height: 1.8; /* ხაზებს შორის დაშორება */
  letter-spacing: -0.04em;
  padding-left: 10px;
  /* თუ გინდა, რომ ტექსტი ძალიან თეთრი არ იყოს და თვალს არ ჭრიდეს */
  opacity: 0.9;
  /* პატარა ეფექტი: ტექსტის შერჩევისას (Selection) ფერი */
}
.lyrics-content::selection {
  background: #1ed760;
  color: #000;
}

.sidebar {
  background-color: #060606;
  color: #898989;
  display: flex;
  flex-direction: column;
  width: 259px;
  height: 100vh;
  position: fixed;
  top: 54px;
  left: 0;
}

.sidebar-content {
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  gap: 11px;
}

.sidebar-nav .nav-link a {
  padding-left: 20px;
}
.sidebar-nav .nav-link a:hover {
  color: #E0E0E0;
  background-color: #202020;
  border-color: #6E6E6E;
  border-radius: 8px;
  cursor: pointer;
  transition: color 0.3s ease;
}
.sidebar-nav .nav-link a .nav-icon path {
  stroke: #898989;
  transition: stroke 0.3s ease;
}
.sidebar-nav .nav-link a:hover {
  color: #E0E0E0;
  background-color: #202020;
  border-color: #6E6E6E;
  border-radius: 8px;
  cursor: pointer;
  transition: color 0.3s ease;
}
.sidebar-nav .nav-link a:hover .nav-icon path {
  stroke: #E0E0E0;
}

.nav-link:hover {
  color: #111111;
  font-weight: 600;
  cursor: pointer;
  transition: color 0.3s ease;
}

.nav-link {
  display: flex;
  align-items: center;
  height: 40px;
  justify-content: center;
}
.nav-link a {
  display: flex;
  align-items: center;
  gap: 10px;
  color: #898989;
  text-decoration: none;
  width: 100%;
  height: 100%;
}

.filter-btn {
  text-decoration: none;
  border: none;
  background-color: #202020;
  color: #E0E0E0;
  padding: 8px 12px;
  border-radius: 8px;
  gap: 12px;
}

.filter-btn:hover {
  background-color: #E0E0E0;
  color: #111111;
  font-weight: bold;
}

.music-genre {
  text-decoration: none;
  background-color: transparent;
  border: 2px solid #898989;
  color: #E0E0E0;
  padding: 8px 12px;
  border-radius: 44px;
  gap: 10px;
}

.header-navigation {
  align-items: center;
  height: 54px;
  width: 100%;
  justify-content: space-between;
  display: flex;
  top: 0;
  left: 0;
}

.top-sidebar {
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.main-nav-list {
  display: flex;
  list-style: none;
  align-items: center;
  margin-top: 10px;
  margin-left: 10px;
  padding: 0;
}
.main-nav-list .nav-link {
  align-items: center;
}
.main-nav-list .nav-link:nth-child(1) {
  width: 250px;
}
.main-nav-list .nav-link:nth-child(2) {
  width: 210px;
}
.main-nav-list .nav-link:nth-child(3) {
  width: 210px;
}
.main-nav-list .nav-link:nth-child(4) {
  width: 350px;
}
.main-nav-list .nav-link a {
  display: flex;
  align-items: center;
  width: 100%;
  box-sizing: border-box;
  text-decoration: none;
  color: #898989;
  padding: 8px 12px;
  border-radius: 8px;
  gap: 10px;
}
.main-nav-list .nav-link a:hover {
  color: #E0E0E0;
  background-color: #202020;
  border-color: #6E6E6E;
  border-radius: 8px;
  cursor: pointer;
  transition: color 0.3s ease;
}
.main-nav-list .nav-link a .nav-icon path {
  stroke: #898989;
  transition: stroke 0.3s ease;
}
.main-nav-list .nav-link a:hover {
  color: #E0E0E0;
  background-color: #202020;
  border-color: #6E6E6E;
  border-radius: 8px;
  cursor: pointer;
  transition: color 0.3s ease;
}
.main-nav-list .nav-link a:hover .nav-icon path {
  stroke: #E0E0E0;
}

/* ეს აიკონი ჯიუტობს */
.action-nav-list {
  display: flex;
  gap: 13px;
  align-items: center;
}
.action-nav-list a {
  display: flex;
  align-items: center;
  width: 100%;
  box-sizing: border-box;
  text-decoration: none;
  color: #898989;
  border-radius: 8px;
  gap: 10px;
}
.action-nav-list a:hover {
  background-color: #202020;
  color: #E0E0E0;
}

.icon-nav {
  display: flex;
  list-style: none;
  align-items: center;
}

.library-content-header {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding-bottom: 21px;
}

.main-content-header {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.top-nav-link {
  display: flex;
  align-items: center;
  height: 40px;
  gap: 15px; /* მაინც სხვადასხვა დაშორებაა აიკონებს შორის */
  justify-content: center;
}

.cards-section {
  display: flex;
  flex-direction: column;
  gap: 20px;
  margin-bottom: 30px;
}

.card {
  display: flex;
  flex-direction: column;
  gap: 6px;
  background-color: #060606;
  border-radius: 8px;
  width: 170px;
  position: relative;
  margin-top: 15px;
}
.card::before, .card::after {
  content: "";
  position: absolute;
  left: 50%;
  transform: translateX(-50%);
  height: 10px;
  border-radius: 8px 8px 0 0;
  z-index: -1;
}
.card::before {
  top: -6px;
  width: 90%;
  background-color: rgba(255, 255, 255, 0.2);
}
.card::after {
  top: -12px;
  width: 80%;
  background-color: rgba(255, 255, 255, 0.1);
}
.card img {
  width: 170px;
  border-radius: 4px;
}
.card h3 {
  padding: 0;
  padding-top: 6.5px;
}
.card p {
  padding: 0;
  margin: 0;
  padding-top: 8px;
}

.card-container {
  overflow: auto;
  display: flex;
  gap: 11px;
}

.library-card-grid {
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(170px, 1fr));
  gap: 11px;
}

.album-round-item {
  border-radius: 50% !important;
  aspect-ratio: 1/1 !important;
} /* ვააახ, მაინც არ ეშველა */
.grid-item {
  position: relative;
  display: inline-block;
}
.grid-item .pin-icon {
  position: absolute;
  right: 8px;
  background-color: #111111;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  z-index: 10;
}
.grid-item .pin-icon svg {
  width: 35px;
  height: 35px;
}

.pin-icon-down {
  position: absolute;
  bottom: 40px;
  right: 40px;
  background-color: #111111;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  z-index: 10;
}
.pin-icon-down svg {
  width: 35px;
  height: 35px;
}

.player {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background-color: #333842;
  border-radius: 10px;
  width: 100%;
  height: 100%;
}
.player:hover {
  background-color: #202020;
}

.player-left {
  display: flex;
  align-items: center;
  gap: 15px;
  justify-content: flex-start; /* მიაწექი მარცხნივ */
  flex: 1; /* დაიკავოს თანაბარი ადგილი */
}

.player-right {
  display: flex;
  align-items: center;
  gap: 15px;
  justify-content: flex-end; /* მიაწექი ბოლომდე მარჯვნივ */
  flex: 1; /* დაიკავოს თანაბარი ადგილი */
  padding-right: 20px; /* დაამატე პატარა დაშორება კიდიდან, რომ სუნთქავდეს */
}

.space {
  width: auto !important;
  flex-shrink: 0;
  padding: 0 10px;
}

.space-for-icons {
  display: grid;
  grid-template-columns: 1fr 1fr;
  padding: 0 20px;
}

.song-info {
  display: flex;
  align-items: center;
}

.song-text {
  padding-left: 15px;
}

.player .player-left .song-info .current-song {
  width: 51px !important;
  height: 51px !important;
  min-width: 51px; /* ვერ გაიზარდა ეს ფოტო ვერაფრით */
  min-height: 51px; /* დავამატოთ ესეც */
  flex-shrink: 0; /* აუკრძალოთ შეკუმშვა/გაწელვა */
  object-fit: cover;
  border-radius: 3px; /* მაინც არ ეშველა(((((((((((((((( */
}

/**
* @license
*
* Font Family: Satoshi
* Designed by: Deni Anggara
* URL: https://www.fontshare.com/fonts/satoshi
* © 2026 Indian Type Foundry
*
* Satoshi Light 
* Satoshi LightItalic 
* Satoshi Regular 
* Satoshi Italic 
* Satoshi Medium 
* Satoshi MediumItalic 
* Satoshi Bold 
* Satoshi BoldItalic 
* Satoshi Black 
* Satoshi BlackItalic 
* Satoshi Variable (Variable font)
* Satoshi VariableItalic (Variable font)

*
*/
@font-face {
  font-family: "Satoshi-Light";
  src: url("../assets/fonts/WEB/fonts/Satoshi-Light.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-Light.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-Light.ttf") format("truetype");
  font-weight: 300;
  font-display: swap;
  font-style: normal;
}
@font-face {
  font-family: "Satoshi-LightItalic";
  src: url("../assets/fonts/WEB/fonts/Satoshi-LightItalic.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-LightItalic.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-LightItalic.ttf") format("truetype");
  font-weight: 300;
  font-display: swap;
  font-style: italic;
}
@font-face {
  font-family: "Satoshi-Regular";
  src: url("../assets/fonts/WEB/fonts/Satoshi-Regular.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-Regular.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-Regular.ttf") format("truetype");
  font-weight: 400;
  font-display: swap;
  font-style: normal;
}
@font-face {
  font-family: "Satoshi-Italic";
  src: url("../assets/fonts/WEB/fonts/Satoshi-Italic.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-Italic.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-Italic.ttf") format("truetype");
  font-weight: 400;
  font-display: swap;
  font-style: italic;
}
@font-face {
  font-family: "Satoshi-Medium";
  src: url("../assets/fonts/WEB/fonts/Satoshi-Medium.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-Medium.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-Medium.ttf") format("truetype");
  font-weight: 500;
  font-display: swap;
  font-style: normal;
}
@font-face {
  font-family: "Satoshi-MediumItalic";
  src: url("../assets/fonts/WEB/fonts/Satoshi-MediumItalic.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-MediumItalic.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-MediumItalic.ttf") format("truetype");
  font-weight: 500;
  font-display: swap;
  font-style: italic;
}
@font-face {
  font-family: "Satoshi-Bold";
  src: url("../assets/fonts/WEB/fonts/Satoshi-Bold.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-Bold.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-Bold.ttf") format("truetype");
  font-weight: 700;
  font-display: swap;
  font-style: normal;
}
@font-face {
  font-family: "Satoshi-BoldItalic";
  src: url("../assets/fonts/WEB/fonts/Satoshi-BoldItalic.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-BoldItalic.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-BoldItalic.ttf") format("truetype");
  font-weight: 700;
  font-display: swap;
  font-style: italic;
}
@font-face {
  font-family: "Satoshi-Black";
  src: url("../assets/fonts/WEB/fonts/Satoshi-Black.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-Black.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-Black.ttf") format("truetype");
  font-weight: 900;
  font-display: swap;
  font-style: normal;
}
@font-face {
  font-family: "Satoshi-BlackItalic";
  src: url("../assets/fonts/WEB/fonts/Satoshi-BlackItalic.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-BlackItalic.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-BlackItalic.ttf") format("truetype");
  font-weight: 900;
  font-display: swap;
  font-style: italic;
}
/**
* This is a variable font
* You can control variable axes as shown below:
* font-variation-settings: wght 900.0;
*
* available axes:
'wght' (range from 300.0 to 900.0
*/
@font-face {
  font-family: "Satoshi-Variable";
  src: url("../assets/fonts/WEB/fonts/Satoshi-Variable.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-Variable.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-Variable.ttf") format("truetype");
  font-weight: 300 900;
  font-display: swap;
  font-style: normal;
}
/**
* This is a variable font
* You can control variable axes as shown below:
* font-variation-settings: wght 900.0;
*
* available axes:
'wght' (range from 300.0 to 900.0
*/
@font-face {
  font-family: "Satoshi-VariableItalic";
  src: url("../assets/fonts/WEB/fonts/Satoshi-VariableItalic.woff2") format("woff2"), url("../assets/fonts/WEB/fonts/Satoshi-VariableItalic.woff") format("woff"), url("../assets/fonts/WEB/fonts/Satoshi-VariableItalic.ttf") format("truetype");
  font-weight: 300 900;
  font-display: swap;
  font-style: italic;
}

/*# sourceMappingURL=main.cs.map */
