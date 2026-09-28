# Landing CROP

Landing page de **C.R.O.P. — Seguro Paramétrico Agropecuario**. Sitio estático, sin build.

- `index.html` — la página
- `assets/` — imágenes, fuentes y scripts (React y el runtime de la página, servidos localmente)
- `vercel.json` — configuración de Vercel

## Ver en local

```bash
python3 -m http.server 8000
# abrir http://localhost:8000
```

## Deploy en Vercel

1. Entrá a https://vercel.com/new e importá este repositorio.
2. Framework preset: **Other**. Sin build command ni output directory.
3. Deploy. Cada push a `main` se publica automáticamente.
