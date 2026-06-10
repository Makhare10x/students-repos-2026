# Spotify UI Clone  
### Code-Warriors Team Project

**Team Members:**  
- Eka Kakablishvili  
- Mari Begiashvili  

**Design file:**  
https://www.figma.com/design/jrlUWJdbxTc2bKd5dpRa5r/10X-markup-exam-project---Spotify?node-id=94-2201&t=9YtEaAuC6ANtHMwX-0

---

# Project Overview

This project is a **Spotify-style web interface clone** built as part of a frontend markup assignment.  
The goal of the project was to reproduce the design from Figma while following modern frontend engineering practices.

The implementation focuses on:

- semantic HTML structure  
- modular SCSS architecture  
- responsive layout strategy  
- reusable UI components  
- collaborative Git workflow  

The project replicates the **Spotify desktop interface layout**, including navigation, content browsing sections, and the music player UI.

---

# Technologies Used

- **HTML5**
- **SCSS (Sass)**
- **Vanilla JavaScript**
- **Git & GitHub**

No external UI libraries or frameworks were used in order to practice **core frontend layout and styling techniques**.

---

# Project Architecture

The project follows a **modular Sass architecture** for better scalability and maintainability.

styles/
│
├── abstracts/
│ ├── _variables.scss
│ ├── _mixins.scss
│ └── _functions.scss
│
├── base/
│ ├── _reset.scss
│ ├── _base.scss
│ └── _typography.scss
│
├── layout/
│ ├── _app-layout.scss
│ ├── _header.scss
│ ├── _sidebar.scss
│ └── _player.scss
│ └── _mobile-nav.scss
│
├── components/
│ ├── _cards.scss
│ ├── _buttons.scss
│ └── _chips.scss
│
└── main.scss


All partial files are imported into **main.scss**, which compiles into the final stylesheet.

Compiled CSS files are excluded from version control.

---

# REM System

The project uses a **10px-based REM system** for easier spacing and typography control.

```scss
html {
  font-size: 62.5%;
}

This makes: 1rem = 10px
This approach simplifies responsive spacing calculations and improves readability of styles.

This makes:

1rem = 10px

This approach simplifies responsive spacing calculations and improves readability of styles.

#Layout Structure

The interface is divided into four main areas:

1. Header
  Top navigation containing quick access buttons and user actions.

2. Sidebar
  Navigation panel with library sections, playlists, and expandable submenu.

3. Main Content Area
  Scrollable content containing different sections such as:
  – Made For You
  – Mixes
  – Artists
  – Browse categories
4. Music Player
  A fixed bottom player that displays the current track, playback controls, and additional options.

*** Implemented Features

The following UI components and behaviors were implemented:

#Navigation
  – header navigation with icon buttons
  – sidebar navigation with active states
  – collapsible playlist submenu

#Content Sections
  – horizontal card sliders
  – browse category cards
  – mix and playlist cards
  – artist and album displays

#Music Player
  – fixed bottom player bar
  – playback control buttons
  – progress bar
  – track information display

#UI Interactions
  – horizontal scrolling with arrow navigation
  – hover effects for cards and buttons
  – expandable sidebar playlists
  – lock button toggle in header

#Horizontal Slider Implementation

Horizontal browsing sections were implemented without external libraries.

The slider behavior uses:
  – overflow-x: auto
  – scroll-behavior: smooth
  – display: flex
  – JavaScript scrollBy() for arrow navigation

This allows card rows to behave like a lightweight carousel, similar to Spotify’s browsing interface.

#Responsive Strategy

The project follows a mobile-first responsive design approach.

#Breakpoints:
Mobile  → default styles
Tablet  → 768px
Desktop → 1200px 

Responsive behavior is handled through Sass mixins.

#Layout Adaptations

*Mobile
  - simplified layout
  - stacked content sections
  - sidebar hidden or collapsed

*Tablet
  - adjusted spacing
  - flexible card layout

*Desktop
  - full sidebar navigation
  - horizontal content rows
  - fixed music player alignment

#Git Workflow
The project was developed using a branch-based Git workflow.

#Branch Structure:
main
│
develop
│
feature branches

#Workflow
1. Each feature is developed on a separate branch.
2. Feature branches are merged into develop.
3. After integration and testing, develop is merged into main.

This approach allows safe collaboration between team members and minimizes merge conflicts.

#Reusable Components
Several UI elements were built as reusable components:
  - card components
  - button styles
  - filter chips
  - slider arrows
  - navigation links

This improves maintainability and keeps styling consistent across the project.

#Challenges

During development we faced several challenges:
  - aligning the fixed player with the main layout
  - implementing horizontal sliders without libraries
  - maintaining consistency across multiple card components
  - handling merge conflicts during team collaboration

These challenges were solved through improved structure, modular styling, and clear Git workflow practices.

#What We Learned
Through this project we practiced:
  - building complex layouts using Flexbox and Grid
  - structuring large stylesheets with modular SCSS
  - translating Figma designs into responsive UI
  - implementing lightweight UI interactions
  - collaborating through Git branching workflows

#Running the Project
1. Clone the repository
  git clone <https://github.com/Ekiek/Code-Warriors.git>
2. Navigate to the project folder
  Navigate to the project folder
3. cd Code-Warriors
  sass styles/main.scss styles/main.css --watch
4. Open index.html in the browser.

#Disclaimer

This project is a frontend markup exercise created for educational purposes.
It recreates the visual interface of Spotify but does not include backend functionality or real music playback.