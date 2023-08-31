# CRUD-ASP.NET-RegistroPersonas

## Herramientas de Desarrollo

 - Entity Framework
 - NuGet
 - Razor Page
 - Linq
 - SQL Server
 - HTML
 - Javascript
 - Bootstrap
   
 ## Ejecución del proyecto
 
### Creando la base de datos con el mapeo (Recomendable)

1. Configuración Inicial
Clona este repositorio en tu máquina local utilizando el siguiente comando:
  git clone https://github.com/marlong03/CRUD-ASP.NET-RegistroPersonas.git

Abre el proyecto utilizando Visual Studio u otro entorno de desarrollo compatible con ASP.NET.
2. Importar paquetes con NuGet
-Ir al archivo appsettings.json y cambiar el Server del link de conexión por el link de conexion de tu SQL SERVER
("Server=TuNombreDeServidor;Database=RegistroPersonas.Data;Trusted_Connection=True;MultipleActiveResultSets=true")

-Ve a la parte superior del IDE Visual Studio en la sección de Herramientas

-Luego en la opción que dice  Administrador de paquetes NuGet

-Despues en la opción de Consola de Administrador de paquetes
se abrira una consola en la cual ejecutaras el siguiente comando (add-migration NombreMigracion)

-Luego ejecutarás este otro comando para ya crear la base de datos de acuerdo al mapeo (update-database)

-Luego ya podrás ejecutar el proyecto y verificar su funcionamiento

### Con Base de datos importada

1. Configuración Inicial
Clona este repositorio en tu máquina local utilizando el siguiente comando:
  git clone https://github.com/marlong03/CRUD-ASP.NET-RegistroPersonas.git

-Abre el proyecto utilizando Visual Studio u otro entorno de desarrollo compatible con ASP.NET.

2. Base de Datos
Importa la base de datos en tu servidor SQL Server. Puedes encontrar el archivo de respaldo de la base de datos en la carpeta Database del proyecto.

Abre tu servidor SQL Server y ejecuta el script SQL proporcionado para crear la base de datos.

Actualiza la cadena de conexión en el archivo appsettings.json con los detalles de tu servidor SQL:

"ConnectionStrings": {
  "DefaultConnection": "Server=tu-servidor;Database=nombre-base-de-datos;User Id=tu-usuario;Password=tu-contraseña;"
}


3. Ejecutar el Proyecto
Compila el proyecto en tu entorno de desarrollo.
Ejecuta la aplicación. Asegúrate de que el proyecto esté configurado como proyecto de inicio en tu IDE.
Abre tu navegador web y navega a la dirección https://localhost:puerto para ver la aplicación en funcionamiento.

¡Listo! Ahora deberías tener el proyecto en funcionamiento en tu entorno local. Si tienes algún problema o pregunta, no dudes en consultar la sección de problemas conocidos o ponerte en contacto conmigo.

### Recuerda que tambien he realizado un corto video en donde se evidencia el funcionamiento de la aplicación
https://youtu.be/Xf-Mww0NwfE
 
