## Spotify Clone — Collaborative Web Project (Exam Colab MNN)

## Project Overview
This project is UI/UX prototype designed to replicate the aesthetic and navigation of Spotify. Our primary goal was to master complex frontend layouts using semantic HTML and advanced SCSS.

**⚠️ Important Note on Project Scope:** This repository represents a **visual UI/UX prototype**. 
**No Audio:** Functional music playback is not implemented.
***Work in Progress:** Due to exam time constraints, only the core navigational pages (Home, Search, library and Song View) were built. Other peripheral pages are not included in this build.


## 👥 Team Structure & Ownership
This application was developed by a two-person team. We divided the application into functional zones to manage our Git workflow efficiently and minimize merge conflicts.

## Team Contributions



**Nona Zabakhidze** | **Song Page, Search Page, Bottom Player Bar, and SCSS setup.** |

## My Individual Contribution
Here are the specific parts of the project I built:

### 1. Song Page (`song.html` & `_song-page.scss`)
* **Responsive Layout:** Built the layout for the song details, including the album cover and playback controls. It adapts from a mobile view to a larger desktop view.
* **No-JS Interactivity:** I used the "Checkbox Hack" (hidden checkboxes) to make the **Lyrics** and **Queue** sections open and close using only CSS.

### 2. Search Page (`search.html` & `_search-page.scss`)
* **Category Flex:** Created the flex layout for the "Browse All" search categories using Flexbox.
* **Sticky Mobile Header:** Made the top search bar sticky so it stays at the top of the screen when you scroll down on a mobile phone.

### 3. Music Player Bar (`_player.scss`)
* **Bottom Player:** Styled the fixed music player at the bottom of the screen, including the play buttons, volume bar, and song info.
* **Scrolling Text:** Wrote a custom `@keyframes` animation so that if a song title is too long, it slowly scrolls sideways (like a marquee).

### 4. SCSS Variables & Mixins
I helped set up and use the SCSS structure to make our styling easier:
* **Variables (`_variables.scss`):** Used variables for our dark theme colors (like `$primary-color: #060606`) and font sizes to keep the design consistent.
* **Mixins (`_mixins.scss`):** Created a few helpful mixins to avoid repeating code. For example, I made mixins for button hover effects and the layout of the search cards.

---
**Mariam Kakhadze** | **Home Page, Library Page, Header, Sidebar and SCSS Setup** |
## My Individual Contribution
Here are the specific parts of the project I built:

### 1. Header Navigation (`index.html` & `_header.scss`)
* **Desktop Nav:** Built the top navigation bar with Home, Discover, and Search on the left, and action icon buttons (notifications, settings, profile) on the right using Flexbox with `justify-content: space-between`.
* **Mobile Bottom Nav:** Created a separate `.mobile-version` section that acts as a bottom navigation bar with 5 icon links, hidden on desktop and shown on mobile via media queries.
* **Active State:** Applied `.active` class to the Home link so the current page is visually highlighted.

### 2. Sidebar (`index.html` & `_sidebar.scss`)
* **Semantic Structure:** Built the sidebar using an `aside` tag containing a `nav` with a `ul > li > a` list structure for all 9 library categories (Pins, Playlists, Liked Songs, Albums, etc.).
* **My Library Header:** Added a standalone link at the top of the sidebar that navigates to `desktop-library.html`, styled separately as the section header.

### 3. Main Scrollable Content (`index.html` & `_main-content.scss`)
* **Filter Chips:** Built the horizontal filter row (All, Music, Podcasts, Audiobooks) using `button` elements with pill-style styling and an `.filter-all` active state.
* **Card Grid Sections:** Structured multiple content sections (Made For You, Your Top Mixes, Favorite Artists, etc.) each using a `.cards-wrapper-grid` container with horizontally scrollable card rows.
* **Card Components:** Each card contains a cover image, title, and subtitle, wrapped in a consistent reusable structure across all sections.

### 4. JavaScript — Horizontal Card Scroll
* **Scroll Buttons:** Instead of creating a separate HTML page for each card section, I used JavaScript to handle the left/right arrow buttons. Clicking them calls `scrollBy()` on the `.scroll-container` element.
* **Smooth Scrolling:** Used `behavior: 'smooth'` to give a glide effect instead of an instant jump. The `scrollAmount` variable is set to `300` and can easily be adjusted.

### 5. Library Page — Desktop & Mobile (`desktop-library.html`, `mobile-library.html` & related pages)
* **Desktop Library:** Built the desktop library view inside the sidebar layout, showing pinned playlists as cards with a filter bar (Recent, Group, Search).
* **Multi-Page Mobile Library:** Built the mobile library as a full-screen section across multiple linked HTML files — `mobile-library.html`, `playlist.html`, `albums.html`, `artists.html`, `folders.html` — connected via `href` links on list items, simulating real app navigation without JavaScript.
* **Accordion-style Lists:** Each category item in the mobile library expands to show its cards inline when navigated to, keeping the experience clean and structured.

## How We Worked
* **Mobile First:** We styled everything for small mobile screens first, and then added desktop styles using `@media (min-width: 768px)`.
* **Git Branches:** I worked on separate branches (like `search`, `player` and `song-page`) to keep my code safe before merging it into the `main` branch. 

---