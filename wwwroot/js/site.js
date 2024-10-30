document.addEventListener("DOMContentLoaded", async () => {
  const response = await fetch(
    "https://api.github.com/users/yourusername/repos"
  );
  const repos = await response.json();
  const latestProjects = repos.slice(0, 3);
  const projectContainer = document.getElementById("latestProjects");

  latestProjects.forEach((repo) => {
    const projectCard = `
            <div class="p-4 bg-white shadow-lg rounded-md">
                <h3 class="font-semibold text-lg">${repo.name}</h3>
                <p>${repo.description}</p>
                <a href="${repo.html_url}" target="_blank" class="text-blue-500">Se på GitHub</a>
            </div>
        `;
    projectContainer.innerHTML += projectCard;
  });
});
