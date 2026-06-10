# 🎧 Spotify Clone

Spotify UI Clone — **HTML · SCSS (Sass) · JavaScript · Git/GitHub**

---

## 📂 Project Structure

```
/project-root
├── /dist                  # Compiled, browser-ready
│   ├── /css               # style.css
│   ├── /js
│   └── /assets
├── /src
│   ├── /scss
│   │   ├── /abstracts     # _variables.scss, _mixins.scss
│   │   ├── /base          # _reset.scss, _typography.scss
│   │   ├── /components    # _navbar.scss, _sidebar.scss, _card.scss
│   │   ├── /layout        # _homepage.scss, _search.scss
│   │   └── main.scss      # Imports everything → compiles to dist/css/style.css
│   └── /pages             # homepage.html, search.html
└── index.html
```

---

## 🏗 SCSS Architecture

Import order in `main.scss`: **abstracts → base → components → layout**

| Folder | Files | Purpose |
|--------|-------|---------|
| `/abstracts` | `_variables.scss` | Colors, fonts, breakpoints, sidebar/navbar/player sizes |
| | `_mixins.scss` | Responsive helpers, flex-center, text-overflow |
| `/base` | `_reset.scss` | Clears browser defaults (margin, padding, box-sizing) |
| | `_typography.scss` | h1–h3, p, utility classes (.text-muted, .text-truncate) |
| `/components` | `_navbar.scss` | Fixed top bar — next to sidebar; full-width on mobile |
| | `_sidebar.scss` | Fixed left menu — extends to player; hidden on mobile |
| | `_card.scss` | Music card — image, title, hover effect |
| `/layout` | `_homepage.scss` | .main-content layout + cards grid (Recently Played, Made for You) |
| | `_search.scss` | Categories grid + search results (JS-toggled) |

> `/abstracts` **emits no CSS** — all other files depend on it, so it imports first.
> `/layout` always comes last — it positions components, it doesn't create them.

### Page Layout (Homepage & Search)

```
┌──────────────────────────────────────┐
│  NAVBAR (fixed, z-index: 100)        │
├───────────┬──────────────────────────┤
│           │  .main-content / .search │
│  SIDEBAR  │  overflow-y: auto ←scroll│
│  (fixed)  │  margin: navbar + player │
│           │  + sidebar               │
├───────────┴──────────────────────────┤
│  FOOTER PLAYER (fixed)               │
└──────────────────────────────────────┘
```

---

## 🔑 Commit Keywords

| Keyword | Usage |
|---------|-------|
| `add` | New file or feature |
| `fix` | Bug fix |

```bash
git commit -m "add: search page layout"
git commit -m "fix: navbar responsive issue"
```

---

## 👨‍💻 Team

| Name | Responsibilities |
|------|-----------------|
| **Noah** | File structure · Navbar · Footer player · Homepage |
| **Sandro** | Library · PowerPoint presentation |
| **Giorgi** | Search page · README.md |

---

## 🚀 How to Run

```bash
git clone https://github.com/your-username/spotify-clone.git
cd spotify-clone
# open index.html in browser
```

---

📌 **Giorgi Chutlashvili, Sandro Tvaliashvili, Noah Kvirkveliar** — Frontend Developer 
