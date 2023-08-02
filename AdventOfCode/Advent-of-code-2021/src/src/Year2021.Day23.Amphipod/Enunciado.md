Día 23: Anfípodo 

Un grupo de anfípodos nota tu elegante submarino y te hace señas. "Con un caparazón tan impresionante", dice un anfípodo , "seguramente puede ayudarnos con una pregunta que ha dejado perplejos a nuestros mejores científicos".

Continúan explicando que un grupo de anfípodos tímidos y obstinados vive en una madriguera cercana. Allí viven cuatro tipos de anfípodos: Ámbar ( A), Bronce ( B), Cobre ( C) y Desierto ( D). Viven en una madriguera que consta de un pasillo y cuatro habitaciones laterales . Las habitaciones laterales están inicialmente llenas de anfípodos y el pasillo inicialmente está vacío.

Te dan un diagrama de la situación (la entrada rompecabezas), incluyendo la ubicación de cada uno de anfípodos ( A, B, C, o D, cada uno de los cuales está ocupando un espacio abierto de otro modo), paredes ( #), y el espacio abierto ( .).

Por ejemplo:
```
#############
#...........#
###B#C#B#D###
  #A#D#C#A#
  #########
```
A los anfípodos les gustaría un método para organizar cada anfípodo en habitaciones laterales, de modo que cada habitación lateral contenga un tipo de anfípodo y los tipos estén ordenados A, de Dizquierda a derecha, así:
```
#############
#...........#
###A#B#C#D###
  #A#B#C#D#
  #########
```
Los anfípodos pueden moverse hacia arriba, hacia abajo, hacia la izquierda o hacia la derecha siempre que se muevan hacia un espacio abierto desocupado. Cada tipo de anfípodo requiere una cantidad diferente de energía para moverse un paso: los anfípodos de color ámbar requieren 1energía por paso, los anfípodos de bronce requieren 10energía, los anfípodos de cobre requieren energía 100y los del desierto requieren energía 1000. A los anfípodos les gustaría que encontraras una forma de organizar los anfípodos que requiera la menor cantidad de energía total .

Sin embargo, debido a que son tímidos y tercos, los anfípodos tienen algunas reglas adicionales:
- Los anfípodos nunca se detendrán en el espacio inmediatamente fuera de cualquier habitación . Pueden moverse a ese espacio siempre y cuando continúen moviéndose inmediatamente. (Específicamente, esto se refiere a los cuatro espacios abiertos en el pasillo que están directamente encima de la posición inicial de un anfípodo).
- Los anfípodos nunca se moverán del pasillo a una habitación a menos que esa habitación sea su habitación de destino y esa habitación no contenga anfípodos que no tengan también esa habitación como su propio destino. Si la habitación inicial de un anfípodo no es su habitación de destino, puede permanecer en esa habitación hasta que la abandone. (Por ejemplo, un anfípodo ámbar no se moverá del pasillo a las tres habitaciones de la derecha, y solo se moverá a la habitación más a la izquierda si esa habitación está vacía o si solo contiene otros anfípodos ámbar).
- Una vez que un anfípodo deja de moverse en el pasillo, permanecerá en ese lugar hasta que pueda moverse a una habitación . (Es decir, una vez que cualquier anfípodo comienza a moverse, cualquier otro anfípodo que se encuentre actualmente en el pasillo se bloquea en su lugar y no se volverá a mover hasta que pueda moverse por completo en una habitación).

En el ejemplo anterior, los anfípodos se pueden organizar utilizando un mínimo de 12521energía. Una forma de hacer esto se muestra a continuación.

Configuración inicial:
```
#############
#...........#
###B#C#B#D###
  #A#D#C#A#
  #########
```
Un anfípodo de bronce se mueve hacia el pasillo, da 4 pasos y usa 40energía:
```
#############
#...B.......#
###B#C#.#D###
  #A#D#C#A#
  #########
```
El único anfípodo de cobre que no está en su habitación lateral se mueve allí, dando 4 pasos y usando 400energía:
```
#############
#...B.......#
###B#.#C#D###
  #A#D#C#A#
  #########
```
Un anfípodo del desierto se aparta del camino, da 3 pasos y usa 3000energía, y luego el anfípodo de bronce toma su lugar, da 3 pasos y usa 30energía:
```
#############
#.....D.....#
###B#.#C#D###
  #A#B#C#A#
  #########
```
El anfípodo de bronce más a la izquierda se mueve a su habitación usando 40energía:
```
#############
#.....D.....#
###.#B#C#D###
  #A#B#C#A#
  #########
```
Ambos anfípodos en la habitación más a la derecha se mueven hacia el pasillo, usando 2003energía en total:
```
#############
#.....D.D.A.#
###.#B#C#.###
  #A#B#C#.#
  #########
```
Ambos anfípodos del desierto se mueven hacia la habitación más a la derecha usando 7000energía:
```
#############
#.........A.#
###.#B#C#D###
  #A#B#C#D#
  #########
```
Finalmente, el último anfípodo ámbar se muda a su habitación, usando 8energía:
```
#############
#...........#
###A#B#C#D###
  #A#B#C#D#
  #########
```
¿Cuál es la energía mínima requerida para organizar los anfípodos?