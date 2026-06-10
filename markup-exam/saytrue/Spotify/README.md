# Spotify Clone

A Spotify-inspired music player interface built with HTML, SCSS, and vanilla JavaScript.

## Features

- Responsive sidebar navigation
- Music player controls
- Playlist cards with hover effects
- Filter chips for music categories
- Gradient backgrounds
- Custom scrollbars

## Project Structure

```
spotify-clone/
├── index.html          # Main HTML file
├── css/
│   └── main.css        # Compiled CSS
├── scss/
│   ├── main.scss       # Main SCSS entry point
│   ├── abstracts/      # Variables and mixins
│   ├── layout/         # Layout components
│   └── components/     # UI components
├── package.json        # Project dependencies
└── README.md           # This file
```

## Getting Started

### Prerequisites

- Node.js (v14 or higher)
- npm or yarn

### Installation

```bash
# Install dependencies
npm install
```

### Development

```bash
# Watch SCSS changes and compile automatically
npm run dev
```

### Build

```bash
# Compile SCSS to CSS
npm run sass:build

# Compile minified CSS
npm run sass:minify
```

### Run Locally

```bash
# Build and serve the project
npm start
```

## Tech Stack

- **HTML5** - Semantic markup
- **SCSS** - CSS preprocessor with variables and mixins
- **CSS Variables** - For theming and customization
- **Flexbox & Grid** - Modern layout techniques

## Browser Support

- Chrome (latest)
- Firefox (latest)
- Safari (latest)
- Edge (latest)

## License

MIT
