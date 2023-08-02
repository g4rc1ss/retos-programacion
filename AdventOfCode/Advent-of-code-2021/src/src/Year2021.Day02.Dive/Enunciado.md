Día 2: Buceo!

Ahora, necesitas descubrir cómo pilotear esta cosa .

Parece que el submarino puede tomar una serie de comandos como forward 1, down 2o up 3:

- forward Xaumenta la posición horizontal en Xunidades.
- down X aumenta la profundidad en Xunidades.
- up X disminuye la profundidad en Xunidades.

Tenga en cuenta que, dado que está en un submarino downy upafecta su profundidad , tienen el resultado opuesto de lo que podría esperar.

Parece que el submarino ya tiene un curso planificado (su entrada de rompecabezas). Probablemente deberías averiguar a dónde va. Por ejemplo:

```
forward 5
down 5
forward 8
up 3
down 8
forward 2
```

Tanto su posición horizontal como su profundidad comienzan en 0. Los pasos anteriores los modificarían de la siguiente manera:

- forward 5suma 5a su posición horizontal, un total de 5.
- down 5se suma 5a su profundidad, lo que da como resultado un valor de 5.
- forward 8suma 8a su posición horizontal, un total de 13.
- up 3disminuye su profundidad en 3, resultando en un valor de 2.
- down 8se suma 8a su profundidad, lo que da como resultado un valor de 10.
- forward 2suma 2a su posición horizontal, un total de 15.

Después de seguir estas instrucciones, tendría una posición horizontal de 15y una profundidad de 10. (Multiplicar estos juntos produce 150.)

Calcula la posición horizontal y la profundidad que tendrías después de seguir el rumbo planeado. ¿Qué obtienes si multiplicas tu posición horizontal final por tu profundidad final?

Para comenzar, obtenga su entrada de rompecabezas .