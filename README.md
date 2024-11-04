# Petrine.no Portfolio

This project is a personal portfolio built with ASP.NET Core and Tailwind CSS. It highlights recent GitHub projects, includes a blog section, and provides a contact form for user inquiries.

## Technologies Used

- **ASP.NET Core**: Backend framework with server-side rendering via Razor Pages.
- **Tailwind CSS**: Enables responsive and modern styling without extensive CSS setup.
- **GitHub API**: Fetches recent projects directly from GitHub, keeping the portfolio current.

## Why ASP.NET Core?

ASP.NET Core was selected for this project due to several advantages that align well with the portfolio’s needs:

1. **Server-Side Rendering**: ASP.NET Core’s Razor Pages provide efficient server-side rendering, delivering content to the user quickly and reducing load on the client’s browser.
2. **Scalability**: ASP.NET Core is highly scalable, supporting the future addition of more pages and complex features, and efficiently handling a growing audience.
3. **Modularity and Maintainability**: Razor Pages help maintain separation of concerns, making it easy to organize content, layouts, and logic. This structure enhances code readability and simplifies ongoing maintenance.

## Features

- **Homepage**: Displays the latest three GitHub projects in a card layout.
- **Project Details**: Each project links to a dedicated page with in-depth information and images.
- **Blog**: A section to write and share articles about the technologies and methodologies used in the projects.
- **Contact**: A page with a contact form allowing users to send messages directly.

## API Integration

This project integrates with GitHub’s API to display up-to-date project information. By default, a personal access token may not be required unless GitHub’s API limits are reached. In that case, you can add an environment variable with your personal access token to increase your access rate limits.

## Running the Project Locally

1. **Clone the repository**:
   ```bash
   git clone https://github.com/EPetrineLynghaug/petrine.no.git
   ```

2.	**Navigate to the project folder**:
  ```bash
  cd petrine.no
  ```

3.	**Install npm dependencies for Tailwind CSS**:
  ```bash 
  npm run build:css
  ```
4. **Build Tailwind CSS**:  
  ```bash
  npm run build:css
  ```
	5.	**Run the application**:
  ```bash
  dotnet watch run
  ```