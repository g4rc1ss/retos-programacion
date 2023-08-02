Día 18: Pez caracol 

Desciendes a la fosa oceánica y te encuentras con algunos peces caracol . ¡Dicen que vieron las llaves del trineo! Incluso te dirán en qué dirección fueron las llaves si ayudas a uno de los peces caracol más pequeños con su tarea de matemáticas .

Los números de snailfish no son como los números regulares. En cambio, cada número de pez caracol es un par , una lista ordenada de dos elementos. Cada elemento del par puede ser un número regular u otro par.

Los pares se escriben como [x,y], donde xy yson los elementos dentro del par. Aquí hay algunos números de pez caracol de ejemplo, un número de pez caracol por línea:
```
[1,2]
[[1,2],3]
[9,[8,7]]
[[1,9],[8,5]]
[[[[1,2],[3,4]],[[5,6],[7,8]]],9]
[[[9,[3,8]],[[0,9],6]],[[[3,7],[4,9]],3]]
[[[[1,3],[5,3]],[[1,3],[8,7]]],[[[4,9],[6,9]],[[8,2],[7,3]]]]
```
Esta tarea pez caracol se trata además . Para sumar dos números de pez caracol, forme un par a partir de los parámetros izquierdo y derecho del operador de suma. Por ejemplo, [1,2]+ se [[3,4],5]convierte en [[1,2],[[3,4],5]].

Solo hay un problema: los números de peces caracol siempre deben reducirse , y el proceso de sumar dos números de peces caracol puede dar como resultado números de peces caracol que deben reducirse.

Para reducir un número de pez caracol , debe realizar repetidamente la primera acción de esta lista que se aplica al número de pez caracol:
- Si cualquier par está anidado dentro de cuatro pares , el par más a la izquierda explota .
- Si cualquier número regular es 10 o mayor , el número regular más a la izquierda se divide .

Una vez que no se aplica ninguna acción en la lista anterior, el número de snailfish se reduce.

Durante la reducción, se aplica como máximo una acción, después de lo cual el proceso vuelve a la parte superior de la lista de acciones. Por ejemplo, si la división produce un par que cumple con los criterios de explosión , ese par explota antes de que ocurran otras divisiones .

Para explotar un par, el valor de la izquierda del par se suma al primer número regular a la izquierda del par que explota (si lo hay), y el valor de la derecha del par se suma al primer número regular a la derecha del par que explota (si lo hay). ). Los pares explosivos siempre consistirán en dos números regulares. Luego, el par explosivo completo se reemplaza con el número regular 0.

Estos son algunos ejemplos de una sola acción de explosión:
- [[[[[9,8],1],2],3],4]se convierte en (the no tiene un número regular a su izquierda, por lo que no se suma a ningún número regular).[[[[0,9],2],3],4]9
- [7,[6,[5,[4,[3,2]]]]]se convierte en (the no tiene un número regular a su derecha, por lo que no se suma a ningún número regular).[7,[6,[5,[7,0]]]]2
- [[6,[5,[4,[3,2]]]],1]se convierte .[[6,[5,[7,0]]],3]
- [[3,[2,[1,[7,3]]]],[6,[5,[4,[3,2]]]]]se vuelve (el par no se ve afectado porque el par está más a la izquierda; explotaría en la siguiente acción).[[3,[2,[8,0]]],[9,[5,[4,[3,2]]]]][3,2][7,3][3,2]
- [[3,[2,[8,0]]],[9,[5,[4,[3,2]]]]]se convierte .[[3,[2,[8,0]]],[9,[5,[7,0]]]]

Para dividir un número regular, reemplácelo con un par; el elemento izquierdo del par debe ser el número regular dividido por dos y redondeado hacia abajo , mientras que el elemento derecho del par debe ser el número regular dividido por dos y redondeado hacia arriba . Por ejemplo, se 10vuelve [5,5], se 11vuelve [5,6], se 12vuelve [6,6], y así sucesivamente.

Aquí está el proceso de encontrar el resultado reducido de [[[[4,3],4],4],[7,[[8,4],9]]]+ [1,1]:
```
after addition: [[[[[4,3],4],4],[7,[[8,4],9]]],[1,1]]
after explode:  [[[[0,7],4],[7,[[8,4],9]]],[1,1]]
after explode:  [[[[0,7],4],[15,[0,13]]],[1,1]]
after split:    [[[[0,7],4],[[7,8],[0,13]]],[1,1]]
after split:    [[[[0,7],4],[[7,8],[0,[6,7]]]],[1,1]]
after explode:  [[[[0,7],4],[[7,8],[6,0]]],[8,1]]
```
Una vez que no se aplican acciones de reducción, el número de pez caracol que queda es el resultado real de la operación de suma: [[[[0,7],4],[[7,8],[6,0]]],[8,1]].

La tarea consiste en sumar una lista de números de peces caracol (su entrada de rompecabezas). Los números de pez caracol se enumeran cada uno en una línea separada. Agregue el primer número de pez caracol y el segundo, luego agregue ese resultado y el tercero, luego agregue ese resultado y el cuarto, y así sucesivamente hasta que todos los números en la lista se hayan usado una vez.

Por ejemplo, la suma final de esta lista es [[[[1,1],[2,2]],[3,3]],[4,4]]:
```
[1,1]
[2,2]
[3,3]
[4,4]
```
La suma final de esta lista es [[[[3,0],[5,3]],[4,4]],[5,5]]:
```
[1,1]
[2,2]
[3,3]
[4,4]
[5,5]
```
La suma final de esta lista es [[[[5,0],[7,4]],[5,5]],[6,6]]:

```
[1,1]
[2,2]
[3,3]
[4,4]
[5,5]
[6,6]
```
Aquí hay un ejemplo un poco más grande:
```
[[[0,[4,5]],[0,0]],[[[4,5],[2,6]],[9,5]]]
[7,[[[3,7],[4,3]],[[6,3],[8,8]]]]
[[2,[[0,8],[3,4]]],[[[6,7],1],[7,[1,6]]]]
[[[[2,4],7],[6,[0,5]]],[[[6,8],[2,8]],[[2,1],[4,5]]]]
[7,[5,[[3,8],[1,4]]]]
[[2,[2,2]],[8,[8,1]]]
[2,9]
[1,[[[9,3],9],[[9,0],[0,7]]]]
[[[5,[7,4]],7],1]
[[[[4,2],2],6],[8,7]]
```
La suma final [[[[8,7],[7,7]],[[8,6],[7,7]]],[[[0,7],[6,6]],[8,7]]]se encuentra después de sumar los números de pez caracol anteriores:

```
  [[[0,[4,5]],[0,0]],[[[4,5],[2,6]],[9,5]]]
+ [7,[[[3,7],[4,3]],[[6,3],[8,8]]]]
= [[[[4,0],[5,4]],[[7,7],[6,0]]],[[8,[7,7]],[[7,9],[5,0]]]]

  [[[[4,0],[5,4]],[[7,7],[6,0]]],[[8,[7,7]],[[7,9],[5,0]]]]
+ [[2,[[0,8],[3,4]]],[[[6,7],1],[7,[1,6]]]]
= [[[[6,7],[6,7]],[[7,7],[0,7]]],[[[8,7],[7,7]],[[8,8],[8,0]]]]

  [[[[6,7],[6,7]],[[7,7],[0,7]]],[[[8,7],[7,7]],[[8,8],[8,0]]]]
+ [[[[2,4],7],[6,[0,5]]],[[[6,8],[2,8]],[[2,1],[4,5]]]]
= [[[[7,0],[7,7]],[[7,7],[7,8]]],[[[7,7],[8,8]],[[7,7],[8,7]]]]

  [[[[7,0],[7,7]],[[7,7],[7,8]]],[[[7,7],[8,8]],[[7,7],[8,7]]]]
+ [7,[5,[[3,8],[1,4]]]]
= [[[[7,7],[7,8]],[[9,5],[8,7]]],[[[6,8],[0,8]],[[9,9],[9,0]]]]

  [[[[7,7],[7,8]],[[9,5],[8,7]]],[[[6,8],[0,8]],[[9,9],[9,0]]]]
+ [[2,[2,2]],[8,[8,1]]]
= [[[[6,6],[6,6]],[[6,0],[6,7]]],[[[7,7],[8,9]],[8,[8,1]]]]

  [[[[6,6],[6,6]],[[6,0],[6,7]]],[[[7,7],[8,9]],[8,[8,1]]]]
+ [2,9]
= [[[[6,6],[7,7]],[[0,7],[7,7]]],[[[5,5],[5,6]],9]]

  [[[[6,6],[7,7]],[[0,7],[7,7]]],[[[5,5],[5,6]],9]]
+ [1,[[[9,3],9],[[9,0],[0,7]]]]
= [[[[7,8],[6,7]],[[6,8],[0,8]]],[[[7,7],[5,0]],[[5,5],[5,6]]]]

  [[[[7,8],[6,7]],[[6,8],[0,8]]],[[[7,7],[5,0]],[[5,5],[5,6]]]]
+ [[[5,[7,4]],7],1]
= [[[[7,7],[7,7]],[[8,7],[8,7]]],[[[7,0],[7,7]],9]]

  [[[[7,7],[7,7]],[[8,7],[8,7]]],[[[7,0],[7,7]],9]]
+ [[[[4,2],2],6],[8,7]]
= [[[[8,7],[7,7]],[[8,6],[7,7]]],[[[0,7],[6,6]],[8,7]]]
```
Para comprobar si es la respuesta correcta, el profesor pez caracol sólo comprueba la magnitud de la suma final. La magnitud de un par es 3 veces la magnitud de su elemento izquierdo más 2 veces la magnitud de su elemento derecho. La magnitud de un número regular es precisamente ese número.

Por ejemplo, la magnitud de [9,1]es ; la magnitud de es . Los cálculos de magnitud son recursivos: la magnitud de es .3*9 + 2*1 = 29[1,9]3*1 + 2*9 = 21[[9,1],[1,9]]3*29 + 2*21 = 129

Aquí hay algunos ejemplos más de magnitud:

- [[1,2],[[3,4],5]]se convierte 143.
- [[[[0,7],4],[[7,8],[6,0]]],[8,1]]se convierte 1384.
- [[[[1,1],[2,2]],[3,3]],[4,4]]se convierte 445.
- [[[[3,0],[5,3]],[4,4]],[5,5]]se convierte 791.
- [[[[5,0],[7,4]],[5,5]],[6,6]]se convierte 1137.
- [[[[8,7],[7,7]],[[8,6],[7,7]]],[[[0,7],[6,6]],[8,7]]]se convierte 3488.

Entonces, dado este ejemplo de tarea:
```
[[[0,[5,8]],[[1,7],[9,6]]],[[4,[1,2]],[[1,4],2]]]
[[[5,[2,8]],4],[5,[[9,9],0]]]
[6,[[[6,2],[5,6]],[[7,6],[4,7]]]]
[[[6,[0,7]],[0,9]],[4,[9,[9,0]]]]
[[[7,[6,4]],[3,[1,3]]],[[[5,5],1],9]]
[[6,[[7,3],[3,2]]],[[[3,8],[5,7]],4]]
[[[[5,4],[7,7]],8],[[8,3],8]]
[[9,3],[[9,9],[6,[4,9]]]]
[[2,[[7,7],7]],[[5,8],[[9,3],[0,2]]]]
[[[[5,2],5],[8,[3,7]]],[[5,[7,5]],[4,4]]]
```
La suma final es:

`[[[[6,6],[7,6]],[[7,7],[7,0]]],[[[7,7],[7,7]],[[7,8],[9,9]]]]`

La magnitud de esta suma final es 4140.

Sume todos los números de pez caracol de la tarea asignada en el orden en que aparecen. ¿Cuál es la magnitud de la suma final?
