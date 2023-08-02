Día 9: Cuenca del Humo

Estas cuevas parecen ser tubos de lava . Algunas partes son aún volcánicamente activas; pequeños respiraderos hidrotermales liberan humo en las cuevas que se asienta lentamente como la lluvia .

Si puede modelar cómo fluye el humo a través de las cuevas, es posible que pueda evitarlo y estar mucho más seguro. El submarino genera un mapa de altura del suelo de las cuevas cercanas para ti (tu entrada de rompecabezas).

El humo fluye hacia el punto más bajo del área en la que se encuentra. Por ejemplo, considere el siguiente mapa de altura:
```
2199943210
3987894921
9856789892
8767896789
9899965678
```
Cada número corresponde a la altura de una ubicación en particular, donde 9es la más alta y 0la más baja que puede ser una ubicación.

Su primer objetivo es encontrar los puntos bajos : las ubicaciones que están más bajas que cualquiera de sus ubicaciones adyacentes. La mayoría de las ubicaciones tienen cuatro ubicaciones adyacentes (arriba, abajo, izquierda y derecha); las ubicaciones en el borde o la esquina del mapa tienen tres o dos ubicaciones adyacentes, respectivamente. (Las ubicaciones en diagonal no cuentan como adyacentes).

En el ejemplo anterior, hay cuatro puntos bajos, todos resaltados: dos están en la primera fila (a 1y a 0), uno está en la tercera fila (a 5) y uno está en la fila inferior (también a 5). Todas las demás ubicaciones en el mapa de altura tienen una ubicación adyacente más baja, por lo que no son puntos bajos.

El nivel de riesgo de un punto bajo es 1 más su altura . En el ejemplo anterior, los niveles de riesgo de los puntos bajos son 2, 1, 6, y 6. Por lo tanto, la suma de los niveles de riesgo de todos los puntos bajos en el mapa de altura es 15.

Encuentra todos los puntos bajos en tu mapa de altura. ¿Cuál es la suma de los niveles de riesgo de todos los puntos bajos en su mapa de altura?