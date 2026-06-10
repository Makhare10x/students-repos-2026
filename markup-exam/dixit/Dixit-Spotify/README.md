**Figma Design:** (https://www.figma.com/design/jrlUWJdbxTc2bKd5dpRa5r/10X-markup-exam-project---Spotify?node-id=298-16461&t=7WcpyIlTNhAY3o8r-0)

# Dixit-Spotify Clone Project

## 📌 Project Overview

This project is a functional Spotify clone designed with a modular architecture and a focus on fluid responsiveness. The development process utilizes HTML5, CSS3, and SASS for a professional and scalable frontend structure, while Git and GitHub are used for version control and team collaboration.

---

## 🛠 Project Architecture & Setup

The project structure and core styles were established with the following technical features:

- **HTML Skeleton:** A complete semantic structure including Header, Main, and Footer sections.
- **Modular SASS & CSS:** Dedicated SASS files for each section, compiled into optimized CSS to ensure clean and maintainable code.
- **Version Control:** Implementation of Git for tracking changes and GitHub for repository management and team synchronization.
- **Global Variables:** Use of core SCSS variables and reusable mixins for design consistency.
- **Fluid Typography:** Responsive font sizes implemented via the `clamp()` function for an optimal experience across all devices (from 320px to 1440px).

---

## 👥 Team Responsibilities

The project tasks have been distributed among the team members to ensure efficient development:

| Team Member     | Assigned Modules & Sections                                                                                                                                                |
| :-------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Nora (Lead)** | Navigation (Header & Footer & Sidebar Navigation), Albums and Artists Sections. Queue Actions, Now playing Actions mobile and desktop. Media Player on mobile and Desktop. |
| **Lana**        | Home, Search and Library sections                                                                                                                                                   |
| **Shalva**      | Profile and Playlist sections                                                                                                                                              |

---

## 🚀 Technical Goals

- **Mobile-First Design:** Ensuring the UI is perfected for mobile before scaling to desktop.
- **Version Control Workflow:** Using Git branches and pull requests for organized collaboration.
- **Scalability:** Leveraging SASS partials and variables for easy global updates.
- **Interactivity:** Smooth transitions and animations for a native app-like feel.

## 🚀 LatestUpdates (March 6, 2026)

**By Nora**
Implemented a fully responsive mobile-only footer navigation using a semantic <figure> and <figcaption> structure. The system features a pure CSS tab-switching logic (no JavaScript) using radio buttons and :checked selectors, enhanced with smooth fadeIn animations. Visuals are managed through SCSS variables for gradients and interactive states, while project hygiene was improved by untracking compiled CSS files and adding new SVG icons for a cleaner repository.

## 🚀 LatestUpdates (March 7, 2026)

**By Nora**
Refactored the bottom navigation to resolve icon scaling issues and improve UI responsiveness. Replaced the previous layout with a CSS Grid-based system that overlays outline and filled icons within the same cell, ensuring perfect alignment during transitions. Visual size discrepancies for the Home and Search filled icons were corrected using specific transform: scale() adjustments to compensate for SVG geometry differences. Additionally, implemented a Spotify-style glassmorphism effect on the footer using backdrop-filter: blur(), removed the default checked state from the Home tab to prevent pre-filled icons on refresh, and optimized the overall codebase by introducing reusable SCSS mixins for flexbox, glass effects, and positioning.

## 🚀 LatestUpdates (March 8, 2026)

**By Nora**
Today’s progress focused on refactoring the music player and navigation for better accessibility and UI precision. I adopted a component-based architecture, breaking down the UI into modular sections and managing them through dedicated SASS partials for cleaner, more maintainable code.

I replaced generic containers with semantic HTML5 (such as <section>, <figure>, and <time>) and implemented a CSS-only expansion using the "checkbox hack" to eliminate JavaScript dependency. The playback bar now features a dynamic SASS-managed marquee animation for long titles and a custom-styled <input type="range"> for a sleek seek bar. Additionally, I optimized the bottom navigation using CSS Grid to fix icon scaling issues, applied a glassmorphism effect via backdrop-filter, and streamlined the entire codebase with reusable SCSS mixins.

**By Lana 03.07**
Dixit-Spotify: Home Section Architecture
By Lana Tcholaria

This project is a high-fidelity music streaming interface built with a mobile-first approach, focusing on fluid responsiveness, modular SCSS architecture, and interactive UI components.

:tools: Project Architecture
I was responsible for the core structure and styling of the Home Section, ensuring a seamless transition between various mobile viewports and desktop layouts. The codebase has been fully refactored from a monolithic stylesheet into a component-based design system.

:star2: Key Technical Features

1. Algorithmic Theme Engine
   I transitioned from manual CSS styling to a logic-driven SASS architecture. By implementing dynamic @for loops combined with SASS Interpolation (#{$i}), I automated the theme assignment for over 20 unique album components.

2. Parallel Logic Execution
   Within the \_home-loops.scss partial, I engineered parallel loops that simultaneously manage:

Metadata Typography: Mapping unique color tokens to album subtitles.

Multi-layered Background Effects: Automating background-color and opacity for stacked album cover wrappers.

3. Fluid Responsive Scaling
   I implemented a custom linear interpolation formula using clamp() and calc() within the $card-dimensions map. This ensures that cards scale perfectly from 15rem to 25rem without excessive media queries.

4. Pure CSS Interactivity
   I engineered the "Customize Feed" menu using the Checkbox Hack (:checked ~ selector). This allows for a smooth, hardware-accelerated 1s slide-in animation from the bottom on mobile devices without any JavaScript overhead.

:bulb: Challenges & Solutions (By Lana)
One of the primary challenges was managing the Stacking Context within the .home container. Initially, decorative background elements were disappearing under the parent's background color. I resolved this by re-calibrating the z-index hierarchy and ensuring that each overlapping component exists within a stable stacking context.

\_home-loops.scss: Houses all algorithmic styling and theme mapping.

\_recent-played.scss: Encapsulates mobile-specific grid logic and responsive visibility.

\_home-nav.scss: Isolates navigation, hover effects, and the icon-toggle system.

Refactoring Logs: Every major structural change, such as the isolation of home-loops.scss, was documented to ensure that the project's evolution is clear to other developers. This reflects a professional "Creator" mindset, where the code isn't just written, but managed with precision and clarity.

## 🚀 LatestUpdates (March 9, 2026)

**By Nora**

Refactored the media player architecture by modularizing component styles into independent SASS files via the @use rule, ensuring a highly maintainable and scalable codebase. This update introduces a custom-engineered mobile playback slider with specialized -webkit-slider-thumb styling and a desktop-specific media player interface, both optimized for seamless responsiveness. To enhance UI consistency and code reusability, I implemented advanced SCSS mixins for complex hover animations—utilizing CSS filters, transforms, and cubic-bezier transitions—and centralized layout logic with a flexible flex-center mixin to eliminate redundancy across the control panels and footer navigation.

## 🚀 LatestUpdates (March 10, 2026)

**By Nora**
"I have successfully developed a dynamic, mobile-first Spotify clone using SCSS and Flexbox, featuring a fully responsive media player and navigation system that ensures a polished user experience on displays up to a 1754px maximum width. By leveraging advanced CSS techniques—such as the :has() selector, @for loops, and strategic media queries—I implemented a sophisticated sidebar and header with interactive, multi-state icons that react to active states without relying on JavaScript. The layout utilizes dynamic properties like flex-grow and max-width to prevent element overlapping and maintain design integrity across various resolutions, including 1440px. Furthermore, I managed complex UI states, such as a toggleable 'bottom-sheet' customization menu and interactive dropdowns using HTML <details> and <summary> tags, while carefully handling z-index layering and overflow properties to preserve visual consistency and rounded aesthetics during all user interactions."
**by lana 03.08**
🚀 Upcoming Phase: Search Functionality
Branch: feat/search-bar

I have initialized a new feature branch to begin the development of the global Search Bar component. This phase will focus on:

Dynamic UI Construction: Building a high-performance search input with glassmorphic styling to match the Spotify aesthetic.

State Management: Preparing the architecture for real-time filtering and user input handling.

Responsive Integration: Ensuring the search interface adapts seamlessly across mobile and desktop breakpoints.

📝 Git Workflow Note
To maintain a clean and professional development history, I am following a strict Feature Branch Workflow. The feat/search-bar branch will host all atomic commits related to this component before being integrated into the main architecture.
**Lana**
Adaptive Geometry Engine (By Lana): I expanded the $card-dimensions map to incorporate complex linear interpolation for the Search component.

Responsive Scaling Logic: By applying the clamp() function with calculated view-port units, I ensured that the search bar maintains a consistent visual weight from 320px to 700px, scaling dynamically without any sudden breakpoint jumps.

**lana**
📜 README Section: Advanced Grid Implementation (By Lana)  
Responsive Grid Architecture : I engineered a high-performance grid container for the search categories, utilizing repeat(2, auto) to maximize space efficiency on mobile viewports.
Interpolated Component Scaling: Integrated a sophisticated two-tier fluid scaling logic into the playlist-card class, enabling precise geometric growth based on the project's specific breakpoint targets (320px to 1754px).
Typography Layout: Applied strict width constraints to card headings to maintain consistent visual rhythm and prevent layout breaking during text expansion

**lana**
🚀 Automated Theming Engine (\_search-loops.scss)
The core of the discovery interface's visual variety is powered by a custom-built SCSS Theming Engine. Instead of manually assigning classes to dozens of HTML elements, I developed a programmatic approach to distribute colors dynamically.

💎 Architectural Highlights (By Lana)
Modular Organization: By isolating the theming logic into \_search-loops.scss, I ensured the primary layout files remain clean and focused on structure.

Cyclic Pattern Logic: I leveraged SASS @for loops combined with :nth-child selectors to create an infinite color cycle. Whether a section has 4 cards or 40, the colors repeat seamlessly based on the length of the provided array.

Contextual Branding: Each content category features a curated color palette designed to improve user recognition:

Podcasts: Uses deep greens (#006450) to match brand identity.

Entertainment: Focuses on high-energy reds (#EB1E32).

Audiobooks: Employs sophisticated purples and blues (#8D67AB).

🛠️ Technical Implementation
The engine calculates the background color based on the element's position in the DOM relative to the color array length:

SCSS
// Logic example used across 6 major sections:
@for $i from 1 through length($provided-colors) {
&:nth-child(#{length($provided-colors)}n + #{$i}) {
background-color: nth($provided-colors, $i);
}
}
📈 Key Benefits
DRY (Don't Repeat Yourself): The same logic governs 6 different sections, reducing total CSS output significantly.

Zero-Maintenance Scaling: Adding new cards to the HTML requires no additional CSS; the loop automatically "paints" new items as they appear.

Visual Fidelity: Precise HEX mapping ensures the UI maintains the signature high-contrast, vibrant aesthetic of modern streaming platforms.
**📈**
search-Section: Responsive Architecture **By Lana**
Adaptive Grid Logic (By Lana): I engineered a 5-tier responsive system that dynamically adjusts content density based on the device width.

Desktop Optimization: At the 991px breakpoint, the interface transitions from a vertical grid to a horizontal scrolling experience, utilizing custom mixins to manage overflow.

Proportional Scaling: Adjusted internal card geometry (typography margins and asset offsets) within media queries to preserve the high-fidelity aesthetic on larger screens.

**lana 10.03**
Feature Integration Complete (By Lana): I successfully merged the comprehensive search module into the production branch after a rigorous peer review process.

Production Deployment: The codebase now includes a fully optimized, 5-tier responsive discovery interface with automated SCSS theming.

Branch Lifecycle Management: Followed industry-standard Gitflow by isolating development within feat/search-bar and performing a clean merge into main once all quality benchmarks were met.

**Library Roadmap (By Lana)**
🚀 Recent Updates & Features
🛠 Library Navigation & Interaction Logic
Implemented a fully functional, interaction system for the library sidebar.

* **Custom Action Bar:** Built using **CSS Grid** with a 2-column layout (`repeat(2, auto)`) for precise alignment of global controls.
Pure CSS Dropdown: Developed a "Group" selection menu using the Checkbox Hack. 
   Utilizes the `:checked` pseudo-class combined with the sibling selector (`~`) to toggle `.list-to-show` visibility.
View Switcher:Added a secondary toggle for the "Recents" section.
Users can switch between **Grid** and **List** icons dynamically.
Layout Stability:Implemented `absolute positioning` for dropdown elements to ensure that appearing menus do not cause layout shifts (CLS) in the grid structure.
🎨 Technical Highlights
SASS Integration:Used nested selectors and variables for theme consistency.
Accessibility:Connected inputs and labels via `id` and `for` attributes to ensure keyboard and click functionality.

*The library* sidebar now features a fully interactive accordion system. Using only CSS, users can expand and collapse sections (Playlists, Albums, etc.) with smooth visual feedback, including rotating icons and persistent states.
# 🚀 Recent Progress: Album Section & Navigation Logic(March 11, 2026)

**By Nora**

### Key Enhancements:

#### 1. Album Section Implementation

- **Structural Foundation:** Developed a semantic HTML structure using `<section>`, `<article>`, and `<table>` for the tracklist.
- **Sidebar & Metadata:** Added an `<aside>` sidebar featuring high-quality album art, genre tags, and contributing artists.
- **Dynamic Grid Layout:** Utilized **CSS Grid** to create a professional two-column layout (`tracklist` vs `sidebar`) that automatically stacks on smaller viewports.
- **Interactive UI:** Added hover effects for track rows and interactive icons (Play, Shuffle, Like, etc.) with smooth transitions.

#### 2. Advanced Navigation Logic (No-JS Approach)

- **State Management:** Used the **CSS `:has()` selector** to manage UI states based on hidden radio inputs (`#tab-1` to `#tab-14`).
- **Mobile Fallback Experience:** - Implemented a smart fallback where desktop-specific tabs (like Albums or Playlists) default the view to the **Home** section on mobile.
    - Synchronized the "Home" navigation icon to remain active/highlighted when these sub-sections are open on mobile, ensuring a seamless user experience.
- **Section Visibility:** Optimized `display` properties to prevent desktop sections from overlapping the mobile UI.

#### 3. Code Refactoring & Git Workflow

- **SASS Modularization:** Cleaned up the project structure by importing the `_album.scss` module into the main stylesheet.
- **Conflict Resolution:** Successfully resolved complex **Git merge conflicts** in `index.html` after pulling the latest changes from the `main` branch.
- **Asset Integration:** Organized and linked new SVG icons and artist images for the Daft Punk - _Random Access Memories_ album.

### Tech Stack Used:

- **HTML5** (Semantic elements, Tables)
- **SASS/SCSS** (Mixins, Variables, Grid, Flexbox, `:has()` selector)
- **Git** (Branch management, Conflict resolution)

## 📝 Project Progress & Technical Updates (12 March, 2026)

**By Nora**

This project has reached a significant milestone in terms of structural integrity and user interaction. The focus was on creating a dynamic, high-performance UI without relying on heavy JavaScript.

## 🛠 Core Technical Achievements:

JS-Free Interactive Components: Successfully implemented the Checkbox + Label technique for Play/Pause, Like, and Navigation buttons. This allows for complex state management (icon toggling, color shifts) using pure CSS logic.

## Advanced State Management with :has():

Leveraged the modern CSS :has() selector to create global UI reactions. For instance, the body and sidebar-nav styles now dynamically update based on the checked state of specific navigation tabs.

## Layout Architecture & Fluidity:

Optimized the Hero Section with border-radius and overflow: hidden, ensuring seamless integration of background covers and gradients.
Refined the Main Content layout for desktops (991px+), implementing a calculated width and margin-left system to accommodate a fixed sidebar.

## Strategic Refactoring:

Cleaned up mobile-specific styles in desktop media queries, specifically removing redundant margin-top and alignment overrides to ensure a pixel-perfect desktop experience.

## 🎨 UI/UX & Styling:

Interactive Feedback: Integrated a custom nav-hover mixin using CSS filters (sepia, saturate, hue-rotate) and scale transforms to provide organic, "alive" feedback to user interactions.

## Dynamic Sidebar Styling:

The sidebar navigation now features an automatic "active" state, where background transparency and borders adjust based on the current active tab.

## Iconography Harmonization:

Standardized icon behaviors using brightness and invert filters, ensuring consistent visual language across the header, player, and artists sections.

## 📝 Project Progress & Technical Updates (13 March, 2026)

**By Nora**

## Progress Notes

Fixed a critical SCSS bug where `body:has()` selectors were nested inside the `body {}` block, causing all main sections to remain hidden. Restructured `_base.scss` by moving section visibility logic outside the body block. Added a Friends Activity aside panel with CSS-only toggle functionality using `body:has(#friends-toggle:checked)`, which slides in from the right and adjusts the main content width accordingly. Also added a songs section with a table layout, hover effects and transitions across all sections, a `text-hover` mixin, and artist navigation with a green underline hover effect. Finally, implemented an artists page with a navigation bar, song table with album and duration columns, and interactive hover effects including a smooth green underline animation on nav items.

