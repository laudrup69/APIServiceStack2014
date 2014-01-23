APIServiceStack2014
===================

Pruebas nueva API Service Stack 2014

Estructura mínima y básica de un servicio en ServiceStack.

Principales objetos:


1.- Objeto principal y de arranque de la aplicación:

AppHost.cs

Hereda del objeto base de servicestack AppHostBase y que sirve para configurar e inicializar los servicios.

2.- ¿Cómo se inicializa?

Global.asax.cs

Cuando el servicio se "levanta", se ejecuta el método Application_Start del Global.asax.cs. En este método llamaremos
a nuestro objeto aplicación para que configure e inicialice los servicios pertinentes con 

new AppHost().Init() // Ver código en Global.asax.cs 

3.- Todo Servicio consta de :

A - La petición. Request DTO. (ex. Hello.cs)
B - La respuesta. Response DTO. (ex. HelloResponse.cs)
C - La implementación del servicio. (ex. HelloService.cs)
