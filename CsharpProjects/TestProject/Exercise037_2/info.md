# Calcular el GPA final [https://learn.microsoft.com/es-es/training/modules/guided-project-calculate-final-gpa/1-introduction]

Los desarrolladores realizan algunas tareas casi todos los días. Las tareas que incluyen declarar variables numéricas y de cadena, asignar y extraer valores, y realizar cálculos no solo son rutinas, sino esenciales. Igualmente importante es la tarea de comunicar los resultados al usuario de la aplicación. Dominar la capacidad de aplicar estas aptitudes para resolver un problema determinado es algo que todos los desarrolladores deben aprender a hacer.
Supongamos que es asistente de profesor en una universidad. Tiene la tarea de desarrollar una aplicación que ayude a calcular el promedio de puntos de grado de los alumnos. La aplicación usa las calificaciones de los alumnos y las horas de crédito tomadas para calcular su GPA general. También se le proporciona un formato necesario para informar el promedio de calificaciones de los alumnos.
Este módulo le guiará por los pasos necesarios para desarrollar la aplicación calculadora de GPA. El código declarará y asignará valores a variables en función de la información del curso, realizar varios cálculos numéricos y dar formato a los resultados. Los cálculos incluyen determinar la suma de los puntos de grado obtenidos y el total de horas de crédito. Para mostrar los resultados en el formato necesario, deberá manipular un valor decimal para mostrar un total de tres dígitos. También usarás métodos Console.WriteLine(), así como secuencias de escape de caracteres que te ayudan a dar formato a tus resultados.
Al final de este módulo, podrá escribir código que use varios tipos de variables, realizar cálculos numéricos y mostrar datos con formato para el usuario.

## Información general del proyecto

Está desarrollando una calculadora de GPA para estudiantes que ayudará a calcular el promedio general de puntos de grado de los alumnos. Los parámetros de la aplicación son:

- Se le proporciona el nombre del alumno y la información sobre la clase.
- Cada clase tiene un nombre, la calificación del alumno y el número de horas de crédito de esa clase.
- La aplicación debe realizar operaciones matemáticas básicas para calcular el GPA del alumno determinado.
- La aplicación debe generar o mostrar el nombre del alumno, la información de clase y el GPA.

Para calcular el GPA:

- Multiplique el valor de grado de un curso por el número de horas de crédito de ese curso.
- Haga esto para cada curso y agregue estos resultados juntos.
- Divida la suma resultante por el número total de horas de crédito.

Se le proporciona el ejemplo siguiente de la información del curso de un alumno y el GPA:
´´´´Csharp
Student: Sophia Johnson

Course          Grade   Credit Hours
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
´´´´
