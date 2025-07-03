
# Formato compuesto en C#

El formato compuesto usa marcadores de posición numerados dentro de una cadena. En tiempo de ejecución, todo lo que hay dentro de las llaves se resolverá en un valor que también se pasa en función de su posición.

En este ejemplo de formato compuesto se usa un método Format() integrado en la palabra clave de tipo de datos string. Actualice el código en el editor de Visual Studio Code de la siguiente manera:

````CSharp
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
`````

La salida del código anterior es:

````CSharp
Hello World!
````
