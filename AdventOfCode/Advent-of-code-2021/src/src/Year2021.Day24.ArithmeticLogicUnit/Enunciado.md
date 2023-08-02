Día 24: Unidad Aritmética Lógica 

El humo mágico comienza a salir de la unidad lógica aritmética (ALU) del submarino . ¡Sin la capacidad de realizar funciones aritméticas y lógicas básicas, el submarino no puede producir patrones geniales con sus luces navideñas!

Tampoco puede navegar. O haz funcionar el sistema de oxígeno.

Sin embargo, no se preocupe, probablemente le quede suficiente oxígeno para tener suficiente tiempo para construir una nueva ALU.

La ALU es una unidad de procesamiento de cuatro dimensiones: tiene número entero de variables w, x, y, y z. Todas estas variables comienzan con el valor 0. La ALU también admite seis instrucciones :

- inp a- Leer un valor de entrada y escribirlo en la variable a.
- add a b- Agregue el valor de aal valor de b, luego almacene el resultado en variable a.
- mul a b- Multiplique el valor de apor el valor de b, luego almacene el resultado en variable a.
- div a b- Divida el valor de apor el valor de b, trunque el resultado a un número entero y luego almacene el resultado en la variable a. (Aquí, "truncar" significa redondear el valor hacia cero).
- mod a b- Dividir el valor de apor el valor de b, luego almacenar el resto en variable a. (Esto también se llama la operación de módulo .)
- eql a b- Si el valor de ay bson iguales, almacene el valor 1en la variable a. De lo contrario, almacene el valor 0en la variable a.

En todas estas instrucciones, ay bson marcadores de posición; asiempre será la variable donde se almacena el resultado de la operación (uno de w, x, y, o z), mientras que bpuede ser una variable o un número. Los números pueden ser positivos o negativos, pero siempre serán enteros.

La ALU no tiene instrucciones de salto ; en un programa ALU, cada instrucción se ejecuta exactamente una vez en orden de arriba hacia abajo. El programa se detiene después de que la última instrucción ha terminado de ejecutarse.

(Los autores del programa deben ser especialmente cautelosos; intentar ejecutar divcon b=0o intentar ejecutar modcon a<0o b<=0 hará que el programa se bloquee e incluso podría dañar la ALU . Estas operaciones nunca están previstas en ningún programa serio de ALU).

Por ejemplo, aquí hay un programa ALU que toma un número de entrada, lo niega y lo almacena en x:
```
inp x
mul x -1
```
Aquí es un programa ALU que toma dos números de entrada, a continuación, establece za 1si el segundo número de entrada es tres veces más grande que el primer número de entrada, o conjuntos za 0lo contrario:
```
inp z
inp x
mul z 3
eql z x
```
Aquí hay un programa ALU que toma un número entero no negativo como entrada, lo convierte en binario y almacena el bit más bajo (1) en z, el segundo bit más bajo (2) en y, el tercer bit más bajo (4) en x, y el cuarto bit más bajo (8) en w:

```
inp w
add z w
mod z 2
div w 2
add y w
mod y 2
div w 2
add x w
mod x 2
div w 2
mod w 2
```
Una vez que haya construido una ALU de reemplazo, puede instalarla en el submarino, que reanudará inmediatamente lo que estaba haciendo cuando la ALU falló: validar el número de modelo del submarino . Para hacer esto, la ALU ejecutará el programa Detector automático de número de modelo (MONAD, su entrada de rompecabezas).

Los números de modelo de submarinos son siempre números de catorce dígitos que consisten solo en dígitos 1hasta 9. El dígito 0 no puede aparecer en un número de modelo.

Cuando MONAD verifica un número de modelo hipotético de catorce dígitos, usa catorce inpinstrucciones separadas , cada una de las cuales espera un solo dígito del número de modelo en orden de mayor a menos significativo. (Entonces, para verificar el número de modelo 13579246899999, le daría 1a la primera inpinstrucción, 3a la segunda inpinstrucción, 5a la tercera inpinstrucción, y así sucesivamente). Esto significa que al operar MONAD, cada instrucción de entrada solo debe recibir un valor entero. de por lo menos 1y como máximo 9.

Luego, después de que MONAD haya terminado de ejecutar todas sus instrucciones, indicará que el número de modelo era válido dejando una 0variable en z. Sin embargo, si el número de modelo no es válido , dejará algún otro valor distinto de cero en z.

MONAD impone restricciones adicionales y misteriosas sobre los números de modelo, y la leyenda dice que un tanuki se comió la última copia de la documentación de MONAD . Tendrá que averiguar qué hace MONAD de alguna otra manera.

Para habilitar tantas funciones submarinas como sea posible, busque el número de modelo de catorce dígitos válido más grande que no contenga 0dígitos. ¿Cuál es el número de modelo más grande aceptado por MONAD?