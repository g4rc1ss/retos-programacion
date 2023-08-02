Día 12: Pasaje Pathing

Con los subsistemas subterráneos de su submarino subsistiendo de manera subóptima , la única forma de salir de esta cueva en el corto plazo es encontrando un camino usted mismo. No solo un camino: la única forma de saber si ha encontrado el mejor camino es encontrarlos todos .

Afortunadamente, la mayoría de los sensores aún funcionan, por lo que crea un mapa aproximado de las cuevas restantes (su entrada de rompecabezas). Por ejemplo:

```
start-A
start-b
A-c
A-b
b-d
A-end
b-end
```
Esta es una lista de cómo están conectadas todas las cuevas. Empiezas en la cueva nombrada starty tu destino es la cueva nombrada end. Una entrada como b-dsignifica que una cueva bestá conectada a otra cueva d, es decir, puede moverse entre ellas.

Entonces, el sistema de cuevas anterior se ve más o menos así:
```
    start
    /   \
c--A-----b--d
    \   /
     end
```
Su objetivo es encontrar la cantidad de caminos distintos que comienzan en start, terminan en endy no visitan cuevas pequeñas más de una vez. Hay dos tipos de cuevas: cuevas grandes (escritas en mayúsculas, como A) y cuevas pequeñas (escritas en minúsculas, como b). Sería una pérdida de tiempo visitar una cueva pequeña más de una vez, pero las cuevas grandes son lo suficientemente grandes como para que valga la pena visitarlas varias veces. Por lo tanto, todos los caminos que encuentre deben visitar cuevas pequeñas como máximo una vez , y pueden visitar cuevas grandes cualquier número de veces .

Dadas estas reglas, hay 10caminos a través de este sistema de cuevas de ejemplo:
```
start,A,b,A,c,A,end
start,A,b,A,end
start,A,b,end
start,A,c,A,b,A,end
start,A,c,A,b,end
start,A,c,A,end
start,A,end
start,b,A,c,A,end
start,b,A,end
start,b,end
```
(Cada línea en la lista anterior corresponde a un solo camino; las cuevas visitadas por ese camino se enumeran en el orden en que fueron visitadas y separadas por comas).

Tenga en cuenta que en este sistema de cuevas, la cueva dnunca es visitada por ningún camino: para hacerlo, la cueva bdebería visitarse dos veces (una vez en el camino a la cueva dy una segunda vez al regresar de la cueva d), y dado que la cueva bes pequeña, esto No se permite.

Aquí hay un ejemplo un poco más grande:
```
dc-end
HN-start
start-kj
dc-start
dc-HN
LN-dc
HN-end
kj-sa
kj-HN
kj-dc
```
Los 19caminos a través de él son los siguientes:

```
start,HN,dc,HN,end
start,HN,dc,HN,kj,HN,end
start,HN,dc,end
start,HN,dc,kj,HN,end
start,HN,end
start,HN,kj,HN,dc,HN,end
start,HN,kj,HN,dc,end
start,HN,kj,HN,end
start,HN,kj,dc,HN,end
start,HN,kj,dc,end
start,dc,HN,end
start,dc,HN,kj,HN,end
start,dc,end
start,dc,kj,HN,end
start,kj,HN,dc,HN,end
start,kj,HN,dc,end
start,kj,HN,end
start,kj,dc,HN,end
start,kj,dc,end
```
Finalmente, este ejemplo aún más grande tiene 226caminos a través de él:

```
fs-end
he-DX
fs-he
start-DX
pj-DX
end-zg
zg-sl
zg-pj
pj-he
RW-he
fs-DX
pj-RW
zg-RW
start-pj
he-WI
zg-he
pj-fs
start-RW
```
¿Cuántos caminos a través de este sistema de cuevas hay que visitan cuevas pequeñas como máximo una vez?