Día 13: Origami Transparente 

Llegas a otra parte volcánicamente activa de la cueva. Sería bueno si pudieras hacer algún tipo de imagen térmica para poder saber con anticipación qué cuevas están demasiado calientes para ingresar de manera segura.

¡Afortunadamente, el submarino parece estar equipado con una cámara térmica! Cuando lo activas, eres recibido con:

Congratulations on your purchase! To activate this infrared thermal imaging
camera system, please enter the code found on page 1 of the manual.
Aparentemente, los Elfos nunca han usado esta característica. Para tu sorpresa, logras encontrar el manual; al ir a abrirlo, la página 1 se cae. ¡Es una gran hoja de papel transparente ! El papel transparente está marcado con puntos aleatorios e incluye instrucciones sobre cómo plegarlo (su entrada de rompecabezas). Por ejemplo:
```
6,10
0,14
9,10
0,3
10,4
4,11
6,0
6,12
4,1
0,13
10,12
3,4
3,0
8,4
1,10
2,14
8,10
9,0

fold along y=7
fold along x=5
```
La primera sección es una lista de puntos en el papel transparente. 0,0representa la coordenada superior izquierda. El primer valor, x, aumenta hacia la derecha. El segundo valor, y, aumenta hacia abajo. Entonces, la coordenada 3,0está a la derecha de 0,0y la coordenada 0,7está debajo de 0,0. Las coordenadas en este ejemplo forman el siguiente patrón, donde #es un punto en el papel y .es una posición vacía sin marcar:
```
...#..#..#.
....#......
...........
#..........
...#....#.#
...........
...........
...........
...........
...........
.#....#.##.
....#......
......#...#
#..........
#.#........
```
Luego, hay una lista de instrucciones de plegado . Cada instrucción indica una línea en el papel transparente y quiere que dobles el papel hacia arriba (para y=...líneas horizontales ) o hacia la izquierda (para x=...líneas verticales ). En este ejemplo, la primera instrucción de pliegue es fold along y=7, que designa la línea formada por todas las posiciones donde yestá 7(marcado aquí con -):

```
...#..#..#.
....#......
...........
#..........
...#....#.#
...........
...........
-----------
...........
...........
.#....#.##.
....#......
......#...#
#..........
#.#........
```
Debido a que esta es una línea horizontal, doble la mitad inferior hacia arriba . Algunos de los puntos pueden terminar superponiéndose después de completar el pliegue, pero los puntos nunca aparecerán exactamente en una línea de pliegue. El resultado de hacer este pliegue se ve así:

```
#.##..#..#.
#...#......
......#...#
#...#......
.#.#..#.###
...........
...........
```
Ahora, solo los 17puntos son visibles.

Observe, por ejemplo, los dos puntos en la esquina inferior izquierda antes de doblar el papel transparente; una vez que se completa el pliegue, esos puntos aparecen en la esquina superior izquierda (en 0,0y 0,1). Debido a que el papel es transparente, el punto justo debajo de ellos en el resultado (en 0,3) permanece visible, ya que se puede ver a través del papel transparente.

También observe que algunos puntos pueden terminar superponiéndose ; en este caso, los puntos se fusionan y se convierten en un solo punto.

La segunda instrucción de plegado es fold along x=5, que indica esta línea:
```
#.##.|#..#.
#...#|.....
.....|#...#
#...#|.....
.#.#.|#.###
.....|.....
.....|.....
```

Debido a que esta es una línea vertical, doble a la izquierda :

```
#####
#...#
#...#
#...#
#####
.....
.....
```
¡Las instrucciones formaron un cuadrado!

El papel transparente es bastante grande, así que por ahora concéntrate en completar el primer pliegue. Después del primer pliegue en el ejemplo anterior, los 17puntos son visibles: los puntos que terminan superponiéndose después de completar el pliegue cuentan como un solo punto.

¿Cuántos puntos son visibles después de completar solo la primera instrucción de pliegue en su papel transparente?