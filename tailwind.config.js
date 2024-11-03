/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./Pages/**/*.{html,razor}", // Include all Razor pages
    "./Views/**/*.{html,razor}", // If you have MVC Views
    "./wwwroot/**/*.{html,razor,js,jsx,ts,tsx}", // Static files in wwwroot
    "./Components/**/*.{html,razor}", // If you have any components
  ],
  theme: {
    extend: {},
  },
  plugins: [],
};
