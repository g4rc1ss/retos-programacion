Día 3: Diagnóstico Binario 

El submarino ha estado haciendo algunos crujidos extraños , por lo que le pide que produzca un informe de diagnóstico por si acaso.

El informe de diagnóstico (su entrada de rompecabezas) consiste en una lista de números binarios que, cuando se decodifican correctamente, pueden brindarle muchas cosas útiles sobre las condiciones del submarino. El primer parámetro a comprobar es el consumo de energía .

Debe usar los números binarios en el informe de diagnóstico para generar dos nuevos números binarios (llamados tasa gamma y tasa épsilon ). Luego, el consumo de energía se puede encontrar multiplicando la tasa gamma por la tasa épsilon.

Cada bit de la tasa gamma se puede determinar encontrando el bit más común en la posición correspondiente de todos los números en el informe de diagnóstico. Por ejemplo, dado el siguiente informe de diagnóstico:
```
00100
11110
10110
10111
10101
01111
00111
11100
10000
11001
00010
01010
```

Considerando solo el primer bit de cada número, hay cinco 0bits y siete 1bits. Dado que el bit más común es 1, el primer bit de la tasa gamma es 1.

El segundo bit más común de los números en el informe de diagnóstico es 0, por lo que el segundo bit de la tasa gamma es 0.

El valor más común de la tercera, cuarta, y quinta bits son 1, 1, y 0, respectivamente, y por lo que los tres últimos bits de la tasa de gamma son 110.

Entonces, la tasa gamma es el número binario 10110, o 22en decimal.

La tasa épsilon se calcula de manera similar; en lugar de usar el bit más común, se usa el bit menos común de cada posición. Entonces, la tasa épsilon es 01001, o 9en decimal. Al multiplicar la tasa gamma ( 22) por la tasa épsilon ( 9) se obtiene el consumo de energía, 198.

Use los números binarios en su informe de diagnóstico para calcular la tasa gamma y la tasa épsilon, luego multiplíquelos. ¿Cuál es el consumo de energía del submarino? (Asegúrese de representar su respuesta en decimal, no en binario).