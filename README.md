# Petrine.no Portfolio

This is a personal portfolio project built with ASP.NET Core and Tailwind CSS. The project showcases your latest GitHub projects and includes a blog page and contact page.

## Technologies Used

- **ASP.NET Core**: Backend and server-side rendering with Razor Pages.
- **Tailwind CSS**: For modern styling and layout without needing to compile CSS locally.
- **JavaScript**: For dynamic loading of projects and other frontend functionalities.

## Features

- **Homepage**: Displays the latest three projects from GitHub.
- **Projects**: A comprehensive list of all projects fetched directly from GitHub.
- **Blog**: A dedicated page for writing about the technology used in your projects.
- **Contact**: A contact page with a form for sending messages.

## Notes

- The API functionality is still in progress and will be updated soon.

## Running the Project Locally

1. Clone the repository:
```bash
   git clone https://github.com/<your-username>/petrine.no.git
```
2.	Install Tailwind CSS dependencies:
```bash
   cd petrine.no
  ```
3.	Start the application:  
```bash 
  npm install
  ```
4.	Build the Tailwind CSS:
```bash
npm run build:css
```
5.	Start the application with hot-reloading:
```bash 
dotnet watch run
```