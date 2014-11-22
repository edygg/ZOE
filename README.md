ZOE
===

#  Programas necesarios
1. [Visual Studio 2013](http://www.visualstudio.com/en-us/news/vs2013-community-vs.aspx)
2. [SQL Server 2014](http://msdn.microsoft.com/en-us/evalcenter/dn434042.aspx)
  - Asegurarse de que en la instalación la instancia sea nombrada por defecto
  y que se instale en componente **LocalDB** (SQL Server 2014 Express with Advanced Services)
3. [Git for Windows](http://git-scm.com/download/win)
4. IIS

# Pasos para la instalación
## Descargar el repositorio de Github
1. Abrir git bash
   ![Git bash inicio](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416579669/Captura_tpidhx.png)
2. Moverse hasta el directorio donde se desea mantener la aplicación
   ![Moverse al directorio](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416579844/Captura1_rfydz5.png)
3. Clonar el [repositorio de github](https://github.com/efgm1024/ZOE)
   ![Clonar el repositorio](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416580035/Captura2_sv3maa.png)

## Instalar paquetes necesarios con NuGet
1. Descargar [NuGet](http://nuget.org/nuget.exe)
2. Crear una carpeta en C: llamada Utilities (C:\Utilities)
3. Copiar el nuget.exe a dicha carpeta
4. Ir a Mi PC | clic derecho | Propiedades | Opciones Avanzadas

   ![Propiedades de la PC](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416614602/Captura3_jpxjte.png)
5. Dar clic en Variables de entorno

   ![Variables de entorno](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416615136/Captura4_pmfgto.png)
6. Buscar la variable `Path`, seleccionarla y dar clic en Editar

   ![Editar Path](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416615435/Captura5_cfq9pn.png)
7. Colocar al final lo siguiente `;C:\Utilities`

   ![Cambiar Path](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416615649/Captura6_ot8vfr.png)
8. Abrir Windows PowerShell
9. Moverse hasta la carpeta donde está el proyecto

   ![PowerShell1](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416616411/Captura7_gwfu8n.png)
10. Crear una carpeta `packages`

   ![PowerShell2](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416616532/Captura8_wbgiuf.png)
11. Entrar a la carpeta `Zoe` y escribir:

   ![PowerShell3](http://res.cloudinary.com/dodpsiyv0/image/upload/v1416617125/Captura9_kcgrto.png)
12. Los paquetes deberán instalarse todos correctamente.
