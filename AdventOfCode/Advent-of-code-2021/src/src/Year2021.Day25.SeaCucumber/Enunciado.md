 Día 25: Pepino de Mar 
 
Esto es: el fondo de la fosa oceánica, el último lugar donde podrían estar las llaves del trineo. La antena experimental de su submarino aún no está lo suficientemente potenciada para detectar las llaves, pero deben estar aquí. Todo lo que necesitas hacer es llegar al fondo del mar y encontrarlos.

Al menos, aterrizarías en el lecho marino si pudieras; desafortunadamente, está completamente cubierto por dos grandes manadas de pepinos de mar y no hay un espacio abierto lo suficientemente grande para su submarino.

Sospechas que los Elfos deben haber hecho esto antes, porque en ese momento descubres el número de teléfono de un biólogo marino de aguas profundas en una nota escrita a mano pegada en la pared de la cabina del submarino.

"¿Pepinos de mar? Sí, probablemente estén buscando comida. Pero no te preocupes, son criaturas predecibles: se mueven en líneas perfectamente rectas, solo avanzan cuando hay espacio para hacerlo. ¡En realidad son muy educados! "

Explicas que te gustaría predecir cuándo podrías aterrizar tu submarino.

"Oh, eso es fácil, eventualmente se apilarán y dejarán suficiente espacio para-- espera, ¿dijiste submarino? Y el único lugar con tantos pepinos de mar sería en el fondo del Mariana--" Cuelgas el teléfono. teléfono.

Hay dos manadas de pepinos de mar que comparten la misma región; uno siempre se mueve hacia el este ( >), mientras que el otro siempre se mueve hacia el sur ( v). Cada ubicación puede contener como máximo un pepino de mar; las ubicaciones restantes están vacías ( .). El submarino genera útilmente un mapa de la situación (su entrada de rompecabezas). Por ejemplo:
```
v...>>.vv>
.vv>>.vv..
>>.>v>...v
>>v>>.>.v.
v>v.vv.v..
>.>>..v...
.vv..>.>v.
v.v..>>v.v
....v..v.>
```
En cada paso , los pepinos de mar de la manada que mira hacia el este intentan avanzar una ubicación, luego los pepinos de mar de la manada que mira hacia el sur intentan avanzar una ubicación. Cuando una manada avanza, cada pepino de mar en la manada primero considera simultáneamente si hay un pepino de mar en el lugar adyacente al que mira (incluso otro pepino de mar que mira en la misma dirección), y luego cada pepino de mar que mira hacia un lugar vacío se mueve simultáneamente hacia esa ubicación

Entonces, en una situación como esta:
```
...>>>>>...
```
Después de un paso, solo el pepino de mar más a la derecha se habría movido:

```
...>>>>.>..
```
Después del siguiente paso, se mueven dos pepinos de mar:

```
...>>>.>.>.
```
Durante un solo paso, la manada que mira hacia el este se mueve primero, luego la manada que mira hacia el sur se mueve. Entonces, dada esta situación:

```
..........
.>v....v..
.......>..
..........
```
Después de un solo paso, de los pepinos de mar de la izquierda, solo el pepino de mar que mira hacia el sur se ha movido (ya que no se apartó a tiempo para que se moviera el pepino de mar que mira hacia el este a la izquierda), pero ambos pepinos de mar los pepinos de la derecha se han movido (ya que el pepino de mar que mira hacia el este se apartó del camino del pepino de mar que mira hacia el sur):
```
..........
.>........
..v....v>.
..........
```
Debido a las fuertes corrientes de agua en el área, los pepinos de mar que se mueven fuera del borde derecho del mapa aparecen en el borde izquierdo y los pepinos de mar que se mueven fuera del borde inferior del mapa aparecen en el borde superior. Los pepinos de mar siempre verifican si su ubicación de destino está vacía antes de moverse, incluso si ese destino está en el lado opuesto del mapa:
```
Initial state:
...>...
.......
......>
v.....>
......>
.......
..vvv..

After 1 step:
..vv>..
.......
>......
v.....>
>......
.......
....v..

After 2 steps:
....v>.
..vv...
.>.....
......>
v>.....
.......
.......

After 3 steps:
......>
..v.v..
..>v...
>......
..>....
v......
.......

After 4 steps:
>......
..v....
..>.v..
.>.v...
...>...
.......
v......
```
Para encontrar un lugar seguro para aterrizar su submarino, los pepinos de mar deben dejar de moverse. Nuevamente considere el primer ejemplo:

```
Initial state:
v...>>.vv>
.vv>>.vv..
>>.>v>...v
>>v>>.>.v.
v>v.vv.v..
>.>>..v...
.vv..>.>v.
v.v..>>v.v
....v..v.>

After 1 step:
....>.>v.>
v.v>.>v.v.
>v>>..>v..
>>v>v>.>.v
.>v.v...v.
v>>.>vvv..
..v...>>..
vv...>>vv.
>.v.v..v.v

After 2 steps:
>.v.v>>..v
v.v.>>vv..
>v>.>.>.v.
>>v>v.>v>.
.>..v....v
.>v>>.v.v.
v....v>v>.
.vv..>>v..
v>.....vv.

After 3 steps:
v>v.v>.>v.
v...>>.v.v
>vv>.>v>..
>>v>v.>.v>
..>....v..
.>.>v>v..v
..v..v>vv>
v.v..>>v..
.v>....v..

After 4 steps:
v>..v.>>..
v.v.>.>.v.
>vv.>>.v>v
>>.>..v>.>
..v>v...v.
..>>.>vv..
>.v.vv>v.v
.....>>vv.
vvv>...v..

After 5 steps:
vv>...>v>.
v.v.v>.>v.
>.v.>.>.>v
>v>.>..v>>
..v>v.v...
..>.>>vvv.
.>...v>v..
..v.v>>v.v
v.v.>...v.

...

After 10 steps:
..>..>>vv.
v.....>>.v
..v.v>>>v>
v>.>v.>>>.
..v>v.vv.v
.v.>>>.v..
v.v..>v>..
..v...>v.>
.vv..v>vv.

...

After 20 steps:
v>.....>>.
>vv>.....v
.>v>v.vv>>
v>>>v.>v.>
....vv>v..
.v.>>>vvv.
..v..>>vv.
v.v...>>.v
..v.....v>

...

After 30 steps:
.vv.v..>>>
v>...v...>
>.v>.>vv.>
>v>.>.>v.>
.>..v.vv..
..v>..>>v.
....v>..>v
v.v...>vv>
v.v...>vvv

...

After 40 steps:
>>v>v..v..
..>>v..vv.
..>>>v.>.v
..>>>>vvv>
v.....>...
v.v...>v>>
>vv.....v>
.>v...v.>v
vvv.v..v.>

...

After 50 steps:
..>>v>vv.v
..v.>>vv..
v.>>v>>v..
..>>>>>vv.
vvv....>vv
..v....>>>
v>.......>
.vv>....v>
.>v.vv.v..

...

After 55 steps:
..>>v>vv..
..v.>>vv..
..>>v>>vv.
..>>>>>vv.
v......>vv
v>v....>>v
vvv...>..>
>vv.....>.
.>v.vv.v..

After 56 steps:
..>>v>vv..
..v.>>vv..
..>>v>>vv.
..>>>>>vv.
v......>vv
v>v....>>v
vvv....>.>
>vv......>
.>v.vv.v..

After 57 steps:
..>>v>vv..
..v.>>vv..
..>>v>>vv.
..>>>>>vv.
v......>vv
v>v....>>v
vvv.....>>
>vv......>
.>v.vv.v..

After 58 steps:
..>>v>vv..
..v.>>vv..
..>>v>>vv.
..>>>>>vv.
v......>vv
v>v....>>v
vvv.....>>
>vv......>
.>v.vv.v..
```
En este ejemplo, los pepinos de mar dejan de moverse después de los 58pasos.

Encuentra un lugar seguro para aterrizar tu submarino. ¿Cuál es el primer escalón en el que no se mueven pepinos de mar?