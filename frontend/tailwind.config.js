/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/**/*.{html,ts}",
    "./node_modules/flowbite/**/*.js",
  ],

  theme: {
    extend:{
      colors: {
      'turquoise-blue':"#33b3ae",
          'beige':"#FAF9F6",
          "rose-modified": "#ffc3ae",
          "lightgreen-modified": "#f1f6be"
        }

    },

  },
  plugins: [  require('flowbite/plugin')],
}

