/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,razor,js,jsx,ts,tsx}", "./public/index.html"],
  theme: {
    screens: {
      sm: { min: "640px", max: "767px" },
      md: { min: "768px", max: "1023px" },
      lg: { min: "1024px", max: "1279px" },
      xl: { min: "1280px" },
    },
  },
  plugins: [],
};
