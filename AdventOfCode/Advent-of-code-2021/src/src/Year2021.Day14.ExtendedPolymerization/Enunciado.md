Día 14: Polimerización Extendida

Las increíbles presiones a esta profundidad están empezando a ejercer presión sobre su submarino. El submarino cuenta con equipos de polimerización que producirían materiales adecuados para reforzar el submarino, e incluso las cuevas volcánicas activas cercanas deberían tener los elementos de entrada necesarios en cantidades suficientes.

El manual del submarino contiene instrucciones para encontrar la fórmula de polímero óptima; específicamente, ofrece una plantilla de polímero y una lista de reglas de inserción de pares (su entrada de rompecabezas). Solo necesita averiguar qué polímero resultaría después de repetir el proceso de inserción del par varias veces.

Por ejemplo:
```
NNCB

CH -> B
HH -> N
CB -> H
NH -> C
HB -> C
HC -> B
HN -> C
NN -> C
BH -> H
NC -> B
NB -> B
BN -> B
BB -> N
BC -> B
CC -> N
CN -> C
```
La primera línea es la plantilla de polímero : este es el punto de partida del proceso.

La siguiente sección define las reglas de inserción de pares . Una regla como AB -> Csignifica que cuando los elementos Ay Bson inmediatamente adyacentes, el elemento Cdebe insertarse entre ellos. Todas estas inserciones ocurren simultáneamente.

Entonces, comenzando con la plantilla de polímero NNCB, el primer paso considera simultáneamente los tres pares:

- El primer par ( NN) coincide con la regla NN -> C, por lo que el elemento Cse inserta entre el primero Ny el segundo N.
- El segundo par ( NC) coincide con la regla NC -> B, por lo que el elemento Bse inserta entre el Ny el C.
- El tercer par ( CB) coincide con la regla CB -> H, por lo que el elemento Hse inserta entre el Cy el B.
Tenga en cuenta que estos pares se superponen: el segundo elemento de un par es el primer elemento del siguiente par. Además, debido a que todos los pares se consideran simultáneamente, los elementos insertados no se consideran parte de un par hasta el siguiente paso.

Después del primer paso de este proceso, el polímero se convierte en .NCNBCHB

Aquí están los resultados de algunos pasos usando las reglas anteriores:
```
Template:     NNCB
After step 1: NCNBCHB
After step 2: NBCCNBBBCBHCB
After step 3: NBBBCNCCNBBNBNBBCHBHHBCHB
After step 4: NBBNBNBBCCNBCNCCNBBNBBNBBBNBBNBBCBHCBHHNHCBBCBHCB
```

Este polímero crece rápidamente. Después del paso 5, tiene una longitud de 97; Después del paso 10, tiene una longitud de 3073. Después del paso 10, Bocurre 1749 veces, Cocurre 298 veces, Hocurre 161 veces y Nocurre 865 veces; tomando la cantidad del elemento más común ( B, 1749) y restando la cantidad del elemento menos común ( H, 161) se obtiene .1749 - 161 = 1588

Aplique 10 pasos de inserción de pares a la plantilla de polímero y encuentre los elementos más y menos comunes en el resultado. ¿Qué obtienes si tomas la cantidad del elemento más común y restas la cantidad del elemento menos común?