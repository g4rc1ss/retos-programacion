Día 8: Búsqueda de siete segmentos 

Apenas llegas a la seguridad de la cueva cuando la ballena choca contra la boca de la cueva y la derrumba. Los sensores indican otra salida a esta cueva a una profundidad mucho mayor, por lo que no tienes más remedio que seguir adelante.

A medida que su submarino avanza lentamente a través del sistema de cuevas, observa que las pantallas de siete segmentos de cuatro dígitos de su submarino no funcionan correctamente; deben haber sido dañados durante la fuga. Tendrás muchos problemas sin ellos, así que será mejor que averigües qué está mal.

Cada dígito de una pantalla de siete segmentos se representa activando o desactivando cualquiera de los siete segmentos nombrados a através de g:

```
  0:      1:      2:      3:      4:
 aaaa    ....    aaaa    aaaa    ....
b    c  .    c  .    c  .    c  b    c
b    c  .    c  .    c  .    c  b    c
 ....    ....    dddd    dddd    dddd
e    f  .    f  e    .  .    f  .    f
e    f  .    f  e    .  .    f  .    f
 gggg    ....    gggg    gggg    ....

  5:      6:      7:      8:      9:
 aaaa    aaaa    aaaa    aaaa    aaaa
b    .  b    .  .    c  b    c  b    c
b    .  b    .  .    c  b    c  b    c
 dddd    dddd    ....    dddd    dddd
.    f  e    f  .    f  e    f  .    f
.    f  e    f  .    f  e    f  .    f
 gggg    gggg    ....    gggg    gggg
```
Entonces, para renderizar un 1, solo los segmentos cy festarían activados; el resto estaría apagado. Para hacer una 7, sólo los segmentos a, cy fse enciende.

El problema es que las señales que controlan los segmentos se han mezclado en cada pantalla. El submarino todavía está tratando de mostrar los números mediante la producción de salida en los cables de señal aa través de g, pero esos cables están conectados a segmentos al azar . Peor aún, ¡las conexiones de cable/segmento se mezclan por separado para cada pantalla de cuatro dígitos! (Sin embargo, todos los dígitos dentro de una pantalla usan las mismas conexiones).

Por lo tanto, es posible saber que sólo los cables de señal by gestá activada, pero eso no significa que los segmentos b y gestá encendido: el único dígito que utiliza dos segmentos es 1, por lo que debe significar segmentos cy festá destinado a ser sucesivamente. Con solo esa información, aún no puede saber qué cable ( b/ g) va a qué segmento ( c/ f). Para eso, necesitará recopilar más información.

Para cada pantalla, observa las señales cambiantes durante un tiempo, toma nota de los diez patrones de señal únicos que ve y luego escribe un valor de salida de cuatro dígitos (su entrada de rompecabezas). Usando los patrones de señal, debería poder determinar qué patrón corresponde a qué dígito.

Por ejemplo, esto es lo que podría ver en una sola entrada en sus notas:

acedgfb cdfbe gcdfa fbcad dab cefabd cdfgeb eafb cagedb ab |
cdfeb fcadb cdfeb cdbaf
(La entrada está envuelta aquí en dos líneas para que quepa; en sus notas, todo estará en una sola línea).

Cada entrada consta de diez patrones de señal únicos , un |delimitador y, finalmente, el valor de salida de cuatro dígitos . Dentro de una entrada, se utilizan las mismas conexiones de cable/segmento (pero no sabe cuáles son realmente las conexiones). Los patrones de señal únicos corresponden a las diez formas diferentes en que el submarino intenta representar un dígito utilizando las conexiones actuales de cable/segmento. Debido a que 7es el único dígito que utiliza tres segmentos, daben los medios de ejemplo anteriores se desprende que para rendir una 7, líneas de señal d, ay bson sobre. Debido a que 4es el único dígito que utiliza cuatro segmentos, eafbsignifica que para hacer Un 4, líneas de señales e, a, f, y bestán encendidas.

Con esta información, debería poder determinar qué combinación de cables de señal corresponde a cada uno de los diez dígitos. Luego, puede decodificar el valor de salida de cuatro dígitos. Desafortunadamente, en el ejemplo anterior, todos los dígitos en el valor de salida ( cdfeb fcadb cdfeb cdbaf) usan cinco segmentos y son más difíciles de deducir.

Por ahora, concéntrate en los dígitos fáciles . Considere este ejemplo más grande:
```
be cfbegad cbdgef fgaecd cgeb fdcge agebfd fecdb fabcd edb |
fdgacbe cefdb cefbgd gcbe
edbfga begcd cbg gc gcadebf fbgde acbgfd abcde gfcbed gfec |
fcgedb cgb dgebacf gc
fgaebd cg bdaec gdafb agbcfd gdcbef bgcad gfac gcb cdgabef |
cg cg fdcagb cbg
fbegcd cbd adcefb dageb afcb bc aefdc ecdab fgdeca fcdbega |
efabcd cedba gadfec cb
aecbfdg fbg gf bafeg dbefa fcge gcbea fcaegb dgceab fcbdga |
gecf egdcabf bgf bfgea
fgeab ca afcebg bdacfeg cfaedg gcfdb baec bfadeg bafgc acf |
gebdcfa ecba ca fadegcb
dbcfg fgd bdegcaf fgec aegbdf ecdfab fbedc dacgb gdcebf gf |
cefg dcbef fcge gbcadfe
bdfegc cbegaf gecbf dfcage bdacg ed bedf ced adcbefg gebcd |
ed bcgafe cdgba cbgef
egadfb cdbfeg cegd fecab cgb gbdefca cg fgcdab egfdb bfceg |
gbdfcae bgc cg cgb
gcafb gcf dcaebfg ecagb gf abcdeg gaef cafbge fdbac fegbdc |
fgae cfgab fg bagce
```
Debido a que los dígitos 1, 4, 7y 8cada uno usa un número único de segmentos, debería poder decir qué combinaciones de señales corresponden a esos dígitos. Contando solo los dígitos en los valores de salida (la parte posterior |de cada línea), en el ejemplo anterior, hay 26instancias de dígitos que usan una cantidad única de segmentos (resaltados arriba).

En los valores de salida, ¿cuántas veces dígitos 1, 4, 7, o 8 aparecerá?