 Día 21: Dados de Dirac 
 
No hay mucho que hacer mientras desciendes lentamente al fondo del océano. La computadora submarina te desafía a un buen juego de Dirac Dice .

Este juego consta de un solo dado , dos peones y un tablero de juego con una pista circular que contiene diez espacios marcados 1en el 10sentido de las agujas del reloj. El espacio inicial de cada jugador se elige al azar (su entrada de rompecabezas). El jugador 1 va primero.

Los jugadores se turnan para moverse. En el turno de cada jugador, el jugador lanza el dado tres veces y suma los resultados. Luego, el jugador mueve su peón tantas veces hacia adelante alrededor de la pista (es decir, moviéndose en el sentido de las agujas del reloj en los espacios en orden de valor creciente, volviendo a 1después 10). Por lo tanto, si un jugador está en el espacio 7y que ruede 2, 2y 1, ellos se mueven hacia delante 5 veces, a los espacios 8, 9, 10, 1, y finalmente se para en 2.

Después de que cada jugador se mueve, aumenta su puntuación por el valor del espacio en el que se detuvo su peón. Las puntuaciones de los jugadores comienzan en 0. Entonces, si el primer jugador comienza en el espacio 7y obtiene un total de 5, se detendría en el espacio 2y sumaría 2a su puntuación (para una puntuación total de 2). El juego termina inmediatamente como una victoria para cualquier jugador cuya puntuación alcance al menos1000 .

Dado que el primer juego es un juego de práctica, el submarino abre un compartimento etiquetado como dado determinista y cae un dado de 100 caras. Este dado siempre rueda 1primero, luego 2, luego 3, y así sucesivamente hasta 100, después de lo cual comienza de 1nuevo. Juega con este dado.

Por ejemplo, dadas estas posiciones iniciales:
```
Player 1 starting position: 4
Player 2 starting position: 8
```
Así sería el juego:

- Jugador 1 rollos 1+ 2+ 3y se mueve hacia el espacio 10para una puntuación total de 10.
- Jugador 2 rollos 4+ 5+ 6y se mueve hacia el espacio 3para una puntuación total de 3.
- Jugador 1 rollos 7+ 8+ 9y se mueve hacia el espacio 4para una puntuación total de 14.
- Jugador 2 rollos 10+ 11+ 12y se mueve hacia el espacio 6para una puntuación total de 9.
- Jugador 1 rollos 13+ 14+ 15y se mueve hacia el espacio 6para una puntuación total de 20.
- Jugador 2 rollos 16+ 17+ 18y se mueve hacia el espacio 7para una puntuación total de 16.
- Jugador 1 rollos 19+ 20+ 21y se mueve hacia el espacio 6para una puntuación total de 26.
- Jugador 2 rollos 22+ 23+ 24y se mueve hacia el espacio 6para una puntuación total de 22.

...después de muchas vueltas...

- Jugador 2 rollos 82+ 83+ 84y se mueve hacia el espacio 6para una puntuación total de 742.
- Jugador 1 rollos 85+ 86+ 87y se mueve hacia el espacio 4para una puntuación total de 990.
- Jugador 2 rollos 88+ 89+ 90y se mueve hacia el espacio 3para una puntuación total de 745.
- Jugador 1 rollos 91+ 92+ 93y se mueve hacia el espacio 10para un marcador final, 1000.

Dado que el jugador 1 tiene al menos 1000puntos, el jugador 1 gana y el juego termina. En este punto, el jugador perdedor tenía 745puntos y el dado se había lanzado un total de 993veces; .745 * 993 = 739785

Juega un juego de práctica usando el dado determinista de 100 caras. En el momento en que cualquiera de los jugadores gana, ¿qué obtienes si multiplicas la puntuación del jugador perdedor por el número de veces que se lanzó el dado durante el juego?