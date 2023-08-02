Día 4: Calamar Gigante

Ya estás a casi 1,5 km (casi una milla) por debajo de la superficie del océano, tan profundo que no puedes ver la luz del sol. Sin embargo, lo que puede ver es un calamar gigante que se ha adherido al exterior de su submarino.

¿Quizás quiere jugar al bingo ?

El bingo se juega en un conjunto de tableros, cada uno de los cuales consta de una cuadrícula de números de 5x5. Los números se eligen al azar y el número elegido se marca en todos los tableros en los que aparece. (Es posible que los números no aparezcan en todos los tableros). Si se marcan todos los números en cualquier fila o columna de un tablero, ese tablero gana . (Las diagonales no cuentan).

El submarino tiene un subsistema de bingo para ayudar a los pasajeros (actualmente, tú y el calamar gigante) a pasar el tiempo. Genera automáticamente un orden aleatorio en el que dibujar números y un conjunto aleatorio de tableros (su entrada de rompecabezas). Por ejemplo:
```
7,4,9,5,11,17,23,2,0,14,21,24,10,16,13,6,15,25,12,22,18,20,8,19,3,26,1

22 13 17 11  0
 8  2 23  4 24
21  9 14 16  7
 6 10  3 18  5
 1 12 20 15 19

 3 15  0  2 22
 9 18 13 17  5
19  8  7 25 23
20 11 10 24  4
14 21 16 12  6

14 21 17 24  4
10 16 15  9 19
18  8 23 26 20
22 11 13  6  5
 2  0 12  3  7
```
Después de sortear los primeros cinco números ( 7, 4, 9, 5y 11), no hay ganadores, pero los tableros se marcan de la siguiente manera (aquí se muestran uno al lado del otro para ahorrar espacio):
```
22 13 17 11  0         3 15  0  2 22        14 21 17 24  4
 8  2 23  4 24         9 18 13 17  5        10 16 15  9 19
21  9 14 16  7        19  8  7 25 23        18  8 23 26 20
 6 10  3 18  5        20 11 10 24  4        22 11 13  6  5
 1 12 20 15 19        14 21 16 12  6         2  0 12  3  7
```
Después de que los próximos seis números se dibujan ( 17, 23, 2, 0, 14, y 21), todavía no hay ganadores:
```
22 13 17 11  0         3 15  0  2 22        14 21 17 24  4
 8  2 23  4 24         9 18 13 17  5        10 16 15  9 19
21  9 14 16  7        19  8  7 25 23        18  8 23 26 20
 6 10  3 18  5        20 11 10 24  4        22 11 13  6  5
 1 12 20 15 19        14 21 16 12  6         2  0 12  3  7
```
Finalmente, 24se dibuja:
```
22 13 17 11  0         3 15  0  2 22        14 21 17 24  4
 8  2 23  4 24         9 18 13 17  5        10 16 15  9 19
21  9 14 16  7        19  8  7 25 23        18  8 23 26 20
 6 10  3 18  5        20 11 10 24  4        22 11 13  6  5
 1 12 20 15 19        14 21 16 12  6         2  0 12  3  7
```
En este punto, el tercer tablero gana porque tiene al menos una fila o columna completa de números marcados (en este caso, toda la fila superior está marcada: 14 21 17 24 4).

La puntuación de la junta ganando ahora se puede calcular. Comience por encontrar la suma de todos los números sin marcar en ese tablero; en este caso, la suma es 188. Luego, multiplique esa suma por el número que se acaba de llamar cuando ganó la mesa 24, para obtener el puntaje final, .188 * 24 = 4512

Para garantizar la victoria contra el calamar gigante, descubra qué tablero ganará primero. ¿Cuál será tu puntuación final si eliges ese tablero?