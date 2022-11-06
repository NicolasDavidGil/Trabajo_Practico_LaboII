Trabajo_Practico_LaboII: UTN AIRLINES: Acercándote a nuevos horizontes.
Mi nombre es Nicolás David Gil, tengo 31 años, soy de Zona Sur, si bien siempre me gusto la programación recien pude empezar a dedicarme de grande. Nunca antes de entrar en la carrera habia programado. En cuanto al desarrollo del tp, si bien costo mucho y fue dificil, fue a la vez super entrenido e instructivo, aprendi por medio de la curiosidad y de la investigación he aprendido muchas cosas nuevas.

Resumen:

La aplicación se desarrolla pensando en ser usada por los empleados de una aerolinea,a traves de un inicio de sesion con usuario y contraseña propio acceden a un "menu principal", desde el cual pueden desarrollar todas las cosas pedidas en las consignas. -Ver estado de vuelos. -Ver datos de los clientes. -Ver datos de vuelos y pasajeros. -Ver datos de las aviones. -Consultar estadisticas historicas. Al iniciarse la aplicacion se inicializa una cantidad de datos por defectos que puede ser usados para pruebas. A todo esto se puede acceder desde un menustrip. Para resulver el problema del uso en tiempo real se establecio como criterio que cada avión de la flota solo podrá volar 1 vez por dia.

Diagrama de clases:![Gil Nicolas David DiagramaDeClase](https://user-images.githubusercontent.com/86857153/193868015-38111976-dabd-4ce5-ac34-510a3d22d983.png)


Clase a clase:

Encapsulamiento: He usado varias clases static, como Aerolinea y Hardcodeo, en las clases donde sus metodos eran usados de manera interna fueron declarados como private para protegerlos.

Abstracción: Se uso como condición la cantidad máxima de un vuelo por día para cada avión a fin de simplificar el uso de la aplicación. De ciertas clases como persona, se toman solo alguno de los atributos que estas podrian tener.

Herencia: Se creo la clase Persona como abstract a manera de base para generalizar las clases derivadas, Usuario, Cliente.

Polimorfismo: Se utiliza para sobreescribir los métodos de la clase object como por ejemplo ToString(), GetHashCode(), Equal(), asi como tambien el metodo CalcularResultados() de la clase Persona.

Ademas, se hace uso de diversas colecciones como pueden ser las listas, los diccionarios, etc.

Se realizaron sobrecargas de constructores y métodos.

Propuesta de valor agregado:

-Se inserto un buscador junto a una "base de datos" de clientes.

-Se creo un form para la edicion de los distintos usuarios del programa. El cual incluye un retrato de los mismos.

-Se añadio un sistema de recuperación de recuperación de contraseñas por medio de una pregunta secreta para cada uno de los usuarios.

-Se enlazo a un boton del menu "Sitio Web", una página creada a modo de orientacion sobre nuestra aplicacion y empresa.

-Los empleados tiene un sueldo base y generan ganancias a traves de comisiones por cada pasaje vendido.

-Los usuarios a su vez, por cada viaje que realizan, tiene un costo total.
