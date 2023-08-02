Día 10: Puntuación de sintaxis 

Le pides al submarino que determine la mejor ruta para salir de la cueva de aguas profundas, pero solo responde:

Syntax error in navigation subsystem on line: all of them
¡¿Todos ellos?! El daño es peor de lo que pensabas. Muestra una copia del subsistema de navegación (su entrada de rompecabezas).

La sintaxis del subsistema de navegación se compone de varias líneas que contienen fragmentos . Hay uno o más fragmentos en cada línea, y los fragmentos contienen cero o más fragmentos. Los fragmentos adyacentes no están separados por ningún delimitador; si un fragmento se detiene, el siguiente fragmento (si lo hay) puede comenzar de inmediato. Cada fragmento debe abrirse y cerrarse con uno de los cuatro pares legales de caracteres coincidentes:

- Si un fragmento se abre con `(`, debe cerrarse con `)`.
- Si un fragmento se abre con `[`, debe cerrarse con `]`.
- Si un fragmento se abre con `{`, debe cerrarse con `}`.
- Si un fragmento se abre con `<`, debe cerrarse con `>`.

Entonces, ()es un fragmento legal que no contiene otros fragmentos, como es []. Más trozos complejas, pero válidos incluyen ([]), {()()()}, <([{}])>, [<>({}){}[([])<>]], e incluso (((((((((()))))))))).

Algunas líneas están incompletas , pero otras están corruptas . Encuentre y deseche las líneas corruptas primero.

Una línea corrupta es aquella en la que un fragmento se cierra con el carácter incorrecto , es decir, donde los caracteres con los que se abre y se cierra no forman uno de los cuatro pares legales enumerados anteriormente.

Ejemplos de trozos dañados incluyen (], {()()()>, (((()))}, y <([]){()}[{}]). Dicho fragmento puede aparecer en cualquier lugar dentro de una línea y su presencia hace que toda la línea se considere corrupta.

Por ejemplo, considere el siguiente subsistema de navegación:
```
[({(<(())[]>[[{[]{<()<>>
[(()[<>])]({[<{<<[]>>(
{([(<{}[<>[]}>{[]{[(<()>
(((({<>}<{<{<>}{[]{[]{}
[[<[([]))<([[{}[[()]]]
[{[{({}]{}}([{[{{{}}([]
{<[[]]>}<{[{[{[]{()[[[]
[<(<(<(<{}))><([]([]()  
<{([([[(<>()){}]>(<<{{
<{([{{}}[<[[[<>{}]]]>[]]
```
Algunas de las líneas no están corruptas, simplemente incompletas; puedes ignorar estas líneas por ahora. Las cinco líneas restantes están dañadas:

- `{([(<{}[<>[]}>{[]{[(<()>`- Esperado ], pero encontrado en su }lugar.
- `[[<[([]))<([[{}[[()]]]`- Esperado ], pero encontrado en su )lugar.
- `[{[{({}]{}}([{[{{{}}([]`- Esperado ), pero encontrado en su ]lugar.
- `[<(<(<(<{}))><([]([]()`- Esperado >, pero encontrado en su )lugar.
- `<{([([[(<>()){}]>(<<{{`- Esperado ], pero encontrado en su >lugar.

Deténgase en el primer carácter de cierre incorrecto en cada línea corrupta.

¿Sabía que los verificadores de sintaxis en realidad tienen concursos para ver quién puede obtener la puntuación más alta por errores de sintaxis en un archivo? ¡Es cierto! Para calcular la puntuación de error de sintaxis de una línea, tome el primer carácter no válido de la línea y búsquelo en la siguiente tabla:

- `)`: 3puntos.
- `]`: 57puntos.
- `}`: 1197puntos.
- `>`: 25137puntos.

En el ejemplo anterior, )se encontró un ilegal dos veces ( puntos), se encontró un ilegal una vez ( puntos), se encontró un ilegal una vez ( puntos) y se encontró un ilegal una vez ( puntos). Entonces, ¡la puntuación total de error de sintaxis para este archivo es puntos!2*3 = 6]57}1197>251376+57+1197+25137 = 26397

Encuentra el primer carácter ilegal en cada línea corrupta del subsistema de navegación. ¿Cuál es la puntuación total de errores de sintaxis para esos errores?