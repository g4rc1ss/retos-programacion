¡Estás ocupándote de tus propios asuntos en un barco en el mar cuando suena la alarma por la borda! Te apresuras a ver si puedes ayudar. ¡Aparentemente, uno de los Elfos tropezó y accidentalmente envió las llaves del trineo volando al océano!

Antes de que te des cuenta, estás dentro de un submarino que los Elfos mantienen listo para situaciones como esta. Está cubierto de luces navideñas (porque por supuesto que lo está), e incluso tiene una antena experimental que debería poder rastrear las teclas si puede aumentar la intensidad de la señal lo suficiente; hay un pequeño medidor que indica la intensidad de la señal de la antena mostrando 0-50 estrellas .

Tu instinto te dice que para salvar la Navidad, deberás obtener las cincuenta estrellas antes del 25 de diciembre.

Recoge estrellas resolviendo acertijos. Habrá dos rompecabezas disponibles cada día en el calendario de Adviento; el segundo rompecabezas se desbloquea cuando completas el primero. Cada rompecabezas otorga una estrella . ¡Buena suerte!

A medida que el submarino desciende por debajo de la superficie del océano, realiza automáticamente un barrido de sonar del fondo marino cercano. En una pantalla pequeña, aparece el informe de barrido del sonar (su entrada de rompecabezas): cada línea es una medida de la profundidad del fondo marino a medida que el barrido se aleja cada vez más del submarino.

Por ejemplo, suponga que tiene el siguiente informe:
```
199
200
208
210
200
207
240
269
260
263
```
Este informe indica que, escanear hacia fuera desde el submarino, el sonar de barrido encontró profundidades de 199, 200, 208, 210, y así sucesivamente.

La primera orden del día es averiguar qué tan rápido aumenta la profundidad, solo para que sepa a lo que se enfrenta: nunca se sabe si las llaves serán arrastradas a aguas más profundas por una corriente oceánica o un pez o algo así.

Para ello, cuente el número de veces que una medida de profundidad aumenta con respecto a la medida anterior. (No hay medición antes de la primera medición). En el ejemplo anterior, los cambios son los siguientes:

```
199 (N/A - no previous measurement)
200 (increased)
208 (increased)
210 (increased)
200 (decreased)
207 (increased)
240 (increased)
269 (increased)
260 (decreased)
263 (increased)
```

En este ejemplo, hay 7medidas que son más grandes que la medida anterior.

¿Cuántas medidas son más grandes que la medida anterior?