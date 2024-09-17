# MyQueue in C#

En el siguiente proyecto se desarrollo un lista dinamica de tipo cola en el lenguaje de  C#, esto mediante la utilizacion de nodos.


### Autores

- Nicolas Santiago Acosta Parra
- Tomas Useche

### Estructura del proyecto

- Node: Clase que representa un nodo de la lista, con punteros hacia el nodo siguiente, y un dato almacenado.
- MyQueue: Clase que implementa la clase Node y crea los metodos para el funcionamiento de la cola.
- Prueba: Clase de prueba que implementa la clase MyQueue y hace una prueba de sus diferentes funcionalidades.

### Funcionalidades

- push(data): Agrega un nuevo nodo con el dato en la parte superior de la cola.
- pop(): Elimina y retorna el dato del nodo en la parte superior de la cola. Si la cola está vacía, lanza una excepción.
- peek(): Retorna el dato del nodo en la parte superior de la cola sin eliminarlo. Si la cola está vacía, lanza una excepción.
- is_empty(): Verifica si la pila está vacía.
  
### Recomendaciones:

- Utilizar c# en la version 12.0 ya que es la ultima version estable.
- No se necesitan archivos o paquetes adicionales para su compilacion.

  
### Compilación y Ejecución

Para compilar y ejecutar el proyecto, sigue estos pasos:

- Clona el repositorio o descarga los archivos.
- Abre el proyecto en Jetbrains Rider en la version 2024.2.4.
- Compila el proyecto.
- Ejecuta el archivo Prueba.cs
