# Definición del Problema
### Enunciado del Problema
Diseña un programa en C# que elimine los caracteres duplicados de una cadena de texto dada. El programa debe mantener el orden de aparición de los caracteres y conservar únicamente la primera aparición de cada carácter.

**Ejemplos**

| Entrada    | Salida   |
|------------|----------|
| Csharpstar | Csharpt  |
| Google     | Gogle    |
| Yahoo      | Yaho     |
| CNN        | CN       |

### Explicación del Problema
Para resolver el problema, necesitamos identificar los caracteres duplicados en la cadena y eliminarlos mientras se preserva el orden de aparición original. 

- Carácter duplicado: Es un carácter que ya ha aparecido anteriormente en la cadena.
- Orden original: Los caracteres deben aparecer en el mismo orden que en la cadena de entrada.

### Desglose de la Solución
1. Análisis
    - Datos de entrada: Una cadena de texto.
    - Datos de salida: Una nueva cadena con los caracteres duplicados eliminados.

2. Estrategia

    - Usaremos un conjunto (`HashSet<char>`) para registrar los caracteres encontrados.
    - Usaremos un `StringBuilder` para construir la cadena resultante, ya que concatenar cadenas directamente es ineficiente en C#.
    - Recorreremos la cadena de entrada carácter por carácter.
        - Si el carácter no está en el conjunto:
            - Lo agregamos al conjunto.
            - Lo añadimos al StringBuilder.
        - Si el carácter ya está en el conjunto:
            - Lo ignoramos.
3. Reglas
    - La solución debe ser eficiente tanto en tiempo como en espacio.
    - El orden de los caracteres no debe alterarse.

### Pseudocódigo
- Inicializar un conjunto vacío (`HashSet`) para registrar los caracteres encontrados.
- Inicializar un StringBuilder vacío para construir la cadena resultante.
- Recorrer cada carácter de la cadena de entrada:
- Si el carácter no está en el conjunto:
    - Agregarlo al conjunto.
    - Agregarlo al StringBuilder.
- Convertir el contenido del StringBuilder a una cadena y retornarla.

Preguntas de Práctica
**¿Qué sucede si la cadena de entrada está vacía?**

Retorna una cadena vacía.

**¿Qué sucede si todos los caracteres son iguales?**

Entrada: "aaaaa" → Salida: "a".

**¿Cómo se optimiza el código para cadenas grandes?**

Usar StringBuilder y HashSet ya optimiza el rendimiento.

