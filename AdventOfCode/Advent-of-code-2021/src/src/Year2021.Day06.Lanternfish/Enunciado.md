Día 6: Pez linterna

El fondo del mar se está haciendo más escarpado. ¿Quizás las llaves del trineo se llevaron de esta manera?

Un enorme cardumen de brillantes peces linterna pasa nadando. Deben generarse rápidamente para alcanzar un número tan grande, ¿tal vez exponencialmente rápido? Debe modelar su tasa de crecimiento para estar seguro.

Aunque no sabes nada sobre esta especie específica de pez linterna, haces algunas conjeturas sobre sus atributos. Seguramente, cada pez linterna crea un nuevo pez linterna una vez cada 7 días.

Sin embargo, este proceso no está necesariamente sincronizado entre todos los peces linterna: a un pez linterna le pueden quedar 2 días hasta que cree otro pez linterna, mientras que otro puede tener 4. Por lo tanto, puede modelar cada pez como un solo número que representa el número de días hasta que crea un nuevo pez linterna .

Además, razona, un nuevo pez linterna seguramente necesitaría un poco más de tiempo antes de ser capaz de producir más peces linterna: dos días más para su primer ciclo.

Entonces, suponga que tiene un pez linterna con un valor de temporizador interno de 3:

- Después de un día, su temporizador interno se convertiría en 2.
- Después de otro día, su temporizador interno se convertiría en 1.
- Después de otro día, su temporizador interno se convertiría en 0.
- Después de otro día, su temporizador interno se restablecería a 6, y crearía un nuevo pez linterna con un temporizador interno de 8.
- Después de otro día, el primer pez linterna tendría un temporizador interno de 5, y el segundo pez linterna tendría un temporizador interno de 7.
Un pez linterna que crea un nuevo pez restablece su temporizador a 6, no7 (porque 0se incluye como un valor de temporizador válido). El nuevo pez linterna comienza con un temporizador interno 8y no comienza la cuenta regresiva hasta el día siguiente.

Al darse cuenta de lo que está tratando de hacer, el submarino produce automáticamente una lista de las edades de varios cientos de peces linterna cercanos (su entrada de rompecabezas). Por ejemplo, suponga que le dieron la siguiente lista:

3,4,3,1,2

Esta lista significa que el primer pez tiene un temporizador interno de 3, el segundo pez tiene un temporizador interno de 4, y así sucesivamente hasta el quinto pez, que tiene un temporizador interno de 2. La simulación de estos peces durante varios días procedería de la siguiente manera:
```
Initial state: 3,4,3,1,2
After  1 day:  2,3,2,0,1
After  2 days: 1,2,1,6,0,8
After  3 days: 0,1,0,5,6,7,8
After  4 days: 6,0,6,4,5,6,7,8,8
After  5 days: 5,6,5,3,4,5,6,7,7,8
After  6 days: 4,5,4,2,3,4,5,6,6,7
After  7 days: 3,4,3,1,2,3,4,5,5,6
After  8 days: 2,3,2,0,1,2,3,4,4,5
After  9 days: 1,2,1,6,0,1,2,3,3,4,8
After 10 days: 0,1,0,5,6,0,1,2,2,3,7,8
After 11 days: 6,0,6,4,5,6,0,1,1,2,6,7,8,8,8
After 12 days: 5,6,5,3,4,5,6,0,0,1,5,6,7,7,7,8,8
After 13 days: 4,5,4,2,3,4,5,6,6,0,4,5,6,6,6,7,7,8,8
After 14 days: 3,4,3,1,2,3,4,5,5,6,3,4,5,5,5,6,6,7,7,8
After 15 days: 2,3,2,0,1,2,3,4,4,5,2,3,4,4,4,5,5,6,6,7
After 16 days: 1,2,1,6,0,1,2,3,3,4,1,2,3,3,3,4,4,5,5,6,8
After 17 days: 0,1,0,5,6,0,1,2,2,3,0,1,2,2,2,3,3,4,4,5,7,8
After 18 days: 6,0,6,4,5,6,0,1,1,2,6,0,1,1,1,2,2,3,3,4,6,7,8,8,8,8
```
Cada día, a se 0convierte en a 6y agrega uno nuevo 8al final de la lista, mientras que cada otro número disminuye en 1 si estaba presente al comienzo del día.

En este ejemplo, después de 18 días, hay un total de 26peces. Después de 80 días, habría un total de 5934.

Encuentre una forma de simular el pez linterna. ¿Cuántos peces linterna habrá después de 80 días?