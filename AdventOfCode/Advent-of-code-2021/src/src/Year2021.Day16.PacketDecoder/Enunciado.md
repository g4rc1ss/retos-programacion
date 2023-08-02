Día 16: Decodificador de paquetes ---
Cuando sales de la cueva y llegas a aguas abiertas, recibes una transmisión de los Elfos en el barco.

La transmisión se envió utilizando el Sistema de transmisión de intercambio de flotabilidad ( BITS ), un método para empaquetar expresiones numéricas en una secuencia binaria. La computadora de su submarino ha guardado la transmisión en hexadecimal (su entrada de rompecabezas).

El primer paso para decodificar el mensaje es convertir la representación hexadecimal en binaria. Cada carácter de hexadecimal corresponde a cuatro bits de datos binarios:
```
0 = 0000
1 = 0001
2 = 0010
3 = 0011
4 = 0100
5 = 0101
6 = 0110
7 = 0111
8 = 1000
9 = 1001
A = 1010
B = 1011
C = 1100
D = 1101
E = 1110
F = 1111
```
La transmisión BITS contiene un solo paquete en su capa más externa que a su vez contiene muchos otros paquetes. La representación hexadecimal de este paquete podría codificar algunos 0bits adicionales al final; estos no son parte de la transmisión y deben ignorarse.

Cada paquete comienza con un encabezado estándar: los primeros tres bits codifican la versión del paquete y los siguientes tres bits codifican la ID del tipo de paquete . Estos dos valores son números; todos los números codificados en cualquier paquete se representan como binarios con el bit más significativo primero. Por ejemplo, una versión codificada como secuencia binaria 100representa el número 4.

Los paquetes con ID de tipo 4representan un valor literal . Los paquetes de valor literal codifican un único número binario. Para hacer esto, el número binario se rellena con ceros a la izquierda hasta que su longitud sea un múltiplo de cuatro bits, y luego se divide en grupos de cuatro bits. Cada grupo tiene el prefijo de un 1bit, excepto el último grupo, que tiene el prefijo de un 0bit. Estos grupos de cinco bits siguen inmediatamente al encabezado del paquete. Por ejemplo, la cadena hexadecimal se D2FE28convierte en:

```
110100101111111000101000
VVVTTTAAAAABBBBBCCCCC
```
Debajo de cada bit hay una etiqueta que indica su propósito:

- Los tres bits etiquetados V( 110) son la versión del paquete, 6.
- Los tres bits etiquetados T( 100) son el ID de tipo de paquete 4, lo que significa que el paquete es un valor literal.
- Los cinco bits etiquetados A( 10111) comienzan con a 1(no es el último grupo, siga leyendo) y contienen los primeros cuatro bits del número, 0111.
- Los cinco bits etiquetados B( 11110) comienzan con a 1(no es el último grupo, siga leyendo) y contienen cuatro bits más del número, 1110.
- Los cinco bits etiquetados C( 00101) comienzan con un 0(último grupo, final del paquete) y contienen los últimos cuatro bits del número, 0101.
- Los tres 0bits sin etiquetar al final son adicionales debido a la representación hexadecimal y deben ignorarse.
Entonces, este paquete representa un valor literal con representación binaria 011111100101, que está 2021en decimal.

Cualquier otro tipo de paquete (cualquier paquete con un ID de tipo distinto de 4) representa un operador que realiza algún cálculo en uno o más subpaquetes contenidos dentro. En este momento, las operaciones específicas no son importantes; centrarse en analizar la jerarquía de subpaquetes.

Un paquete de operador contiene uno o más paquetes. Para indicar qué datos binarios subsiguientes representan sus subpaquetes, un paquete de operador puede usar uno de los dos modos indicados por el bit inmediatamente después del encabezado del paquete; esto se llama ID de tipo de longitud :

- Si el ID de tipo de longitud es 0, los siguientes 15 bits son un número que representa la longitud total en bits de los subpaquetes contenidos en este paquete.
- Si el ID de tipo de longitud es 1, los siguientes 11 bits son un número que representa el número de subpaquetes contenidos inmediatamente por este paquete.
Finalmente, después del bit de ID de tipo de longitud y el campo de 15 u 11 bits, aparecen los subpaquetes.

Por ejemplo, aquí hay un paquete de operador (cadena hexadecimal 38006F45291200) con ID de tipo de longitud 0que contiene dos subpaquetes:
```
00111000000000000110111101000101001010010001001000000000
VVVTTTILLLLLLLLLLLLLLLAAAAAAAAAAABBBBBBBBBBBBBBBB
```
- Los tres bits etiquetados V( 001) son la versión del paquete, 1.
- Los tres bits etiquetados T( 110) son el ID del tipo de paquete 6, lo que significa que el paquete es un operador.
- El bit etiquetado I( 0) es el ID de tipo de longitud, lo que indica que la longitud es un número de 15 bits que representa la cantidad de bits en los subpaquetes.
- Los 15 bits etiquetados L( 000000000011011) contienen la longitud de los subpaquetes en bits, 27.
- Los 11 bits etiquetados Acontienen el primer subpaquete, un valor literal que representa el número 10.
- Los 16 bits etiquetados Bcontienen el segundo subpaquete, un valor literal que representa el número 20.
Después de leer 11 y 16 bits de datos de subpaquetes, Lse alcanza la longitud total indicada en (27), por lo que se detiene el análisis de este paquete.

Como otro ejemplo, aquí hay un paquete de operador (cadena hexadecimal EE00D40C823060) con ID de tipo de longitud 1que contiene tres subpaquetes:

```
11101110000000001101010000001100100000100011000001100000
VVVTTTILLLLLLLLLLLAAAAAAAAAAABBBBBBBBBBBCCCCCCCCCCC
```
- Los tres bits etiquetados V( 111) son la versión del paquete, 7.
- Los tres bits etiquetados T( 011) son el ID del tipo de paquete 3, lo que significa que el paquete es un operador.
- El bit etiquetado I( 1) es el ID de tipo de longitud, lo que indica que la longitud es un número de 11 bits que representa la cantidad de subpaquetes.
- Los 11 bits etiquetados L( 00000000011) contienen el número de subpaquetes, 3.
- Los 11 bits etiquetados Acontienen el primer subpaquete, un valor literal que representa el número 1.
- Los 11 bits etiquetados Bcontienen el segundo subpaquete, un valor literal que representa el número 2.
- Los 11 bits etiquetados Ccontienen el tercer subpaquete, un valor literal que representa el número 3.

Después de leer 3 subpaquetes completos, Lse alcanza el número de subpaquetes indicado en (3), por lo que se detiene el análisis de este paquete.

Por ahora, analice la jerarquía de los paquetes a lo largo de la transmisión y sume todos los números de versión .

Aquí hay algunos ejemplos más de transmisiones codificadas en hexadecimal:

- 8A004A801A8002F478representa un paquete de operador (versión 4) que contiene un paquete de operador (versión 1) que contiene un paquete de operador (versión 5) que contiene un valor literal (versión 6); este paquete tiene una versión de suma de 16.
- 620080001611562C8802118E34representa un paquete de operador (versión 3) que contiene dos subpaquetes; cada subpaquete es un paquete de operador que contiene dos valores literales. Este paquete tiene una versión de suma de 12.
- C0015000016115A2E0802F182340tiene la misma estructura que el ejemplo anterior, pero el paquete más externo usa un ID de tipo de longitud diferente. Este paquete tiene una versión de suma de 23.
- A0016C880162017C3686B18A3D4780es un paquete de operador que contiene un paquete de operador que contiene un paquete de operador que contiene cinco valores literales; tiene una versión suma de 31.

Decodifique la estructura de su transmisión BITS codificada en hexadecimal; ¿Qué obtienes si sumas los números de versión en todos los paquetes?