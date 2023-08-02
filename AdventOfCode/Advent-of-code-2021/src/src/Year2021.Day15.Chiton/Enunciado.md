Día 15: Quitón 
 
Casi has llegado a la salida de la cueva, pero las paredes se están acercando. Sin embargo, tu submarino apenas puede caber; el principal problema es que las paredes de la cueva están cubiertas de quitones , y lo mejor sería no chocar con ninguno de ellos.

La caverna es grande, pero tiene un techo muy bajo, lo que restringe tu movimiento a dos dimensiones. La forma de la caverna se asemeja a un cuadrado; un escaneo rápido de la densidad de quitones produce un mapa del nivel de riesgo en toda la cueva (su entrada de rompecabezas). Por ejemplo:
```
1163751742
1381373672
2136511328
3694931569
7463417111
1319128137
1359912421
3125421639
1293138521
2311944581
```
Empiezas en la posición superior izquierda, tu destino es la posición inferior derecha y no puedes moverte en diagonal . El número en cada posición es su nivel de riesgo ; para determinar el riesgo total de una ruta completa, sume los niveles de riesgo de cada posición que ingrese (es decir, no cuente el nivel de riesgo de su posición inicial a menos que la ingrese; dejarla no agrega riesgo a su total).

Su objetivo es encontrar un camino con el riesgo total más bajo . En este ejemplo, se destaca aquí una ruta con el riesgo total más bajo:
```
1163751742
1381373672
2136511328
3694931569
7463417111
1319128137
1359912421
3125421639
1293138521
2311944581
```
El riesgo total de esta ruta es 40(la posición inicial nunca se ingresa, por lo que su riesgo no se cuenta).

¿Cuál es el riesgo total más bajo de cualquier camino desde la parte superior izquierda hasta la parte inferior derecha?