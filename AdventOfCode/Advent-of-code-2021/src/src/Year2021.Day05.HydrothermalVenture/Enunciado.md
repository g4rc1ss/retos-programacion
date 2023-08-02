Día 5: Aventura Hidrotermal

¡Te encuentras con un campo de respiraderos hidrotermales en el fondo del océano! Estos respiraderos producen constantemente nubes grandes y opacas, por lo que sería mejor evitarlos si es posible.

Tienden a formarse en filas ; el submarino produce una lista de líneas cercanas de respiraderos (su entrada de rompecabezas) para que la revise. Por ejemplo:
```
0,9 -> 5,9
8,0 -> 0,8
9,4 -> 3,4
2,2 -> 2,1
7,0 -> 7,4
6,4 -> 2,0
0,9 -> 2,9
3,4 -> 1,4
0,0 -> 8,8
5,5 -> 8,2
```
Cada línea de respiraderos se da como un segmento de línea en el formato x1,y1 -> x2,y2donde x1, y1son las coordenadas de un extremo del segmento de línea y x2, y2son las coordenadas del otro extremo. Estos segmentos de línea incluyen los puntos en ambos extremos. En otras palabras:

Una entrada como 1,1 -> 1,3cubiertas puntos 1,1, 1,2, y 1,3.
Una entrada como 9,7 -> 7,7cubiertas puntos 9,7, 8,7, y 7,7.
Por ahora, solo considere las líneas horizontales y verticales : líneas donde x1 = x2o y1 = y2.

Entonces, las líneas horizontales y verticales de la lista anterior producirían el siguiente diagrama:
```
.......1..
..1....1..
..1....1..
.......1..
.112111211
..........
..........
..........
..........
222111....
```
En este diagrama, la esquina superior izquierda es 0,0y la esquina inferior derecha es 9,9. Cada posición se muestra como el número de líneas que cubren ese punto o .si ninguna línea cubre ese punto. El par superior izquierdo de 1s, por ejemplo, proviene de 2,2 -> 2,1; la fila inferior está formada por las líneas superpuestas 0,9 -> 5,9y 0,9 -> 2,9.

Para evitar las áreas más peligrosas, debe determinar la cantidad de puntos donde se superponen al menos dos líneas . En el ejemplo anterior, esto está en cualquier parte del diagrama con un 2o más grande: un total de 5puntos.

Considere solo líneas horizontales y verticales. ¿En cuántos puntos se superponen al menos dos rectas?