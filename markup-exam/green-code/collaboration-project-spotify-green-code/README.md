# Spotify UI Layout (HTML & CSS)

A responsive **Spotify-inspired web interface** built using **semantic
HTML and modern CSS**.\
The project focuses on layout structuring, reusable components, and UI
composition without JavaScript.

The interface includes a **header navigation, sidebar library, main
content sections, friend activity panel, and a music player footer**.

------------------------------------------------------------------------

## Preview

This project recreates the **Spotify desktop interface layout** with:

-   Navigation header
-   Sidebar music library
-   Main recommendations and playlists
-   Friend activity panel
-   Music player footer

------------------------------------------------------------------------

## Features

### Layout Structure

-   Header navigation with icons and search bar
-   Sidebar for music library navigation
-   Main content area with recommendations and playlist cards
-   Toggleable **Friends Activity panel**
-   Sticky **music player footer**

### UI Components

-   Navigation menus
-   Recommendation list
-   Playlist cards
-   Artist cards
-   Friend activity feed
-   Music player controls

### Interactive Elements (CSS-only)

-   Toggleable **Friends Activity sidebar** using a checkbox trigger
-   Scrollable card sections
-   Hover effects for cards and buttons
-   Responsive behavior for smaller screens

------------------------------------------------------------------------

## Technologies Used

-   **HTML5**
-   **CSS3**
-   **Flexbox**
-   **Responsive design**
-   **BEM naming methodology**
-   Custom font (`Satoshi`)

------------------------------------------------------------------------

## Project Structure

    project-folder
    │
    ├── index.html
    │
    ├── css
    │   └── styles.css
    │
    ├── assets
    │   ├── icons
    │   ├── card_images
    │   ├── recommendation_images
    │   ├── friend_images
    │   └── footer-image
    │
    └── fonts
        └── satoshi.css

------------------------------------------------------------------------

## Layout Overview

### Header

Contains: - Home navigation - Discover navigation - Search input -
Notification and settings icons - Friends activity toggle

### Sidebar

Music library navigation including:

-   My Library
-   Pins
-   Playlists
-   Liked Songs
-   Saves
-   Albums
-   Artists
-   Podcasts
-   Audiobooks

### Main Content

Divided into multiple sections:

1.  **Recommendations**
2.  **Made For You playlists**
3.  **Top mixes**
4.  **Favorite artists**

Each section uses **horizontal scrollable card lists**.

### Friends Activity

A collapsible sidebar showing:

-   Friends avatars
-   Currently playing songs
-   Activity timestamps

The sidebar visibility is controlled via a checkbox input and CSS
selectors.

### Footer Player

Simulated music player including:

-   Playback controls
-   Song progress bar
-   Current track information
-   Additional actions (lyrics, devices, favorites)

------------------------------------------------------------------------

## Responsive Behavior

The layout adapts for smaller screens:

-   Some navigation elements are hidden under **770px**
-   Friend activity panel is disabled on small screens
-   Card navigation buttons adjust visibility

------------------------------------------------------------------------

## Design Methodology

The CSS architecture follows **BEM (Block Element Modifier)**
principles.

Example:

    .card
    .card__image
    .card__content
    .card--artist

Benefits:

-   Clear component structure
-   Easy maintainability
-   Reusable UI blocks

------------------------------------------------------------------------

## How to Run the Project

1.  Download or clone the repository

```{=html}
<!-- -->
```
    git clone <repository-url>

2.  Open the project folder

3.  Open the file:

```{=html}
<!-- -->
```
    index.html

in any modern browser.

No build tools or dependencies are required.

------------------------------------------------------------------------

## Learning Goals

This project demonstrates:

-   Semantic HTML structuring
-   Complex layout composition
-   Component-based CSS architecture
-   Responsive UI design
-   CSS-only interactive elements

------------------------------------------------------------------------

## Possible Improvements

Future enhancements could include:

-   JavaScript for real player functionality
-   Dynamic playlist loading
-   Dark/light theme toggle
-   Mobile navigation improvements
-   Accessibility improvements (ARIA roles)

------------------------------------------------------------------------

## Author

Created as a **front-end layout practice project** using HTML and CSS.
