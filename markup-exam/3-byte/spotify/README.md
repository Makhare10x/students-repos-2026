# Spotify Clone — Home Content (Markup Exam)

This project is a **Spotify-inspired UI clone** built as a markup practice/exam.  
In this branch I implemented the **Home page main content area** based on the provided design screenshot.

## What was built (Home inner content)

The following sections were created inside the main content container:

- **Filter buttons**: All / Music / Podcasts / Audiobooks
- **Made For You** section  
  - Media cards with cover image, title, song count and description
  - Header actions (left/right arrows + menu icon)
- **Your top mixes** section  
  - Media cards similar to Spotify mix tiles
- **Recent searches** section  
  - Search tiles with image + title and close button  
  - Hidden on small screens for better layout
- **Browse all** section  
  - **Discover** category cards
  - **Genres** category cards
  - Each browse card has a colored background and a bottom-right image overlay

##  Styling & UI details

- Layout built with **Flexbox** and SCSS nested structure
- Card hover interactions (subtle lift/opacity changes)
- Browse category cards use:
  - `position: relative` for layered image + title
  - `overflow: hidden` and border-radius for clean clipping
- Custom typography uses the **Satoshi** font family with multiple weights

##  Responsive behavior

Responsive styles were added for small screens (max-width: 400px):

- Filter buttons resize and adjust spacing
- “Recent searches” section is hidden on very small screens
- Browse rows switch to wrapped layout and center alignment
- Card sizes and text adjust for mobile readability

##  Key files

- `src/pages/home.html` (Home main content markup)
- `src/scss/pages/_home.scss` (Home styles)
- `src/scss/base/_responsive.scss` (Mobile adjustments)

##  Fonts

Satoshi font is loaded locally via `@font-face` (Light/Regular/Medium/Bold/Black)  
and used across the UI for a Spotify-like look.

## Preview

![Home Content Preview](/src/assets/images/main-content/main-content-csreen.png)