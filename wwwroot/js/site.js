console.log("site.js loaded successfully!");

// JavaScript for å vise/skjule Back to Top-knappen
const backToTopBtn = document.getElementById("backToTopBtn");
window.addEventListener("scroll", () => {
  if (window.scrollY > 300) {
    backToTopBtn.classList.remove("hidden");
  } else {
    backToTopBtn.classList.add("hidden");
  }
});

// Smooth scroll til toppen
backToTopBtn.addEventListener("click", () => {
  window.scrollTo({ top: 0, behavior: "smooth" });
});

// Toggle the mobile menu on smaller screens
const menuButton = document.getElementById("menuButton");
const mobileMenu = document.getElementById("mobileMenu");

menuButton.addEventListener("click", () => {
  if (mobileMenu.classList.contains("hidden")) {
    mobileMenu.classList.remove("hidden");
    mobileMenu.classList.add("flex");
  } else {
    mobileMenu.classList.remove("flex");
    mobileMenu.classList.add("hidden");
  }
});
document.querySelectorAll(".skill-bar").forEach((bar) => {
  const originalHeight = bar.style.height;
  bar.addEventListener("mouseenter", () => {
    bar.style.height = `calc(${originalHeight} + 10px)`; /* Grow slightly */
  });
  bar.addEventListener("mouseleave", () => {
    bar.style.height = originalHeight; /* Return to original height */
  });
});
