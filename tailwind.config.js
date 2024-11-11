/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./Pages/**/*.cshtml", // All Razor pages
    "./Views/**/*.cshtml", // MVC Views, if applicable
    "./wwwroot/**/*.{html,js}", // Static files in wwwroot (HTML and JavaScript)
    "./Components/**/*.cshtml", // Razor components, if any
  ],
  theme: {
    extend: {
      fontFamily: {
        figtree: ["Figtree", "sans-serif"], // Add Figtree font family
      },
    },
  },
  plugins: [],
};
