[README .md](https://github.com/user-attachments/files/25938042/README.md)
# Spotify Web Clone

A markup-based Spotify web clone built as a team exam project. The project replicates the Spotify desktop and mobile UI using HTML, SCSS, and Git workflow — without JavaScript.

---

## Team

| Role | Name | Responsibility |
|------|------|---------------|
| Person A | Lasha Ivanauri | Shared Components |
| Person B | Mariam Sepiashvili | Content Pages |
| Person C | Barbare Bregadze | Media Pages |

---

## Tech Stack

- HTML5 (Semantic markup)
- CSS3
- SCSS (Partial architecture)
- Git / GitHub

---

## Project Structure

```
spotify-clone/
├── index.html
├── assets/
│   ├── fonts/
│   │   ├── Satoshi-Regular.woff2
│   │   ├── Satoshi-Medium.woff2
│   │   ├── Satoshi-Bold.woff2
│   │   └── Satoshi-Black.woff2
│   ├── icons/
│   └── images/
├── scss/
│   ├── main.scss
│   ├── _variables.scss
│   ├── _mixins.scss
│   ├── _reset.scss
│   ├── _layout.scss
│   ├── _sidebar.scss
│   ├── _header.scss
│   └── _player.scss
└── css/
    └── main.css
```

---

## SCSS Architecture

The project uses a partial-based SCSS architecture:

- `_variables.scss` — Design tokens (colors, spacing, typography, sizing)
- `_mixins.scss` — Reusable mixins (flex helpers, truncate, responsive)
- `_reset.scss` — CSS reset and font-face declarations
- `_layout.scss` — Main app wrapper and layout zones
- `_sidebar.scss` — Sidebar navigation styles
- `_header.scss` — Top header styles
- `_player.scss` — Bottom player bar styles

---

## Git Workflow

- `main` — Protected branch, no direct commits
- `feature/shared-components` — Person A (Lasha)
- `feature/content-pages` — Person B (Mariam)
- `feature/media-pages` — Person C (Barbare)

All changes are merged into `main` via Pull Requests.

---

## How to Run

1. Clone the repository:
```bash
git clone https://github.com/lashaivana/10X-markup-exam-project---Spotify.git
```

2. Install SASS:
```bash
npm install -g sass
```

3. Compile SCSS:
```bash
sass --watch scss/main.scss:css/main.css
```

4. Open `index.html` with Live Server

---

## Pages

| Page | File | Status |
|------|------|--------|
| Home | index.html | ✅ Done |
| Search | search.html | ✅ Done |
| Library | library.html | ✅ Done |
| Artist | artist.html | ✅ Done |
| Album | album.html | ✅ Done |
| Playlist | playlist.html | ✅ Done |

---

## Design

Based on Figma design provided by 10X Academy.
Font: [Satoshi](https://www.fontshare.com/fonts/satoshi) via Fontshare.
