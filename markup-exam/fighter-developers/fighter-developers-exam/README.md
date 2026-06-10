# Spotify Clone — Fighter Developers Team

## Project Overview

Spotify - music streaming web application built as a team exam project. The app replicates Spotify's core UI/UX including a multi-page layout with a persistent sidebar, fixed footer player, and dark theme design system.

**Live pages:** Home, Discover, Search, Library, Albums, Playlists, Song


## Team Contributions
- Giorgi
- Pavel
- Eka


## Tech Stack

- HTML5
- CSS3 / SASS
- JavaScript (Vanilla)
- Git / GitHub


## Project Structure

```
fighter-developers-exam/
├── assets/
│   ├── fonts/              # Satoshi font family
│   ├── images/
│   │   ├── icon-images/    # Navigation & playback icons
│   │   ├── layout-images/  # Album covers & artist photos
│   │   ├── discover-page/  # Discover section artwork
│   │   └── search-page/    # Browse category images
│   ├── scripts/
│   │   └── library-btn.js  # Library grid/list toggle
│   └── styles/
│       ├── css/styles.css  # Compiled stylesheet
│       └── sass/           # SASS source files
├── pages/
│   ├── albums.html
│   ├── discover.html
│   ├── library.html
│   ├── play-list.html
│   ├── search.html
│   └── song.html
└── index.html
```


## Pages & Features

### Home (`index.html`) [Pavle]
- Category filter tabs: All, Music, Podcasts, Audiobooks
- Horizontally scrollable card sections: Made For You, Top Mixes, Favorite Artists, Albums, Audiobooks, Podcasts, Episodes

### Albums (`pages/albums.html`)  [Pavle]
- Full album metadata (artist, year, track count, total duration)
- Track listing table with number, title, duration, and favorite columns
- Action buttons: Play, Shuffle, Add, Add to Playlist, Download, Share

### Playlist (`pages/play-list.html`)  [Pavle]
- Extended track table including Album column
- Track thumbnails inline in table rows
- Genre tags and featured artist info

### Discover (`pages/discover.html`)  [Eka]
- Horizontal genre filter bar: Music, EDM, Indie, Pop, Rock, Alt Rock, Country, R&B, Hip-Hop, Podcast, Audiobooks
- Featured content cards with carousel navigation

### Search (`pages/search.html`)  [Eka]
- Recent Searches with quick-remove buttons
- Browse All grid: color-coded category cards for Discover & Genres sections

### Library (`pages/library.html`)  [Giorgi]
- Toggle between grid and list view via JS

### Song (`pages/song.html`)  [Pavle]
- Song detail card with artwork and metadata
- Embedded lyrics with Translate, Comments, and Text Size options

### Podcast (`pages/podcast.html`)  [Giorgi]
- podcast page with list of eposodes

## Layout

All pages share a consistent fixed layout:

```
┌─────────────────────────────────────────────────┐
│               TOP HEADER                        │
├───────────┬─────────────────────────┬───────────┤
│           │                         │           │
│  LEFT     │     MAIN CONTENT        │   RIGHT   │
│  ASIDE    │   (scrollable)          │   ASIDE   │
│  (260px)  │                         │  (toggle) │
│           │                         │           │
├───────────┴─────────────────────────┴───────────┤
│               FOOTER PLAYER (90px)              │
│                                                 │
└─────────────────────────────────────────────────┘
```

**Mobile (≤390px):** Sidebar hidden, footer becomes bottom navigation bar.


## Team Decisions

### Development Approach
- ვმუშაობდით ცალკე branch-ებით, ცვლილებები ერთიანდებოდა pull request-ების საშუალებით.

### Task Management
- დავალებების განაწილებისთვის გამოვიყენეთ **GitHub Issues**.

### Team Communication
- დღის ბოლოს გამოშვებით გვქონდა მოკლე შეხვედრები, სადაც ვათანხმებდით პროგრესს, ბლოკერებს და შემდეგ ნაბიჯებს.

### Naming Convention
- კლასების დასარქმევად გამოვიყენეთ **BEM** მიდგომა.

### Team Lead
- გუნდს ჰყავდა **Team Lead: [Eka]** — პასუხისმგებელი PR-ების გადახედვაზე, სტრუქტურული გადაწყვეტილებებზე და პროგრესის კოორდინაციაზე.


## Notes

- CSS-only sidebar toggle using the checkbox hack (`:checked` selector)
- Right sidebar shown via CSS `:target` selector (`#right-aside:target`) — no JS needed
- Custom scrollbar styling with `-webkit-scrollbar`
- Semantic HTML: `<figure>`, `<figcaption>`, `<table>` used throughout
- Base font size set to `62.5%` on `html` for easy `rem` calculations
