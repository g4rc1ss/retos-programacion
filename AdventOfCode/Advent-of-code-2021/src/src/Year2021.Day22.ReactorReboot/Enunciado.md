Día 22: Reinicio del reactor 

Operar a estas profundidades oceánicas extremas ha sobrecargado el reactor del submarino; necesita ser reiniciado.

El núcleo del reactor está formado por una gran cuadrícula tridimensional formada completamente por cubos, un cubo por coordenada tridimensional entera ( x,y,z). Cada cubo puede estar encendido o apagado ; al comienzo del proceso de reinicio, todos están apagados . (¿Podría ser un modelo antiguo de un reactor que hayas visto antes ?)

Para reiniciar el reactor, sólo tiene que configurar todos los cubos a cualquiera en o fuera siguiendo una lista de pasos de reinicio (la entrada rompecabezas). Cada paso especifica un cuboide (el conjunto de todos los cubos que tienen coordenadas que caen dentro de los rangos para x, yy z) y si a su vez todos los cubos en que cuboide en o fuera .

Por ejemplo, dados estos pasos de reinicio:
```
on x=10..12,y=10..12,z=10..12
on x=11..13,y=11..13,z=11..13
off x=9..11,y=9..11,z=9..11
on x=10..10,y=10..10,z=10..10
```
El primer paso ( on x=10..12,y=10..12,z=10..12) se convierte en un paralelepípedo 3x3x3 que consta de 27 cubos:

- 10,10,10
- 10,10,11
- 10,10,12
- 10,11,10
- 10,11,11
- 10,11,12
- 10,12,10
- 10,12,11
- 10,12,12
- 11,10,10
- 11,10,11
- 11,10,12
- 11,11,10
- 11,11,11
- 11,11,12
- 11,12,10
- 11,12,11
- 11,12,12
- 12,10,10
- 12,10,11
- 12,10,12
- 12,11,10
- 12,11,11
- 12,11,12
- 12,12,10
- 12,12,11
- 12,12,12

El segundo paso ( on x=11..13,y=11..13,z=11..13) vueltas en un 3x3x3 cuboide que se solapa con la primera. Como resultado, solo se encienden 19 cubos adicionales; el resto ya están activados desde el paso anterior:

- 11,11,13
- 11,12,13
- 11,13,11
- 11,13,12
- 11,13,13
- 12,11,13
- 12,12,13
- 12,13,11
- 12,13,12
- 12,13,13
- 13,11,11
- 13,11,12
- 13,11,13
- 13,12,11
- 13,12,12
- 13,12,13
- 13,13,11
- 13,13,12
- 13,13,13

El tercer paso ( off x=9..11,y=9..11,z=9..11) apaga un cuboide de 3x3x3 que se superpone parcialmente con algunos cubos que están encendidos, y finalmente apaga 8 cubos:

- 10,10,10
- 10,10,11
- 10,11,10
- 10,11,11
- 11,10,10
- 11,10,11
- 11,11,10
- 11,11,11

El paso final ( on x=10..10,y=10..10,z=10..10) se convierte en un solo cubo, 10,10,10. Después de este último paso, 39los cubos están en .

El procedimiento de inicialización sólo utiliza cubos que tienen x, yy zposiciones de al menos -50y como máximo 50. Por ahora, ignore los cubos fuera de esta región.

Aquí hay un ejemplo más grande:
```
on x=-20..26,y=-36..17,z=-47..7
on x=-20..33,y=-21..23,z=-26..28
on x=-22..28,y=-29..23,z=-38..16
on x=-46..7,y=-6..46,z=-50..-1
on x=-49..1,y=-3..46,z=-24..28
on x=2..47,y=-22..22,z=-23..27
on x=-27..23,y=-28..26,z=-21..29
on x=-39..5,y=-6..47,z=-3..44
on x=-30..21,y=-8..43,z=-13..34
on x=-22..26,y=-27..20,z=-29..19
off x=-48..-32,y=26..41,z=-47..-37
on x=-12..35,y=6..50,z=-50..-2
off x=-48..-32,y=-32..-16,z=-15..-5
on x=-18..26,y=-33..15,z=-7..46
off x=-40..-22,y=-38..-28,z=23..41
on x=-16..35,y=-41..10,z=-47..6
off x=-32..-23,y=11..30,z=-14..3
on x=-49..-5,y=-3..45,z=-29..18
off x=18..30,y=-20..-8,z=-3..13
on x=-41..9,y=-7..43,z=-33..15
on x=-54112..-39298,y=-85059..-49293,z=-27449..7877
on x=967..23432,y=45373..81175,z=27513..53682
```

Los últimos dos pasos están completamente fuera del área del procedimiento de inicialización; todos los demás pasos están completamente dentro de él. Después de la ejecución de estas medidas en la región procedimiento de inicialización, 590784los cubos están en .

Ejecute los pasos de reinicio. Luego, considerando solo los cubos en la región x=-50..50,y=-50..50,z=-50..50, ¿cuántos cubos hay?