# Spotify Home (Markup Clone) — PRO

## What you get
- Semantic layout: `aside` (sidebar), `header` (topbar), `main` (content), `footer` (player)
- SCSS architecture with partials
- `@use` is present in **every** SCSS file
- Image places are **placeholders** (`div` blocks) — you can replace with `<img>`

## Run
Open `index.html` directly, or use Live Server.

## Compile SCSS (recommended)
```bash
npx sass --watch scss/main.scss css/style.css --no-source-map
```

## Where to put images
`assets/images/`
Replace placeholders:
- `.card__cover`
- `.mix__cover`
- `.track__cover`
