# Portafolio

![Estado del Proyecto](https://img.shields.io/badge/estado-en%20desarrollo-yellow)

## Descripción

Este proyecto portafolio personal, es una landing page diseñada para mostrar proyectos y habilidades como desarrollador. En esta página, encontrarás información sobre la persona, sus proyectos destacados, y las habilidades que ha desarrollado a lo largo de mi carrera.

## Tecnologías Utilizadas

* ASP.NET Core
* MVC
* HTML
* CSS
* Bootstrap
* C#

## Características

1. Diseño limpio.
2. Sección "Mis Proyectos" para presentar un portafolio de proyectos y sus enlaces directos.
3. Sección "Proyectos Destacados" con una lista de los 3 proyectos más destacados.
4. Sección "Habilidades" que enumera las tecnologías y habilidades que domina.
5. Formulario de contacto para que los visitantes puedan ponerse en contacto con la persona.

## Instalación y Ejecución

1. Clona el repositorio en tu equipo local.
2. Abre el proyecto en Visual Studio o en tu editor de código preferido.
3. Asegúrate de tener .NET Core SDK instalado.
4. Ejecuta la aplicación si utilizas VS o ejecuta el comando dotnet run para iniciar la aplicación si utilizas otro IDE.

## Personalización

Si deseas utilizar esta landing page para tu propio portafolio personal, puedes personalizarla fácilmente siguiendo estos pasos:

1. Edita los archivos HTML y CSS en la carpeta Views/Home y wwwroot/css para reflejar tu información personal y estilo preferido.
2. Agrega tus proyectos en el archivo RepositorioProyectos.cs en la carpeta Models para mostrarlos en la vista "Mis Proyectos", ten en cuenta que los primeros 3 proyectos que agregues se mostrarán en la sección "Proyectos Destacados".
3. Actualiza la lista de habilidades en la vista parcial Views/Home/_Habilidades.cshtml.
4. Personaliza la información de contacto en el archivo Contacto.cs en la carpeta Models.
