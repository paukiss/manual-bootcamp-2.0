# Tests de Automatización en C#

Este repositorio contiene un código en C# para realizar pruebas de automatización en una página web [todoly](https://todo.ly/).

El objetivo es realizar las pruebas de automatizacion de los TCs  que se crearon segun el requerimiento del proyecto de QA Manual Testing para proporcionar un ejemplo básico de cómo estructurar y ejecutar pruebas automatizadas utilizando el lenguaje de programación C# y algunas herramientas populares de automatización web.

## Requisitos

Antes de comenzar, asegúrate de tener instalado lo siguiente:

- [Visual Studio](https://visualstudio.microsoft.com/) o algún otro entorno de desarrollo integrado (IDE) para C#.
- [Selenium WebDriver](https://www.selenium.dev/documentation/en/webdriver/) para interactuar con los elementos de las páginas web.
- [ChromeDriver](https://chromedriver.chromium.org/downloads) para manejar automáticamente la descarga y configuración del controlador (driver) del navegador web.

## Estructura del proyecto

El proyecto se organiza de la siguiente manera:

```
src
├── code
│   ├── browser
│   ├── control
│   ├── page
│   ├── session
│   └── test
│       └── todoly
│           └── ChangeColor.cs
│           └── CreateTask.cs
│           └── CRUDProjectTest.cs
│           └── EditAndDeleteTask.cs
│           └── SetDueDate.cs
└── resources
    └── driver
        └── chromedriver.exe
```
- `src`
  - `code`
    - `test`: 
      - `todoly`: Pruebas de automatizacion para la aplicacion todoly
  - `resources`: 
    - `driver`: Directorio para almacenar los controladores de los navegadores web utilizados en las pruebas.

## Configuración

Antes de ejecutar las pruebas, es necesario configurar el proyecto. Asegúrate de seguir los siguientes pasos:

1. Clona o descarga este repositorio en tu máquina local.
2. Abre el proyecto en tu IDE de preferencia (por ejemplo, Visual Studio).
3. Asegúrate de que las dependencias necesarias (Selenium WebDriver) estén instaladas en tu proyecto. 

## Ejecución de las pruebas

Una vez configurado el proyecto, puedes ejecutar las pruebas de automatización. Sigue estos pasos:

1. Abre el archivo `CRUDProjectTest.cs` para probar el TCs-1 Create a Project.
2. Ejecuta las pruebas utilizando el IDE.
3. Realiza el paso 1 y 2 con los siguientes archivos para cada test case:
    - `CreateTask.cs` para probar el TCs-4 Create a Project.
    - `EditAndDeleteTask.cs` para probar el TCs-5 Create a Project.
    - `ChangeColor.cs` para probar el TCs-6 Create a Project.
    - `SetDueDate.cs` para probar el TCs-7 Create a Project.

¡Automatizar es divertido! 🚀