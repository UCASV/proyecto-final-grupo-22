# Aspectos técnicos 
 
En este apartado hablaremos sobre los aspectos técnicos del software utilizado para la creación del programa y demás especificaciones

###  Software
El software utilizado para este programa fue, **Visual Studio 2019** es una plataforma de lanzamiento creativa que puede usar para editar, depurar y compilar código. Un entorno de desarrollo integrado (IDE) es un programa rico en funciones que se puede utilizar para muchos aspectos del desarrollo de software. Además del editor y depurador estándar que ofrecen la mayoría de los IDE, Visual Studio incluye compiladores, herramientas de finalización de código, diseñadores gráficos y muchas más funciones para facilitar el proceso de desarrollo de software.
Este es compatible con proyectos basados en .NET Framework. el nuevo .NET Core multiplataforma, este permite desarrollar una inmensa capacidad de variedades de aplicaciones para escritorio .NET , juegos Unity, aplicaciones web ASP.NET y ASO.NET Core. 
En este programa se realizó mediante .NET framework en su versión número 5, en un formato de **Windows Forms Apps**

#### Sistema Operativo
El sistema operativo que utilizamos en nuestras computadoras donde realizamos todo el trabajo en general, cuenta con Windows 10. 

#### Paquetes Externos 
Dentro de los paquetes externos utilizados en el programa, están los paquetes **Nugets** que de estos se utilizaron 4: 
1. Microsoft.EntityFrameworkCore
2. MySql.EntityFrameworkCore
3. Microsoft.EntityFrameworkCore.Design
4. Microsoft.EntityFrameworkCore.Design

# Instalación 

### Visual Studio 2019 - community
Visual Studio 2019 - community, nos dirigiremos a su página web o mediante este link para descargar dicha herramienta [Descargar Aquí](https://visualstudio.microsoft.com/es/vs/).
El cual al instalarse podrá añadir los lenguajes y herramientas a utilizar mediante este IDE.  

>Como observación este IDE requiere de licencia para ser utilizado 
 
 **Licencia** 
Esta se puede comprar, o en el caso de ser estudiantes. como lo somos nosotros la podemos obtener de forma gratuita en muchos escenarios, en este link que se provee a continuación se muestra la serie de pasos a seguir para completar la instalación **hhttps://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019** podrás ingresar con tu usuario de la licencia en el IDE para obtener más beneficios y herramientas. 
 >Esta licencia es gratuita en caso de que la instalación de la edición Community le pida una licencia, puede que tenga que iniciar sesión para desbloquear el IDE. Siga las instrucciones [Ver las instrucciones Aquí]( https://docs.microsoft.com/es-es/visualstudio/ide/signing-in-to-visual-studio?view=vs-2019).


### Base de Datos 
En cuanto al gestor de base de datos que utilizamos es el que provee MIcrosoft, **MySql community server 8.0.25** mediante este link [Descargar Aqui]( 
https://dev.mysql.com/downloads/windows/installer/8.0.html).
Al haberse instalado, es necesario tomar en cuenta que debe seleccionar 3 productos los cuales son: Mysql server 8.0.25 y en aplicaciones seleccionar Mysql workbench 8.0.25 y en documentacion siempre 8.0.25

Para el proyecto final hicimos todo mediante la terminal de visual studio el cual a crear las respectivas clases con su constructor, continuamos a pasarla a la  base de datos creada, y automaticamente al conectarla con la respectiva base de proyecto final todo lo trabajado en el programa visual studio se creo en la base de datos ( incluyendo tablas y valores).

# Patrones de Diseño
-Implementación de interfaz gráfica
La interfaz gráfica del programa consiste en una ventana global o formulario “Login.cs”,  que es el encargado de cargar distintos controles de usuario los cuales son:
#### - Login.cs
contiene tres botones, los cuales nos ayudan a cambiar entre Login controls.

#### - CrearCita.cs
contiene textbox donde podra insertas los datos para el respectivo paciente y botones, para guardar los datos y otro para cancelar el proceso, asi mismo para modificar la cita si fuese necesario.

#### - Username.cs
contiene textbox que nos ayuda a completar la informcaion del empleado que manejara la cabina durante la jornada.

Para controlar el flujo de datos en el programa y a la base de datos se manejan las
siguientes clases:
1. 20210627035638_tabla.cs
2. 20210627035613_init.cs
3. ProyectoContextModelSnapshot.cs
#### Manejo de clases en modelo
Para manejar el modelo del programa se utilizan las siguientes clases:
| CLASE  | CLASE | CLASE |
| :---         |     :---:      |          ---: |
|  1. Cabin.cs |   5. Dosi.cs    |   9. TypeVaccine.cs   |
| 2. DateVaccine.cs    |    6. Employee.cs  |     10. Pacient.cs  |
| 3. DayVaccine.cs    | 7. Index_cabin.cs    |   11. SideEffect.cs     |
| 4. Disease.cs    | 8. InstitutionObjective.cs    |   12. TypeEmployee.cs   |

#### Tipos de error
Controlados
los diferentes tipos de errores que consideramos y controlamos en
nuestro programa son:
- Dejar vacío el nickname o solo con espacios (User.cs)
- Minimizar la ventana con el juego ejecutándose 
- Error al obtener datos de la base de datos 
- Error al insertar datos a la base de datos 

# Manual de Usuario
El proyecto realizado con mi equipo, funciona como gestor para la realizacion de citas a las personas que quieran ponerse la vacuna covid-19
este programa esta capacitado para tomar la información tanto del paciente, como para el empleado que maneja dicho programa, guardando esta información en una base de datos.
esta formado por una ventana principal donde el empleado puede poner sus credenciales o si en dado caso no cuenta con ellas, puede tener acceso a crear un nuevo usuario
gracias a la ventana principal, contamos con otras dos, una que nos ayudan a gestionar los datos para la creación de cita del paciente y otra para la modificción de credenciales del empleado a cargo de la plataforma si en dado caso este pierde su contraseña, puede volver a recuperar sin necesidad de crear un nuevo usuario.
