# Trabajo Practico N°2 Laboratorio II: Utn Uno Masters

Juego elegido: Uno.

Explicación: perdon el readme nefasto, tenia uno hecho e hice un push --force y se me borro.

Resumen: La aplicacion comienza con un form de logeo, tras el cual se accede a un form con una animacion de carga. Posteriormente se accede al menu principal, en el cual se puede
ver los usuarios, las partidas activas cuando sean creadas y una simulacion de chat.
Desde este menu el administrador tiene acceso a la creacion de partidas. a jugar partidas ( solo form, no desarrollado), la administracion de usuarios desde donde podra
crear nuevos, editar y borrar existentes, y acceso a la lectura de las reglas de juego.


![Proyecto](https://user-images.githubusercontent.com/86857153/202927728-5c7a6323-33d8-4ff0-a4c5-1c385747d90e.PNG)


Diagrama de clases: 

![DiagramaDeClases](https://user-images.githubusercontent.com/86857153/202927752-cfc045ed-9523-428d-88ab-3eb40f6a9eee.PNG)

Temas abarcados:

* Herencia
* Sql Base de datos
* Manejo de excepciones
* Unit Testing
* Generics
* Serialización
* Escritura de archivos
* interfaces
* Delegados
* Task
* Eventos

Herencia: se usa en dos clases, Usuario que hereda de Persona y RepositorioDeAcceso que hereda de Repositorio base a fin de protejer los atributos usados como el connectionString.

![HerenciaRepositorio](https://user-images.githubusercontent.com/86857153/202927916-91a698fd-94f7-44b5-84f3-f0da8ab27670.PNG)

![HerenciaUsuario](https://user-images.githubusercontent.com/86857153/202927919-8ff54622-8e22-4c96-89ca-5881cb3d629e.PNG)

Sql Base de datos: Lo usamos para importar y exportar datos del proyecto, como los usuarios, los paises, el historial de partidas y el mazo en la primera apertura.

![SqlClase](https://user-images.githubusercontent.com/86857153/202927990-b60f15f6-1296-428c-9060-7373b5b093de.PNG)

![SqlProtected](https://user-images.githubusercontent.com/86857153/202927993-be74b8e0-dadd-4558-b5a0-84c7a8c8defe.PNG)

Manejo de excepcion: concretamente se usan dos clases creadas heredadas de Exception, ademas de otras por defecto, las creadas en clase se usan una en el logeo y la otra en una comprabacion de e.RoIndex que inicialmente daba problemas de index.

![ExcepcionRowUso](https://user-images.githubusercontent.com/86857153/202928072-d01468ff-ab80-450f-b422-987982cc2138.PNG)

![excepcionRowClase](https://user-images.githubusercontent.com/86857153/202928078-dc8e769a-b269-4263-8cbe-7d99b8042d05.PNG)

![ExcepcionDatosClase](https://user-images.githubusercontent.com/86857153/202928085-48fc76e8-6299-4f89-8177-6f63c8b58266.PNG)

![ExcepcionDatosDeclaracion](https://user-images.githubusercontent.com/86857153/202928088-1ee11ada-f1f6-4ad0-9173-87fb3f2b0432.PNG)


![ExcepcionDatosImplementacion](https://user-images.githubusercontent.com/86857153/202928090-d191f188-3b7c-4f4d-b620-47ea22903356.PNG)

Unit Testing: se crearon testeo para todas las clases que realizan metodos propios, se excluyo las clases que solo tenia atributos y propiedades.

![UnitTesting](https://user-images.githubusercontent.com/86857153/202928306-5fe3ef34-bf7e-41d5-b065-4f7ad3f887f1.PNG)

![Testing](https://user-images.githubusercontent.com/86857153/202928310-c94ab6f8-f14b-48b9-bbb0-9c86df6d071d.PNG)

Generics: se uso principalmente en la serializacion de archivos.

![Generics](https://user-images.githubusercontent.com/86857153/202928345-df416d10-27a6-41ff-8843-01c517a55b7f.PNG)

Serializacion: al inicio del programa se carga desde la base de datos el mazo y se lo serializa en un archivo .json desde donde se usa en adelante.

![SerializacionJson](https://user-images.githubusercontent.com/86857153/202928403-8e594791-a50d-4135-bd92-0bed95afd753.PNG)

![SerializacionJson2](https://user-images.githubusercontent.com/86857153/202928410-bd5c2b74-805c-4e8c-9ff5-050d9db1d0c2.PNG)

Escritura de archivos: si bien no se le vio utilidad en el desarrollo del programa a usar archivos .txt, a modo de no excluirlo del mismo se uso para poder cargar las reglas del juego y leerlas desde el menu principal.

![archivos](https://user-images.githubusercontent.com/86857153/202928468-62e6fc3f-32f6-4f88-953f-d92458d8f2c6.PNG)

Interfaces: se utilizan en varios forms a fin de quitar la logica de los mismo, se usan junto con los presentadores segun lo visto en el tema de MVP.

![Interfaces](https://user-images.githubusercontent.com/86857153/202928509-40e4a0c4-a7a1-49a0-a67b-9d4c4e55df53.PNG)

![InterfazDeclaracion](https://user-images.githubusercontent.com/86857153/202928512-7480560b-8bd1-40c3-bf33-e09762137ded.PNG)

![InterfazUso](https://user-images.githubusercontent.com/86857153/202928515-a2900a46-f8a9-47b4-8adc-7a8a305ea24a.PNG)

Delegados: se usan en su mayor parte como eventos exceto para la comprobacion de que solo se cree un form por cada hilo creado.

![delegadodeclaracion](https://user-images.githubusercontent.com/86857153/202928558-f6e28db7-038e-4eef-b993-f9063146984d.PNG)

![delegadoinvocacion](https://user-images.githubusercontent.com/86857153/202928565-089d13de-b89d-4f75-8556-14fd823d385c.PNG)

Task: se usan primero en el form login para cargar la animacion de carga y luego para crear cada partida nueva en un hilo aparte.

![taskCargando](https://user-images.githubusercontent.com/86857153/202928601-9b5a0c85-476b-4e03-a7b1-67ff74c5657c.PNG)


![TaskPartida](https://user-images.githubusercontent.com/86857153/202928608-6ebc5be2-e1aa-4496-b352-53b043030902.PNG)


Evento: se usan para la partida en juego y tambien se creo uno a fin de poder buscar en la barra de busqueda del form de usuarios al apretar la tecla enter ademas del boton "Buscar".

![eventoPartida](https://user-images.githubusercontent.com/86857153/202928652-4aaa0891-b47a-41c7-982b-232ed376ae94.PNG)

![eventodatagrid](https://user-images.githubusercontent.com/86857153/202928657-0da0bdf2-4b2d-4231-9a46-5e8b2971d9ce.PNG)
