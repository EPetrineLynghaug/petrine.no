document.addEventListener("DOMContentLoaded", async () => {
  try {
    const response = await fetch(
      "https://api.github.com/users/EPetrineLynghaug/repos"
    );

    // Sjekk om responsen er vellykket
    if (!response.ok) {
      throw new Error("Netverksresponsen var ikke OK: " + response.statusText);
    }

    const repos = await response.json();
    const latestProjects = repos.slice(0, 3); // Hent de tre nyeste prosjektene
    const projectContainer = document.getElementById("latestProjects");

    // Generer prosjektkort for hver repo
    latestProjects.forEach((repo) => {
      const projectCard = `
        <div class="p-4 bg-white shadow-lg rounded-md">
            <h3 class="font-semibold text-lg">${repo.name}</h3>
            <p>${repo.description || "Ingen beskrivelse tilgjengelig."}</p>
            <a href="${
              repo.html_url
            }" target="_blank" class="text-blue-500">Se på GitHub</a>
        </div>
      `;
      projectContainer.innerHTML += projectCard;
    });
  } catch (error) {
    console.error("Det oppstod en feil:", error);
  }
});
