# Bare Bears Spotify Clone

A recreation of Spotify's web interface built with HTML and SCSS as part of the 10X Academy markup exam.

## Pages

- **Home** (`index.html`) — main feed 
- **Discover** — carousel with featured albums
- **Search** — recent searches and browse-all genre grid
- **Library** — grid and list views for saved content
- **Playlist** — track listing with album header
- **Album** — similar to playlist, album-specific layout
- **Artist** — artist profile with popular tracks, discography nav, and related artists
- **Artist About** — biography, stats, and listener data
- **Artist Albums** — grid/list views of an artist's discography
- **Podcast** — podcast page with episode list
- **Episode** — single episode detail view
- **Song** — song detail page with lyrics, credits, genres, and artist info

## Tech Stack

- HTML5 (semantic markup)
- SCSS compiled to CSS
- CSS Grid for page layout, Flexbox for component alignment
- No JavaScript — all interactions are CSS-only (hover states, scroll-snap, scroll-driven animations)

## Project Structure

```
├── index.html
├── pages/                  # all subpages
├── assets/
│   ├── fonts/              # Satoshi variable font
│   ├── icons/              # SVG icons
│   ├── images/             # album covers, artist photos
│   ├── artist-section/     # artist page specific assets
│   └── search-card/        # search/browse card images
├── scss/
│   ├── abstracts/          # variables, mixins, functions
│   ├── base/               # reset, font-face declarations
│   ├── layout/             # grid layout, sidebar, header, player
│   └── pages/              # page-specific styles
├── css/
│   └── main.css            # compiled output
```

## How to Run

1. Clone the repo
2. Open `index.html` in a browser
3. To modify styles, edit the `.scss` files and compile:
   ```
   npx sass scss/main.scss css/main.css
   ```

## Responsive

The layout adapts at `1240px` — sidebar collapses, header moves to the bottom as a mobile nav bar, and the player becomes a fixed overlay. Additional breakpoints at `900px`, `768px`, and `640px` handle smaller screens.

## Team

**Bare Bears** — built as a pair programming project at 10X Academy.
